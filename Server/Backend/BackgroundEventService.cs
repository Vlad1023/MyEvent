using Backend.Repositories;
using Backend.Services;
using Backend.Services.Email;
using Backend.Services.Event;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Backend
{
    public class BackgroundEventService : BackgroundService
    {
        readonly IServiceProvider _serviceProvider;
        public BackgroundEventService(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
        }
        private const int generalDelay = 6000; // 1 minute

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(generalDelay, stoppingToken);
                await CheckEvents();
            }
        }

        private async Task CheckEvents()
        {
            if(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") != "Development")
            {
                DateTime now = DateTime.Now;
                using (IServiceScope scope = _serviceProvider.CreateScope())
                {
                    IEventService _eventService =
                        scope.ServiceProvider.GetRequiredService<IEventService>();
                    IEventRepository _eventRepository =
                        scope.ServiceProvider.GetRequiredService<IEventRepository>();
                    IEmailService _emailService =
                        scope.ServiceProvider.GetRequiredService<IEmailService>();
                    IUserService _userService =
                        scope.ServiceProvider.GetRequiredService<IUserService>();


                    var allEvents = await _eventService.GetAllEvents();
                    foreach (var item in allEvents.Data)
                    {
                        if (now > item.EndDatetime)
                        {
                            _eventService.PopulateParticipants(item);
                            foreach (var userId in item.PariticipantsIds.Concat(new List<string> { item.AuthorId }))
                            {
                                var user = await _userService.GetUserById(userId);
                                _emailService.SendEmailThatEventFinished(user.Data.Email, item.EventName, user.Data.Login);
                            }
                            _eventRepository.FinishEvent(item.EventId);
                        }
                    }

                }
            }
        }
    }
}

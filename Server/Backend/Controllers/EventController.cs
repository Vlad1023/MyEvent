using Backend.Models;
using Backend.Models.EventParticipants;
using Backend.Services.Event;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : Controller
    {
        private readonly IEventService _eventService;

        public EventController(IEventService _eventService)
        {
            this._eventService = _eventService;
        }

        [HttpGet]
        [Route("getAllEvents")]
        public async Task<IActionResult> GetEvents()
        {
            var result = await _eventService.GetAllEvents();
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }
        [HttpGet]
        [Route("getAllUpcomingEvents")]
        public async Task<IActionResult> GetUpcomingEvents([FromQuery] string userId, [FromQuery]string textToSearch = "ANY")
        {
             var result = await _eventService.GetAllUpcomingEvents(textToSearch, userId);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }

        [HttpGet]
        [Route("getNearestEvents")]
        public async Task<IActionResult> GetNearestEvents([FromQuery] double longitute, [FromQuery] double latitude, [FromQuery] string userId)
        {
            var result = await _eventService.GetNearestEvents(longitute, latitude, userId);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }

        [Authorize]
        [HttpPost]
        [Route("addEvent")]
        public async Task<IActionResult> AddEvent([FromForm] AddEvent newEvent)
        {
            var result = await _eventService.AddEvent(newEvent);          
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }
        [Authorize]
        [HttpPost]
        [Route("addEventBasedOnOriginal")]
        public async Task<IActionResult> AddEventBasedOnOriginal([FromBody] AddEventBasedOnOriginal newEvent)
        {
            var result = await _eventService.AddEventBasedOnOriginal(newEvent);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }
        [Authorize]
        [HttpPut]
        [Route("updateEvent")]
        public async Task<IActionResult> UpdateEvent([FromForm] UpdateEvent newEvent)
        {
            var result = await _eventService.UpdateEvent(newEvent);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }
        [Authorize]
        [HttpPost]
        [Route("addEventParticipant")]
        public async Task<IActionResult> AddEventParticipant([FromBody] AddEventParticipant newParticipant)
        {
            var result = await _eventService.AddEventParticipant(newParticipant);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }
        [Authorize]
        [HttpDelete]
        [Route("deleteEventParticipant")]
        public IActionResult DeleteEventParticipant([FromBody]  DeleteEventParticipant deleteParticipant)
        {
            var result = _eventService.DeleteEventParticipant(deleteParticipant);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }

        [Authorize]
        [HttpGet]
        [Route("getEventLocation")]
        public IActionResult GetEventLocation([FromQuery] string locationId)
        {
            var result = _eventService.GetEventLocation(locationId);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }

        [Authorize]
        [HttpGet]
        [Route("getUserEvents")]
        public async Task<IActionResult> GetUserEvents([FromQuery] string userId, [FromQuery] string textToSearch = "ANY")
        {
            var result = await _eventService.GetUserEvents(userId, textToSearch);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }

        [Authorize]
        [HttpGet]
        [Route("getUserFinishedEvents")]
        public async Task<IActionResult> GetUserFinishedEvents([FromQuery] string userId, [FromQuery]string textToSearch = "ANY")
        {
            var result = await _eventService.GetUserFinishedEvents(userId, textToSearch);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }

        [Authorize]
        [HttpPatch]
        [Route("cancelEvent")]
        public  IActionResult CancelEvent(string eventId)
        {
            var result =  _eventService.CancelEvent(eventId);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }

        [Authorize]
        [HttpPatch]
        [Route("uncancelEvent")]
        public  IActionResult UncancelEvent(string eventId)
        {
            var result =  _eventService.UncancelEvent(eventId);
            if (result.Data != null)
            {
                return Ok(result.Data);
            }
            return new JsonResult(result.Error.Message) { StatusCode = result.Error.Code };
        }
    }
}

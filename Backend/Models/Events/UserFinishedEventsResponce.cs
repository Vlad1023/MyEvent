using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class UserFinishedEventsResponce
    {
        public IEnumerable<EventResponce> FinishedEvents { get; set; }
        public IEnumerable<EventResponce> CancelledEvents { get; set; }
    }
}

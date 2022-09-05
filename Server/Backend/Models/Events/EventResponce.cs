using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class EventResponce
    {
        public string EventId { get; set; }
        public string OriginalEventId { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public float Rate { get; set; }
        public DateTime StartDatetime { get; set; }
        public DateTime EndDatetime { get; set; }
        public bool IsCancelled { get; set; }
        public bool isFinished { get; set; }
        public string AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string LocationId { get; set; }
        public int? FriendsParticipantCount { get; set; }
        public string AdressShort { get; set; }
        public ICollection<string> PariticipantsIds { get; set; }
        public int ReviewsCount { get; set; }
        public string ImagePath { get; set; }
        public bool IsCreatedFromOriginal { get; set; }
    }
}

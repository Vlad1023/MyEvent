using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class EventDB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string EventId { get; set; }
        [Required]
        public string EventName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(0, 5)]
        public float Rate { get; set; }
        [Required]
        public DateTime StartDatetime { get; set; }
        [Required]
        public DateTime EndDatetime { get; set; }
        public User User { get; set; }
        [Required]
        public string UserID { get; set; }
        [Required]
        public string LocationID { get; set; }
        [Required]
        public bool isFinished { get; set; }
        [Required]
        public string ImagePath { get; set; }
        public LocationDB Location { get; set; }
        public bool IsCancelled { get; set; }
        public bool IsCreatedFromOriginal { get; set; }
        public string OriginalEventId { get; set; }

        public ICollection<EventParticipantsDB> EventParticipants { get; set; }
        public ICollection<CommentsDB> Comments { get; set; }
        public ICollection<ReviewsDB> Reviews { get; set; }
    }

}

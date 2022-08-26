using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class EventParticipantsDB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string EventParticipantsId { get; set; }

        public EventDB Event { get; set; }
        public string EventId { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
    }
}

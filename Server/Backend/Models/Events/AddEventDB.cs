using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class AddEventDB
    {
        public string EventName { get; set; }
        public string Description { get; set; }
        public float Rate { get; set; }
        public DateTime StartDatetime { get; set; }
        public DateTime EndDatetime { get; set; }
        public bool IsCancelled { get; set; }
        public string UserID { get; set; }
        public string LocationID { get; set; }
        public string ImagePath { get; set; }
    }
}

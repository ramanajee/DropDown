using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenueAPI.Models
{
   public class Event
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string StartTime { get; set; }
        public virtual IEnumerable<Venue> Venues { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<Speaker> Speakers { get; set; }
        public virtual IEnumerable<Session> Sessions { get; set; }
    }
}

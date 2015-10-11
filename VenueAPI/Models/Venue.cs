using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenueAPI.Models
{
    public class Venue
    {
        [Key]
        public int Id { get; set; }
        public string Address { get; set; }
        public string Street { get; set; }
        public string Date { get; set; }
        public virtual Event Events { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenueWeb.Models
{
    public class Venue
    {
        [Key]
        public int Id { get; set; }
        public string Address { get; set; }
        public string Street { get; set; }
        public DateTime Date { get; set; }
    }
}

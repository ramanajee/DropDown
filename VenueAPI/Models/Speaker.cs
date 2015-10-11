using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenueAPI.Models
{
    public class Speaker
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Descrption { get; set; }
        public string Photo { get; set; }
        public virtual Event Events { get; set; }
    }
}

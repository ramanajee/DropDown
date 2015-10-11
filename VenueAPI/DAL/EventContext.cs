using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VenueAPI.Models;

namespace VenueAPI.DAL
{
    class EventContext:DbContext
    {
        public EventContext():base("DefaultConnection")
        {

        }
        public DbSet<Event> Events { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Venue> Venus { get; set; }
    }
}

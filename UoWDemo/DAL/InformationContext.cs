using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UoWDemo.Models;

namespace UoWDemo.DAL
{
    public class InformationContext:DbContext
    {
        public InformationContext():base()
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    } 
}

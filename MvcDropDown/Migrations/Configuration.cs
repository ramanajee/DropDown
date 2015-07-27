namespace MvcDropDown.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcDropDown.Models.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcDropDown.Models.StudentContext";
        }

        protected override void Seed(MvcDropDown.Models.StudentContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Students.AddOrUpdate(
                new Models.Student {  Id = 1, Name = "Step1", City = "HYD"},
                new Models.Student { Id = 1, Name = "Step2", City = "BNGLR" },
                new Models.Student { Id = 1, Name = "Step3", City = "MUM" }
                );
        }
    }
}

using Microsoft.AspNet.Identity.EntityFramework;
using QDAR.Models;
using System.Data.Entity;
using System.Linq;

namespace QDAR.DataModel
{
    public class QDARContext : IdentityDbContext
    {
        public QDARContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<DailyProgress> DailyProgress { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityUser>().ToTable("User").Property(p => p.Id).HasColumnName("UserId");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRole");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogin");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaim").Property(p => p.Id).HasColumnName("UserClaimId");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
        }

        public static QDARContext Create()
        {
            return new QDARContext();
        }
    }
    //Example
    public class Repo
    {
        public void Test()
        {
           var db = QDARContext.Create();
            var dailyProgress = db.DailyProgress.ToList();
        }
    }
}

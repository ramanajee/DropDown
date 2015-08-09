using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;

namespace QDAR.Models
{
    #region Model Classes
    public class User:IdentityUser
    {
        public string SkypeAccount { get; set; }
        public DateTime DOB { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<DailyProgress> DailyProgress { get; set; }
    }
    public class DailyProgress
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public string WorkAssigned { get; set; }
        public int WorkAssignedStatusId { get; set; }
        public string Conceptually { get; set; }
        public int ConceptuallyStatusId { get; set; }
        public string Technically { get; set; }
        public int TechnicallyStatusId { get; set; }
        public string Achievements { get; set; }
        public string CollabarationWorkEnvironment { get; set; }
        public int CollabarationWorkEnvironmentId { get; set; }
        public string StandardsOfCoding { get; set; }
        public int StandardsOfCodingStatusId { get; set; }
        public string WorkFlow { get; set; }
        public int ProjectId { get; set; }
        public User User { get; set; }
        public virtual Status Status { get; set; }
        public virtual Project Project { get; set; }
    }
    public class Comments
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public virtual User User { get; set; }
    }
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Notifications
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string NotificationContent { get; set; }
        public DateTime Date { get; set; }
        public string DeletedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string CreatedBy { get; set; }
        public virtual User User { get; set; }
    }
    public class News
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string NewsContent { get; set; }
        public DateTime Date { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public virtual User User { get; set; }
    }
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    #endregion
}

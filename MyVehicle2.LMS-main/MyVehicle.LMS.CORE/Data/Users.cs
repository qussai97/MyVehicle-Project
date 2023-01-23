using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyVehicle.LMS.CORE.Data
{
  public  class Users
    {
        [Key]
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string UserImage { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public int SettingId { get; set; }
        public int loginId { get; set; }

        [ForeignKey("loginId")]

        public virtual Login Login  { get; set; }

        [ForeignKey("SettingId")]

        public virtual WebsiteSetting WebsiteSetting { get; set; }
        public ICollection<Attendance> Attendances { get; set; }

        public ICollection<Cards> Cards { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Report> Reports { get; set; }
        public ICollection<TaskJob> TaskJobs { get; set; }
        public ICollection<Vehicles> Vehicles { get; set; }

        public ICollection<Payment> Payments  { get; set; }
        public ICollection<Login> Logins  { get; set; }

        public ICollection<Salary1> Salary1s { get; set; }

    }
}

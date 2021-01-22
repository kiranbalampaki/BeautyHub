using BeautyHub.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeautyHub.Entities
{
    public class Appointment
    {
        
        public int Id { get; set; }

        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Display(Name ="Phone Number")]
        [Required]
        public string PhoneNumber { get; set; }

        public string Message { get; set; }
        public bool IsServed { get; set; }

        public Service Service { get; set; }
        public int ServiceId { get; set; }

        public DateTime AppointmentDate { get; set; }

        public ServiceTime ServiceTime { get; set; }
        public int ServiceTimeId { get; set; }

        public ApplicationUser User { get; set; }
        public string UserId { get; set; }

        public OfficeLocation OfficeLocation { get; set; }
        public int OfficeLocationId { get; set; }

        public Appointment()
        {
            this.IsServed = false;
        }
    }

}
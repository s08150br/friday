//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NDHLee.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Volunteer
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First name required")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name required")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        //[Remote("IsEmailAvailable", "Volunteer", ErrorMessage = "Email in use.")]
        [Required(ErrorMessage = "Email required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Please provide a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Address required")]
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone number required")]
        public string Phone { get; set; }

        [Display(Name = "Active/inactive")]
        public bool ApplicationStatus { get; set; }

        [Display(Name = "Date of application submission")]
        public System.DateTime ApplicationStart { get; set; }

        public string Department { get; set; }

        [Display(Name = "Volunteer start date")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> StartDate { get; set; }
        public string Testimonial { get; set; }

        [Display(Name = "Testimonial publish")]
        public Nullable<bool> Testimonial_Publish { get; set; }


        public string Province { get; set; }

        [DataType(DataType.PostalCode)]
        [Display(Name = "Postal code")]
        public string Postal_Code { get; set; }

        [Display(Name = "City/Town")]
        [Required(ErrorMessage = "What city or town do you live in?")]
        public string City { get; set; }

        public Nullable<bool> Terms { get; set; }
    }
}
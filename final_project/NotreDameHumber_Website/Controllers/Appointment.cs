//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NotreDameHumber_Website.Controllers
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appointment
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> PreferredDate { get; set; }
        public Nullable<System.TimeSpan> PreferredTime { get; set; }
        public string Description { get; set; }
        public Nullable<int> Service { get; set; }
        public Nullable<int> Therapist { get; set; }
        public string Set { get; set; }
    }
}
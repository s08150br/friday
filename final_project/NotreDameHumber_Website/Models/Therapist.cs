//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NotreDameHumber_Website.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Therapist
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string LicenseNum { get; set; }
        public string Expertise { get; set; }
        public Nullable<int> Experience { get; set; }
        public Nullable<double> Price { get; set; }
        public string Info { get; set; }
    }
}

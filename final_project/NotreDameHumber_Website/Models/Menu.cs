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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Menu
    {
        [Key]
        public int Id { get; set; }
        //[Required(ErrorMessage = "Please enter a name for the menu link.")]
        [RegularExpression(@"^([ \u00c0-\u01ffa-zA-Z'\-])+$", ErrorMessage = "Please enter upper and lower case alphabets only.")]
        public string Name { get; set; }
        [DisplayName("Parent Link")]
        public Nullable<int> ParentId { get; set; }
        [RegularExpression(@"^([ \u00c0-\u01ffa-zA-Z'\-])+$", ErrorMessage = "Please enter upper and lower case alphabets only.")]
        [Required(ErrorMessage = "Please enter a action for the menu link.")]
        public string Action { get; set; }
        [RegularExpression(@"^([ \u00c0-\u01ffa-zA-Z'\-])+$", ErrorMessage = "Please enter upper and lower case alphabets only.")]
        [Required(ErrorMessage = "Please enter related controller for the menu link.")]
        public string Controller { get; set; }
    }
}

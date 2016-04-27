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

    public partial class Blog
    {
        public Blog()
        {
            this.Comments = new HashSet<Comment>();
        }
        
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Image { get; set; }
        public string Body { get; set; }

        public Nullable<bool> Publish { get; set; }

        [DataType(DataType.DateTime)]
        public Nullable<System.DateTime> PublishDate { get; set; }
    
        public virtual ICollection<Comment> Comments { get; set; }
    }
}

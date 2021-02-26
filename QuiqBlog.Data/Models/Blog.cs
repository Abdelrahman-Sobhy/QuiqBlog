using System;
using System.Collections.Generic;
using System.Text;

namespace QuiqBlog.Data.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public ApplicationUser TheCreator { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Approved { get; set; }
        public ApplicationUser Approver { get; set; }
        public bool Published { get; set; }
    }
}

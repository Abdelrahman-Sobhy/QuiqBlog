using System;
using System.Collections.Generic;

namespace QuiqBlog.Data.Models
{
    public class Post
    {
        public int Id { get; set; }
        public Blog Blog { get; set; }
        public ApplicationUser Poster { get; set; }
        public string Content { get; set; }
        public Post Parent { get; set; }
        public DateTime CreatedOn { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; }
    }
}

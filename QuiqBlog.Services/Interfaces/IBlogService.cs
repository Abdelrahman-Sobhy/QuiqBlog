using QuiqBlog.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuiqBlog.Services.Interfaces
{
     public interface IBlogService
    {
        Task<Blog> Add(Blog blog);
    }
}

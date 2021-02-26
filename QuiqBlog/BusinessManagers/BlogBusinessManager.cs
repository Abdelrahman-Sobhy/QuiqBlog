using Microsoft.AspNetCore.Identity;
using QuiqBlog.BusinessManagers.Interfaces;
using QuiqBlog.Data.Models;
using QuiqBlog.Models.BlogViewModels;
using QuiqBlog.Services.Interfaces;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace QuiqBlog.BusinessManagers
{
    public class BlogBusinessManager : IBlogBusinessManager
    {
        private readonly UserManager<ApplicationUser> userManger;
        private readonly IBlogService blogService;
        public BlogBusinessManager(UserManager<ApplicationUser> userManager, IBlogService blogService)
        {
            this.userManger = userManager;
            this.blogService = blogService;
        }

        public async Task<Blog> CreateBlog(CreateBlogViewModel createBlogViewModel, ClaimsPrincipal claimsPrincipal )
        {
            Blog blog = createBlogViewModel.Blog;
            blog.TheCreator = await userManger.GetUserAsync(claimsPrincipal);
            blog.CreatedOn = DateTime.Now;
            return await blogService.Add(blog);
        }
    }
}

using Crescendo_User.Application.Services.Blog;
using Microsoft.AspNetCore.Mvc;

namespace Crescendo_User.Api.Controller
{
    public class BlogController : BaseApiController
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBlogs()
        {
            var resp =await  _blogService.GetBlogs();
            return Ok(resp);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogById(long id)
        {
            var resp = await _blogService.GetBlogById(id);
            return Ok(resp);
        }

    }
}
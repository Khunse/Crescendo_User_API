namespace Crescendo_User.Application.Services.Blog
{
    public interface IBlogService
    {
       Task<List<BlogResult>> GetBlogs();
       Task<BlogResult> GetBlogById(long id);
    }
}
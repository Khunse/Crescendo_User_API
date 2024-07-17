namespace Crescendo_User.Application.Services.Blog
{
    public interface IBlogService
    {
       Task<List<BlogResult>> GetBlogs();
    }
}
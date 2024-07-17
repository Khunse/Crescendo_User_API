using Crescendo_User.Application.Common.DataBase;

namespace Crescendo_User.Application.Services.Blog;

public class BlogService : IBlogService
{
    private readonly IBlogDBService _blogDBService;

    public BlogService(IBlogDBService blogDBService)
    {
        _blogDBService = blogDBService;
    }
    public async Task<List<BlogResult>> GetBlogs()
    {
        var listdata =  await _blogDBService.GetBlogsDB();

        return listdata;
    }
}
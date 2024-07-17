using Crescendo_User.Application.Services.Blog;

namespace Crescendo_User.Application.Common.DataBase;

public interface IBlogDBService
{
    Task<List<BlogResult>> GetBlogsDB();
}
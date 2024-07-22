
using Crescendo_User.Application.Common.DataBase;
using Crescendo_User.Application.Services.Blog;
using Crescendo_User.Infrastructure.Models;
using Supabase;

namespace Crescendo_User.Infrastructure;

public class BlogDBService : IBlogDBService
{
    private readonly Client _supabase;
    public BlogDBService(Client client)
    {
        _supabase = client;
    }

    public async Task<BlogResult> GetBlogByIdDB(long Id)
    {
        var data = await _supabase.From<Blog>().Where(w => w.Id == Id).Get();

        if (data.Models.Count > 0)
        {
            var dataBlog = data.Models[0];
        return new BlogResult(dataBlog.Id,dataBlog.Created_at,dataBlog.Title,dataBlog.Image,dataBlog.Paragraph,[dataBlog.Categories]);
        }
        return null;
    }

    public async Task<List<BlogResult>> GetBlogsDB()
    {
        var respData = new List<BlogResult>();
        var data = await _supabase.From<Blog>().Get();

        if( data.Models.Count > 0 )
        {

         data.Models.ForEach(w => {
            
            respData.Add(new BlogResult(
                w.Id,
                w.Created_at,
                w.Title,
                w.Image,
                w.Paragraph,
                []
            ));
         });   

        }
        return respData;
    }
}

using Crescendo_User.Application.Services.Blog;
using Microsoft.Extensions.DependencyInjection;

namespace Crescendo_User.Application;

public static class DependencyInjectionApplication
{

    public static IServiceCollection AddApplication(this IServiceCollection services)
    {

        services.AddScoped<IBlogService,BlogService>();
        return services;
    }
}
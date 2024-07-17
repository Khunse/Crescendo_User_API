using Crescendo_User.Application.Common.DataBase;
using Crescendo_User.Infrastructure.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Supabase;
using Supabase.Functions;

namespace Crescendo_User.Infrastructure
{

    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
        {
            // services.Configure<Dbsetting>(configuration.GetSection("DBSetting"));
                var url = "https://asdkfwfibyvttthucqbg.supabase.co";
                var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImFzZGtmd2ZpYnl2dHR0aHVjcWJnIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MjExODgyMzQsImV4cCI6MjAzNjc2NDIzNH0.nZPmAdgZQhTgbEN1klqB3TKXupCX29Tq6_FLwtPDAKk";

                var options = new SupabaseOptions
                    {
                        AutoConnectRealtime = true,
                        AutoRefreshToken = true
                    };
        
           services.AddScoped<Supabase.Client>( _ => new Supabase.Client(url,key,options));

            services.AddScoped<IBlogDBService,BlogDBService>();

            return services;
        }

    }
}
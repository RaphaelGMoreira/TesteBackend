using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PostoGasolina.Contex;
using PostoGasolina.Entity;
using PostoGasolina.Repositories;

namespace PostoGasolina.Data.Extensions
{
    public static class DataExtensions
    {
        public static IServiceCollection AddEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<PostoContext>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString("PostoGasolinaSqlite"));
            });

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            return services;
        }
    }
}
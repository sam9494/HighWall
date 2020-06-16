using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HighWall.Core.Service;
using HighWall.DB.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace HighWall.Web.Helper
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<ICapitalismService, CapitalismService>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        } 
    }
}

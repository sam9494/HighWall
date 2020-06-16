using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HighWall.Core.Service;
using Microsoft.Extensions.DependencyInjection;

namespace HighWall.Web.Helper
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<ICapitalismService, CapitalismService>();

            return services;
        } 
    }
}

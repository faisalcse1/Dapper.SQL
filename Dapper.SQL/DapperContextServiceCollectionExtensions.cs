using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace Dapper.SQL
{
    public static class DapperContextServiceCollectionExtensions
    {
        public static IServiceCollection AddDapperContext(this IServiceCollection services, Action<DapperContextOptions> setupOptions)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (setupOptions == null)
            {
                throw new ArgumentNullException(nameof(setupOptions));
            }
            services.AddOptions();
            services.Configure(setupOptions);
            services.TryAddScoped<DapperContext>();
            return services;
        }


    }
}

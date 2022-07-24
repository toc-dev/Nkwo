using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using Nkwo.Contracts;
using Nkwo.Domain.Context;
using Nkwo.LoggerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkwo.AppCore.Services.Extensions
{
    public static class ServiceExtensions
    {

        public static IServiceCollection ConfigureDataBaseConnection(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<NkwoIdentityDbContext>(options =>
            options.UseSqlServer(
                connectionString, b => b.MigrationsAssembly("Nkwo")));

            services.AddDbContext<NkwoDbContext>(options =>
            options.UseSqlServer(
                connectionString, b => b.MigrationsAssembly("Nkwo"))
            .ConfigureWarnings(c => c.Log(CoreEventId.DetachedLazyLoadingWarning, CoreEventId.LazyLoadOnDisposedContextWarning)));
            return services;
        }
        /// <summary>
        /// IOC Container
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
    }
}

﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using DynamicCv.DataContext.CvDbContext;
using Microsoft.EntityFrameworkCore;

namespace DynamicCv.Services.CvServices
{
    public static class CvEntiresService
    {
        public static IServiceCollection AddEntityServiceConnection(this IServiceCollection services, string connectionString, string migrationAssembly)
        {
            services.AddEntityFrameworkSqlServer()
            .AddDbContext<CvContext>((serviceProvider, options) =>
            options.UseSqlServer(connectionString, b => b.MigrationsAssembly(migrationAssembly))
                   .UseInternalServiceProvider(serviceProvider)
                   );
            return services;
        }
    }
}

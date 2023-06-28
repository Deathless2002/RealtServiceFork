﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RealtService.Application.UnitOfWork;
using RealtService.Persistence.UnitOfWork.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RealtService.Persistence;

public static class ConfigureServices
{
    public static IServiceCollection AddPersistanceServices(this IServiceCollection services, IConfiguration configuration)
    {
        /*services.AddSingleton<RealtServiceDBContext, RealtServiceDBContext>();
        /*var connectionString = configuration["DbConnection"];
        services.AddDbContext<RealtServiceDbContext>(options =>
        {
            //options.UseSqlServer(connectionString);
        });
        services.AddScoped<IOfferDbContext>(provider =>
            provider.GetService<RealtServiceDbContext>());
        return services;*/
        //services.AddSingleton<UnitOfWork, UnitOfWork>();
        services.AddSingleton<OfferRepository, OfferRepository>();
        services.AddSingleton<UserRepository, UserRepository>();
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        return services;
    }
}

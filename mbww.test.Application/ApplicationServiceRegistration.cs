﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;

namespace SalesDatePrediction.test.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}

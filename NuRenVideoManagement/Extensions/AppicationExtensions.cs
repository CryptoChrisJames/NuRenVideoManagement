using System;
using Microsoft.Extensions.DependencyInjection;
using NuRenVideoApplication.Infrastructure.Interfaces;
using NuRenVideoApplication.Services.Factories;

namespace NuRenVideoManagement.Extensions
{
    public static class AppicationExtensions
    {
        public static IServiceCollection AddAppicationExtensions(this IServiceCollection services)
        {
            services.AddTransient<IMongoDbClientFactory, MongoDbClientFactory>();
            return services;
        }
    }
}

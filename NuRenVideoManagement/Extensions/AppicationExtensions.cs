using System;
using Microsoft.Extensions.DependencyInjection;
using NuRenVideoApplication.Infrastructure.Interfaces;
using NuRenVideoApplication.Infrastructure.Repositories.Clients;

namespace NuRenVideoManagement.Extensions
{
    public static class AppicationExtensions
    {
        public static IServiceCollection AddAppicationExtensions(this IServiceCollection services)
        {
            services.AddTransient<IVideoDbClient, VideoDbClient>();
            return services;
        }
    }
}

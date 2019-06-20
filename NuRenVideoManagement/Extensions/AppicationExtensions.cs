using System;
using Microsoft.Extensions.DependencyInjection;
using NuRenVideoApplication.Infrastructure.Interfaces;
using NuRenVideoApplication.Infrastructure.Repositories;
using NuRenVideoApplication.Infrastructure.Repositories.Clients;
using NuRenVideoApplication.Services;

namespace NuRenVideoManagement.Extensions
{
    public static class AppicationExtensions
    {
        public static IServiceCollection AddAppicationExtensions(this IServiceCollection services)
        {
            services.AddTransient<IVideoDbClient, VideoDbClient>();
            services.AddTransient<IVideoUploadEventRepository, VideoUploadEventRepository>();
            services.AddTransient<IVideoUploadEventService, VideoUploadEventService>();
            return services;
        }
    }
}

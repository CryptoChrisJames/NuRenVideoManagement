using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NuRenVideoApplication.Infrastructure.Interfaces;
using NuRenVideoApplication.ValueObjects;

namespace NuRenVideoApplication.Services
{
    public class VideoUploadEventService : IVideoUploadEventService
    {
        public IMongoDbClientFactory mongoClient { get; set; }

        public VideoUploadEventService(IMongoDbClientFactory mongoDbClientFactory)
        {
            // mongoClient = mongoDbClientFactory("mongodb://ObsidianTech:Obsidian12!@ds131737.mlab.com:31737/nurenqa1");
        }

        public Task<IEnumerable<VideoUploadEvent>> GetVideoUploadEvents()
        {
            throw new NotImplementedException();
        }
    }
}

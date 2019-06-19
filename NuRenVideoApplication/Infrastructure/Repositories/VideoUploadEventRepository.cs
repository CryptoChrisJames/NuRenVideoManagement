using System;
using MongoDB.Driver;
using NuRenVideoApplication.Infrastructure.Interfaces;
using NuRenVideoApplication.ValueObjects;

namespace NuRenVideoApplication.Infrastructure.Repositories
{
    public class VideoUploadEventRepository : IVideoUploadEventRepository
    {
        public IMongoCollection<VideoUploadEvent> VideoUploadEventCollection { get; set; }
        public VideoUploadEventRepository(IVideoDbClient client)
        {
            VideoUploadEventCollection = client.MongoDatabase.GetCollection<VideoUploadEvent>("newvideoevents");
        }

    }
}

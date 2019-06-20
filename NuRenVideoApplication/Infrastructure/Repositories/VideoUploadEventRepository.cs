using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        public IEnumerable<VideoUploadEvent> GetVideoUploadEvents() =>
            VideoUploadEventCollection.Find(upload => true).ToList();
    }
}

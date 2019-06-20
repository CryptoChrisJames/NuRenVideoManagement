using MongoDB.Bson;
using MongoDB.Driver;
using NuRenVideoApplication.Infrastructure.Interfaces;
using NuRenVideoApplication.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuRenVideoApplication.Infrastructure.Repositories
{
    public class VideoKeysRepository : IVideoKeysRepository
    {
        public IMongoCollection<VideoS3Key> VideoS3KeysCollection { get; set; }
        public VideoKeysRepository(IVideoDbClient client)
        {
            VideoS3KeysCollection = client.MongoDatabase.GetCollection<VideoS3Key>("nurenvideokeys");
        }
        
        public IEnumerable<VideoS3Key> GetVideoS3Keys() =>
            VideoS3KeysCollection.Find(key => true).ToList();


        public VideoS3Key GetVideoS3Key(string id) => 
            VideoS3KeysCollection.Find(key => key._id == id).FirstOrDefault();

    }
}

using System;
using MongoDB.Driver;
using NuRenVideoApplication.Infrastructure.Interfaces;

namespace NuRenVideoApplication.Infrastructure.Repositories.Clients
{
    public class VideoDbClient : IVideoDbClient
    {
        public MongoClient MongoClient { get; set; }
        public IMongoDatabase MongoDatabase { get; set; }

        public VideoDbClient()
        {
            MongoClient = new MongoClient("mongodb://ObsidianTech:Obsidian12!@ds131737.mlab.com:31737");
            MongoDatabase = MongoClient.GetDatabase("nurenqa1");
        }

    }
}

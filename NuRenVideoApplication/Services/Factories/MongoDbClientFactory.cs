using System;
using MongoDB.Driver;
using NuRenVideoApplication.Infrastructure.Interfaces;

namespace NuRenVideoApplication.Services.Factories
{
    public class MongoDbClientFactory : IMongoDbClientFactory
    {

        public MongoClient mongoClient { get; set; }

        public MongoDbClientFactory(string ConnectionString)
        {
            mongoClient = new MongoClient(ConnectionString);
        } 
    }
}

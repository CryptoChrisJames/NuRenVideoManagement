using System;
using MongoDB.Driver;

namespace NuRenVideoApplication.Infrastructure.Interfaces
{
    public interface IMongoDbClientFactory
    {
        MongoClient mongoClient { get; set; }

    }
}

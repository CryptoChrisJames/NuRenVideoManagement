using System;
using MongoDB.Driver;
namespace NuRenVideoApplication.Infrastructure.Interfaces
{
    public interface IVideoDbClient
    {
        MongoClient MongoClient { get; set; }
        IMongoDatabase MongoDatabase { get; set; }
    }
}

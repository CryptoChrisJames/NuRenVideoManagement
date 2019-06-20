using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using NuRenVideoApplication.ValueObjects;

namespace NuRenVideoApplication.Infrastructure.Interfaces
{
    public interface IVideoKeysRepository
    {
        IMongoCollection<VideoS3Key> VideoS3KeysCollection { get; set; }
        IEnumerable<VideoS3Key> GetVideoS3Keys();
        VideoS3Key GetVideoS3Key(ObjectId _id);
    }
}

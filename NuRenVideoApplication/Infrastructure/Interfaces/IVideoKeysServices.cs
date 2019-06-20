using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using NuRenVideoApplication.ValueObjects;

namespace NuRenVideoApplication.Infrastructure.Interfaces
{
    public interface IVideoKeysService
    {
        IEnumerable<VideoS3Key> GetVideoKeys();
        VideoS3Key GetKey(string id);
    }
}

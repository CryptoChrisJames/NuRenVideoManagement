using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using NuRenVideoApplication.ValueObjects;

namespace NuRenVideoApplication.Infrastructure.Interfaces
{
    public interface IVideoUploadEventRepository
    {
        IMongoCollection<VideoUploadEvent> VideoUploadEventCollection { get; set; }
        IEnumerable<VideoUploadEvent> GetVideoUploadEvents();
    }
}

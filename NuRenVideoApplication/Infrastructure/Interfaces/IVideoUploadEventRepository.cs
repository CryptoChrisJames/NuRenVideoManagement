using System;
using MongoDB.Driver;
using NuRenVideoApplication.ValueObjects;

namespace NuRenVideoApplication.Infrastructure.Interfaces
{
    public interface IVideoUploadEventRepository
    {
        IMongoCollection<VideoUploadEvent> VideoUploadEventCollection { get; set; }
    }
}

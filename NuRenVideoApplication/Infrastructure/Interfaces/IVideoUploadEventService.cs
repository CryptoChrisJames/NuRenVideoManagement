using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NuRenVideoApplication.ValueObjects;

namespace NuRenVideoApplication.Infrastructure.Interfaces
{
    public interface IVideoUploadEventService
    {
        Task<IEnumerable<VideoUploadEvent>> GetVideoUploadEvents();
    }
}

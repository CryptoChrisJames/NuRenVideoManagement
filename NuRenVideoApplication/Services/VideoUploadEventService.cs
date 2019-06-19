using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NuRenVideoApplication.Infrastructure.Interfaces;
using NuRenVideoApplication.ValueObjects;

namespace NuRenVideoApplication.Services
{
    public class VideoUploadEventService : IVideoUploadEventService
    {

        public VideoUploadEventService()
        {
        }

        public Task<IEnumerable<VideoUploadEvent>> GetVideoUploadEvents()
        {
            throw new NotImplementedException();
        }
    }
}

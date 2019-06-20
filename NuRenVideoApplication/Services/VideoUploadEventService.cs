using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NuRenVideoApplication.Infrastructure.Interfaces;
using NuRenVideoApplication.ValueObjects;

namespace NuRenVideoApplication.Services
{
    public class VideoUploadEventService : IVideoUploadEventService
    {
        IVideoUploadEventRepository _repo { get; set; }
        public VideoUploadEventService(IVideoUploadEventRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<VideoUploadEvent> GetVideoUploadEvents() => _repo.GetVideoUploadEvents();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NuRenVideoApplication.Infrastructure.Interfaces;
using NuRenVideoApplication.ValueObjects;

namespace NuRenVideoManagement.Controllers
{
    [Route("v1/api/upload")]
    [ApiController]
    public class VideoUploadController : ControllerBase
    {
        private IVideoUploadEventService _service;
        public VideoUploadController(IVideoUploadEventService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("uploads")]
        public IEnumerable<VideoUploadEvent> GetEvents() =>
            _service.GetVideoUploadEvents();
    }
}

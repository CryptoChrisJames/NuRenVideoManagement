using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using NuRenVideoApplication.Infrastructure.Interfaces;
using NuRenVideoApplication.ValueObjects;

namespace NuRenVideoManagement.Controllers
{
    [Route("v1/api/keys")]
    [ApiController]
    public class VideoKeysController : ControllerBase
    {
        public IVideoKeysService _service;

        public VideoKeysController(IVideoKeysService service)
        {
            _service = service;

        }

        [HttpGet]
        public IEnumerable<VideoS3Key> GetKeys() => _service.GetVideoKeys();

        //[Route("{id}")]
        //[HttpGet]
        //public VideoS3Key GetKeys(ObjectId id) => _service.GetKey(id);
    }
}
using MongoDB.Bson;
using NuRenVideoApplication.Infrastructure.Interfaces;
using NuRenVideoApplication.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuRenVideoApplication.Services
{
    public class VideoKeysService : IVideoKeysService
    {
        public IVideoKeysRepository _repo { get; set; }

        public VideoKeysService(IVideoKeysRepository repo)
        {
            _repo = repo;
        }

        public VideoS3Key GetKey(ObjectId id) => _repo.GetVideoS3Key(id);

        public IEnumerable<VideoS3Key> GetVideoKeys() => _repo.GetVideoS3Keys();
    }
}

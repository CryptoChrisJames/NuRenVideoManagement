using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using MongoDB.Bson;


namespace NuRenVideoApplication.ValueObjects
{
    public class VideoUploadEvent
    {
        public ObjectId _id { get; set; }
        public DateTime eventTime { get; set; }
        public string bucket { get; set; }
        public string video { get; set; }
    }
}

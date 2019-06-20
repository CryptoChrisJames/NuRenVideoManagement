using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuRenVideoApplication.ValueObjects
{
    public class VideoS3Key
    {
        public ObjectId _id { get; set; }
        public string key { get; set; }
    }
}

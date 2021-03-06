﻿using MongoDB.Bson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNTT.Models
{
    public class Chapters
    {
        public ObjectId _id { get; set; }
        
        [JsonProperty("Chapter")]
        public List<Chapter> Chapter { get; set; }

    }
    public class Chapter
    {

        [JsonProperty("ID")]
        public string ID { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Detail")]
        public List<string> Detail { get; set; }
    }
}

using MongoDB.Bson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNTT.Models
{
    public class SelfStudies
    {
        public ObjectId _id { get; set; }

        [JsonProperty("SelfStudy")]
        public List<SelfStudy> SelfStudy { get; set; }

    }
    public class SelfStudy
    {
        [JsonProperty("ID")]
        public string ID { get; set; }

        [JsonProperty("Details")]
        public List<Detail> Details { get; set; }

        [JsonProperty("Request")]
        public List<string> Request { get; set; }
    }
    public class Details
    {
        [JsonProperty("Read")]
        public string Read { get; set; }

        [JsonProperty("Chapter")]
        public List<string> Chapter { get; set; }

        
    }
}

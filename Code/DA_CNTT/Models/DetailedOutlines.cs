using MongoDB.Bson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNTT.Models
{
    public class DetailedOutlines
    {
        public ObjectId _id { get; set; }

        [JsonProperty("Description")]
        public List<string> Description { get; set; }

        [JsonProperty("Student_Duties")]
        public List<string> Student_Duties { get; set; }

        [JsonProperty("Learning_Materials")]
        public List<string> Learning_Materials { get; set; }

        [JsonProperty("Scientific_Ethics")]
        public List<string> Scientific_Ethics { get; set; }


    }
   
}

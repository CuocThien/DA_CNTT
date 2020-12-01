using MongoDB.Bson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNTT.Models
{
    public class Exams
    {
        public ObjectId _id { get; set; }

        [JsonProperty("Exam")]
        public List<Exam> Exam { get; set; }
    }
    public class Exam 
    {
        [JsonProperty("ID_Test")]
        public string ID_Test { get; set; }

        [JsonProperty("Exercise")]
        public string Exercise { get; set; }

        [JsonProperty("Date")]
        public string Date { get; set; }

        [JsonProperty("Tool")]
        public string Tool { get; set; }

        [JsonProperty("ID_CDR")]
        public List<string> ID_CDR { get; set; }

        [JsonProperty("Percentage")]
        public string Percentage { get; set; }
    }
}

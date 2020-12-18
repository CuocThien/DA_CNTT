using MongoDB.Bson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNTT.Models
{
    public class Subjects
    {
        public ObjectId _id { get; set; }

        [JsonProperty("Course_Code")]
        public string Course_Code { get; set; }

        [JsonProperty("Course_Name")]
        public string Course_Name { get; set; }

        [JsonProperty("Credits")]
        public string Credits { get; set; }

        [JsonProperty("Prerequisite")]
        public List<string> Prerequisite { get; set; }

        [JsonProperty("Chapter_ID")]
        public string Chapter_ID { get; set; }

        [JsonProperty("Goal_ID")]
        public string Goal_ID { get; set; }

        [JsonProperty("DetailOutline_ID")]
        public string DetailOutline_ID { get; set; }

        [JsonProperty("Exam_ID")]
        public string Exam_ID { get; set; }

        [JsonProperty("PPGD_ID")]
        public string PPGD_ID { get; set; }

        [JsonProperty("ProgramOutStandar_ID")]
        public string ProgramOutStandar_ID { get; set; }

        [JsonProperty("SelfStudy_ID")]
        public string SelfStudy_ID { get; set; }
        [JsonProperty("Semester")]
        public string Semester { get; set; }
    }
}

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

        [JsonProperty("Goal")]
        public List<string> Goal { get; set; }

        [JsonProperty("Test")]
        public List<Test> Test { get; set; }

        [JsonProperty("Detail")]
        public List<Detail> Detail { get; set; }

        [JsonProperty("Student_Duties")]
        public List<string> Student_Duties { get; set; }

        [JsonProperty("Learning_Materials")]
        public List<string> Learning_Materials { get; set; }

        [JsonProperty("Scientific_Ethics")]
        public List<string> Scientific_Ethics { get; set; }


    }
    public class Test
    {
        [JsonProperty("Formative_Assessment")]
        public string Formative_Assessment { get; set; }

        [JsonProperty("Final")]
        public string Final { get; set; }

        [JsonProperty("Grading_Scale")]
        public string Grading_Scale { get; set; }

        [JsonProperty("BT")]
        public List<string> BT { get; set; }

        [JsonProperty("Final_Exam")]
        public string Final_Exam { get; set; }
    }
    public class Content
    {
        [JsonProperty("AtClass")]
        public List<string> AtClass { get; set; }

        [JsonProperty("AtHome")]
        public string AtHome { get; set; }
    }
    public class Detail
    {
        [JsonProperty("Week")]
        public string Week { get; set; }

        [JsonProperty("Content")]
        public Content Content { get; set; }

        [JsonProperty("CDR")]
        public List<string> CDR { get; set; }
    }

   
}

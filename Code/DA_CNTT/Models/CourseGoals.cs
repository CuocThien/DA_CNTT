using MongoDB.Bson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNTT.Models
{
    public class CourseGoals
    {
        public ObjectId id { get; set; }

        [JsonProperty("Course_Goal")]
        public List<CourseGoal> CourseGoal { get; set; }

    }
    public class CourseGoal
    {
        [JsonProperty("ID_Goal")]
        public string ID_Goal { get; set; }

        [JsonProperty("Description_Goal")]
        public string Description_Goal { get; set; }

        [JsonProperty("ID_CTDT")]
        public List<string> ID_CTDT { get; set; }

        [JsonProperty("ID_CDR")]
        public List<string> ID_CDR { get; set; }
    }
}

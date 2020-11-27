using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNTT.Models
{
    public class CourseObjective
    {
        public ObjectId id { get; set; }
        public string ID_Goal { get; set; }
        public string Description_Goal { get; set; }
        public string[] ID_CTDT { get; set; }
        public string[] ID_CDR { get; set; }
    }
}

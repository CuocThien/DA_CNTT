using MongoDB.Bson;
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
        public string ID { get; set; }
        public string Name { get; set; }
        public string[] Detail { get; set; }
    }
}

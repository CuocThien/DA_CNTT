using MongoDB.Bson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNTT.Models
{
    public class ProgramOutStandards
    {
        public ObjectId _id { get; set; }

        [JsonProperty("OutComes")]
        public List<OutCome> OutComes { get; set; }
    }
    public class OutCome
    {
        [JsonProperty("ID_CDR")]
        public string ID_CDR { get; set; }

        [JsonProperty("Description_CDR")]
        public string Description_CDR { get; set; }

        [JsonProperty("ID_CDIO")]
        public List<string> ID_CDIO { get; set; }
    }
}

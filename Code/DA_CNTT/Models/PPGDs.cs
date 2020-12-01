using MongoDB.Bson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNTT.Models
{
    public class PPGDs
    {
        public ObjectId _id { get; set; }

        [JsonProperty("PPGD")]
        public List<PPGD> PPGD { get; set; }
    }
    public class PPGD
    {
        [JsonProperty("ID")]
        public string ID { get; set; }

        [JsonProperty("Detail")]
        public List<string> Detail { get; set; }
    }
}

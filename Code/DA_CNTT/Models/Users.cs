using MongoDB.Bson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNTT.Models
{
    public class Users
    {
        public ObjectId _id { get; set; }

        [JsonProperty("Username")]
        public string Username { get; set; }

        [JsonProperty("Password")]
        public string Password { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("isAdmin")]
        public string isAdmin { get; set; }
        
    }
}

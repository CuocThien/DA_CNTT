using DA_CNTT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNTT.Class
{
    public class CUsers
    {
        private CMongoCRUD mongo;
        public CUsers()
        {
            mongo = new CMongoCRUD("QLCTDT");
        }
        public List<Users> findAll()
        {
            var result = this.mongo.Read<Users>("Users");
            return result;
        }
    }
}

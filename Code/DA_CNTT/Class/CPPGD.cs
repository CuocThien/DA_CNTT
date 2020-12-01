using DA_CNTT.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNTT.Class
{
    public class CPPGD
    {
        private CMongoCRUD mongo;
        public CPPGD()
        {
            mongo = new CMongoCRUD("QLCTDT");
        }
        public List<PPGDs> findAll()
        {
            var result = this.mongo.Read<PPGDs>("PPGD");
            return result;
        }
        //truyền ob_ID từ controllers
        public void delete()
        {
            var id = new ObjectId("5fbe2cdf87949980dedc7d40");
            this.mongo.DeleteByObjectId<PPGDs>("PPGD", id);
        }
        //Truyền record từ controllers
        public void Update()
        {
            var id = new ObjectId("5fbe2cdf87949980dedc7d40");
            string ID = "PPGD!!";
            var a = this.mongo.ReadByObjectId<PPGDs>("PPGD", id);
           // a.ID = ID;
            this.mongo.Update<PPGDs>("PPGD", id, a);
        }
    }
}

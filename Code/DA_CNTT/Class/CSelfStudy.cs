using DA_CNTT.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNTT.Class
{
    public class CSelfStudy
    {
        private CMongoCRUD mongo;
        public CSelfStudy()
        {
            mongo = new CMongoCRUD("QLCTDT");
        }
        public List<SelfStudies> findAll()
        {
            var result = this.mongo.Read<SelfStudies>("SelfStudy");
            return result;
        }
        //truyền ob_ID từ controllers
        public void delete()
        {
            var id = new ObjectId("");
            this.mongo.DeleteByObjectId<SelfStudies>("SelfStudy", id);
        }
        //Truyền record từ controllers
        public void Update()
        {
            var id = new ObjectId("5fbe2cdf87949980dedc7d40");
            string ID = "PPGD!!";
            var a = this.mongo.ReadByObjectId<SelfStudies>("SelfStudy", id);
          //  a.ID = ID;
            this.mongo.Update<SelfStudies>("SelfStudy", id, a);
        }
    }
}

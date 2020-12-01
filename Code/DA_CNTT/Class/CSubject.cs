using DA_CNTT.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNTT.Class
{
    public class CSubject
    {
        private CMongoCRUD mongo;
        public CSubject()
        {
            mongo = new CMongoCRUD("QLCTDT");
        }
        public List<Subjects> findAll()
        {
            var result = this.mongo.Read<Subjects>("Subject");
            return result;
        }
        //truyền ob_ID từ controllers
        public void delete()
        {
            var id = new ObjectId("5fbddaf687949980dedc7178");
            this.mongo.DeleteByObjectId<Subjects>("Subject", id);
        }
        //Truyền record từ controllers
        public void Update()
        {
            var id = new ObjectId("5fbde3f287949980dedc724b");
            string Credits = "8";
            var a = this.mongo.ReadByObjectId<Subjects>("Subject", id);
            a.Credits = Credits;
            this.mongo.Update<Subjects>("Subject", id, a);
        }
    }
}

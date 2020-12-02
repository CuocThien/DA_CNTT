using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_CNTT.Models;
using MongoDB.Bson;

namespace DA_CNTT.Class
{
    public class CDetailedOutline
    {
        private CMongoCRUD mongo;
        public CDetailedOutline()
        {
            mongo = new CMongoCRUD("QLCTDT");
        }
        public List<DetailedOutlines> findAll()
        {
            var result = this.mongo.Read<DetailedOutlines>("DetailedOutline");
            return result;
        }
        //truyền ob_ID từ controllers
        public void delete()
        {
            var id = new ObjectId("5fbe04bc87949980dedc76dd");
            this.mongo.DeleteByObjectId<DetailedOutlines>("DetailedOutline", id);
        }
        //Truyền record từ controllers
        public void Update()
        {
            var id = new ObjectId("5fbe04bc87949980dedc76dd");
            string ID = "WEPR440479";
            var a = this.mongo.ReadByObjectId<DetailedOutlines>("DetailedOutline", id);
            //a.Course_Code = ID;
            this.mongo.Update<DetailedOutlines>("DetailedOutline", id, a);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_CNTT.Models;
using MongoDB.Bson;

namespace DA_CNTT.Class
{
    public class CChapters
    {
        private CMongoCRUD mongo;
        public CChapters()
        {
            mongo = new CMongoCRUD("QLCTDT");
        }
        public List<Chapters> findAll()
        {
            var result = this.mongo.Read<Chapters>("Chapters");
            return result;
        }
        //truyền ob_ID từ controllers
        public void Delete()
        {
            var id = new ObjectId("5fbe11cf87949980dedc7b21");
            this.mongo.DeleteByObjectId<Chapters>("Chapters", id);
        }
        //Truyền record từ controllers
        public void Update()
        {
            var id = new ObjectId("5fbe11e787949980dedc7b28");
            string ID = "Chương 2 2";
            var a = this.mongo.ReadByObjectId<Chapters>("Chapters", id);
            a.ID = ID;
            this.mongo.Update<Chapters>("Chapters", id,a);
        }
        //
    }
}

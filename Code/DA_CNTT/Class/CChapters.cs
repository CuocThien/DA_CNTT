using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_CNTT.Models;
using MongoDB.Bson;
using MongoDB.Driver;

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
        public Chapters findfromsubject(ObjectId id)
        {
            var result = this.mongo.ReadByObjectId<Chapters>("Chapters", id);
            return result;
        }
        //truyền ob_ID từ controllers
        public void Delete()
        {
            var id = new ObjectId("5fc509436184428b8096c1d5");
            var ID = "Chương 1";
            var x = this.mongo.ReadByObjectId<Chapters>("Chapters", id);
            var y = x.Chapter.Where(c => c.ID == ID).SingleOrDefault();
            
            x.Chapter.Remove(y);
            this.mongo.Update<Chapters>("Chapters", id, x);
        }
        
        //Truyền record từ controllers
        public void Update()
        {
            var id = new ObjectId("5fc509436184428b8096c1d5");
            var Id = "Chương 2";
            string ID = "Chương 2 2";
            var a = this.mongo.ReadByObjectId<Chapters>("Chapters", id);
            var b = a.Chapter.Where(c => c.ID == Id).SingleOrDefault();
            a.Chapter.Remove(b);
            b.ID = ID;
            a.Chapter.Add(b);
            this.mongo.Update<Chapters>("Chapters", id, a);
        }
        //
    }
}

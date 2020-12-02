using DA_CNTT.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNTT.Class
{
    public class CExam
    {
        private CMongoCRUD mongo;
        public CExam()
        {
            mongo = new CMongoCRUD("QLCTDT");
        }
        public List<Exams> findAll()
        {
            var result = this.mongo.Read<Exams>("Exam");
            return result;
        }
        //truyền ob_ID từ controllers
        public void delete()
        {
            var id = new ObjectId("5fbbd7fc889853cc7e570d3d");
            this.mongo.DeleteByObjectId<Exams>("Exam", id);
        }
        //Truyền record từ controllers
        public void Update()
        {
            var id = new ObjectId("5fbbd7fc889853cc7e570d3d");
            string Date = "Tuần 22";
            var a = this.mongo.ReadByObjectId<Exams>("Exam", id);
            //a.Date = Date;
            this.mongo.Update<Exams>("Exam", id, a);
        }
    }
}

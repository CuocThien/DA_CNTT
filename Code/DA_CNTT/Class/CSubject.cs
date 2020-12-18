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
        private CSubject cSub;

        public CSubject()
        {
            mongo = new CMongoCRUD("QLCTDT");
        }
        public List<Subjects> findAll()
        {
            var result = this.mongo.Read<Subjects>("Subjects");
            return result;
        }
        public void addSubject(Subjects subjects)
        {
            var obId = ObjectId.GenerateNewId();
            subjects._id = obId;
            this.mongo.InsertRecord<Subjects>("Subjects", subjects);

        }
        //truyền ob_ID từ controllers
        public void delete(string id)
        {
            CSubject cSubject = new CSubject();
            var sub = cSubject.findAll().Where(i => i.Course_Code == id).SingleOrDefault();
            this.mongo.DeleteByObjectId<Subjects>("Subjects", sub._id);
        }
        //Truyền record từ controllers
        public void Update(string subId,Subjects subjects)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", new ObjectId(subs.Where(s => s.Course_Code == subId).SingleOrDefault()._id.ToString()));
            sub.Prerequisite = subjects.Prerequisite;
            sub.Course_Name = subjects.Course_Name;
            sub.Credits = subjects.Credits;
            sub.Course_Code = subjects.Course_Code;
            sub.Semester = subjects.Semester;
            this.mongo.Update<Subjects>("Subjects", sub._id, sub);
        }
    }
}

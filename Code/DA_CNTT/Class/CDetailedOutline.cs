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
        private CSubject cSub;

        public CDetailedOutline()
        {
            mongo = new CMongoCRUD("QLCTDT");
        }
        public List<DetailedOutlines> findAll()
        {
            var result = this.mongo.Read<DetailedOutlines>("DetailedOutline");
            return result;
        }
        public DetailedOutlines findfromsubject(string id)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub_id = subs.Where(s => s.Course_Code.Equals(id)).SingleOrDefault();
            if (sub_id.DetailOutline_ID.ToString() != "")
            {
                var SS_id = new ObjectId(sub_id.DetailOutline_ID.ToString());
                var result = this.mongo.ReadByObjectId<DetailedOutlines>("DetailedOutlines", SS_id);
                return result;
            }
            else return null;
        }
        public void addDetailedOutline(string id, DetailedOutlines detailedOutlines)
        {
            var obId = ObjectId.GenerateNewId();
            CDetailedOutline cDetailedOutline = new CDetailedOutline();
            var DOExist = cDetailedOutline.findfromsubject(id);
            if (!(DOExist is null))
            {
                DOExist.Description = detailedOutlines.Description;
                DOExist.Learning_Materials = detailedOutlines.Learning_Materials;
                DOExist.Scientific_Ethics = detailedOutlines.Scientific_Ethics;
                DOExist.Student_Duties = detailedOutlines.Student_Duties;
                this.mongo.Update<DetailedOutlines>("DetailedOutlines", DOExist._id, DOExist);
            }
            else
            {
                var DOsNew = new DetailedOutlines();
                DOsNew._id = obId;
                this.mongo.InsertRecord<DetailedOutlines>("DetailedOutlines", DOsNew);
                var DOs = this.mongo.ReadByObjectId<DetailedOutlines>("DetailedOutlines", obId);
                DOs.Description = detailedOutlines.Description;
                DOs.Learning_Materials = detailedOutlines.Learning_Materials;
                DOs.Scientific_Ethics = detailedOutlines.Scientific_Ethics;
                DOs.Student_Duties = detailedOutlines.Student_Duties;
                this.mongo.Update<DetailedOutlines>("DetailedOutlines", obId, DOs);
                cSub = new CSubject();
                var subs = cSub.findAll();
                var subID = new ObjectId(subs.Where(s => s.Course_Code == id).SingleOrDefault()._id.ToString());
                var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", subID);
                sub.DetailOutline_ID = obId.ToString();
                this.mongo.Update<Subjects>("Subjects", subID, sub);
            }
        }
        //truyền ob_ID từ controllers
        public void Delete(string subid)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", new ObjectId(subs.Where(s => s.Course_Code == subid).SingleOrDefault()._id.ToString()));
            var ObId_do = new ObjectId(sub.DetailOutline_ID.ToString());
            var DO = this.mongo.ReadByObjectId<DetailedOutlines>("DetailedOutlines", ObId_do);
            DO.Description.Clear();
            DO.Learning_Materials.Clear();
            DO.Scientific_Ethics.Clear();
            DO.Student_Duties.Clear();
            this.mongo.Update<DetailedOutlines>("DetailedOutlines", ObId_do, DO);
        }
        //Truyền record từ controllers
        public void Update(string subid, DetailedOutlines detailedOutlines)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", new ObjectId(subs.Where(s => s.Course_Code == subid).SingleOrDefault()._id.ToString()));
            var ObId_DO = new ObjectId(sub.DetailOutline_ID.ToString());
            var DOExist = this.mongo.ReadByObjectId<DetailedOutlines>("DetailedOutlines", ObId_DO);
            DOExist.Description = detailedOutlines.Description;
            DOExist.Learning_Materials = detailedOutlines.Learning_Materials;
            DOExist.Scientific_Ethics = detailedOutlines.Scientific_Ethics;
            DOExist.Student_Duties = detailedOutlines.Student_Duties;
            this.mongo.Update<DetailedOutlines>("DetailedOutlines", ObId_DO, DOExist);
        }
    }
}

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
        private CSubject cSub;

        public CSelfStudy()
        {
            mongo = new CMongoCRUD("QLCTDT");
        }
        public List<SelfStudies> findAll()
        {
            var result = this.mongo.Read<SelfStudies>("SelfStudy");
            return result;
        }
        public SelfStudies findfromsubject(string id)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub_id = subs.Where(s => s.Course_Code.Equals(id)).SingleOrDefault();
            if (sub_id.SelfStudy_ID.ToString() != "")
            {
                var SS_id = new ObjectId(sub_id.SelfStudy_ID.ToString());
                var result = this.mongo.ReadByObjectId<SelfStudies>("SelfStudies", SS_id);
                return result;
            }
            else return null;
        }
        public void addSelfStudy(string id, SelfStudy selfStudy)
        {
            var obId = ObjectId.GenerateNewId();
            CSelfStudy cSelfStudy = new CSelfStudy();
            var SSExist = cSelfStudy.findfromsubject(id);
            if (!(SSExist is null))
            {
                SSExist.SelfStudy.Add(selfStudy);
                this.mongo.Update<SelfStudies>("SelfStudies", SSExist._id, SSExist);
            }
            else
            {
                var SSsNew = new SelfStudies();
                SSsNew._id = obId;
                this.mongo.InsertRecord<SelfStudies>("SelfStudies", SSsNew);
                var SSs = this.mongo.ReadByObjectId<SelfStudies>("SelfStudies", obId);
                var result = new List<SelfStudy>();
                result.Add(selfStudy);
                SSsNew.SelfStudy = result;
                this.mongo.Update<SelfStudies>("SelfStudies", obId, SSsNew);
                cSub = new CSubject();
                var subs = cSub.findAll();
                var subID = new ObjectId(subs.Where(s => s.Course_Code == id).SingleOrDefault()._id.ToString());
                var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", subID);
                sub.SelfStudy_ID = obId.ToString();
                this.mongo.Update<Subjects>("Subjects", subID, sub);
            }
        }
        //truyền ob_ID từ controllers
        public void Delete(string subid, string selfstudyId)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", new ObjectId(subs.Where(s => s.Course_Code == subid).SingleOrDefault()._id.ToString()));
            var ObId_ss = new ObjectId(sub.SelfStudy_ID.ToString());
            var ss = this.mongo.ReadByObjectId<SelfStudies>("SelfStudies", ObId_ss);
            var ssDel = ss.SelfStudy.Where(c => c.ID == selfstudyId).SingleOrDefault();

            ss.SelfStudy.Remove(ssDel);
            this.mongo.Update<SelfStudies>("SelfStudies", ObId_ss, ss);
        }
        //Truyền record từ controllers
        public void Update(string subid, string SSId, SelfStudy selfStudy)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", new ObjectId(subs.Where(s => s.Course_Code == subid).SingleOrDefault()._id.ToString()));
            var ObId_SS = new ObjectId(sub.SelfStudy_ID.ToString());
            var SSExist = this.mongo.ReadByObjectId<SelfStudies>("SelfStudies", ObId_SS);
            SSExist.SelfStudy.Where(c => c.ID == SSId).SingleOrDefault().Details = selfStudy.Details;
            SSExist.SelfStudy.Where(c => c.ID == SSId).SingleOrDefault().Request = selfStudy.Request;
            SSExist.SelfStudy.Where(c => c.ID == SSId).SingleOrDefault().ID = selfStudy.ID;
            this.mongo.Update<SelfStudies>("SelfStudies", ObId_SS, SSExist);
        }
    }
}

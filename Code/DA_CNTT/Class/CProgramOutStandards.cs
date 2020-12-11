using DA_CNTT.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNTT.Class
{
    class CProgramOutStandards
    {
        private CMongoCRUD mongo;
        private CSubject cSub;

        public CProgramOutStandards()
        {
            mongo = new CMongoCRUD("QLCTDT");
        }
        public List<ProgramOutStandards> findAll()
        {
            var result = this.mongo.Read<ProgramOutStandards>("ProgramOutStandards");
            return result;
        }
        public ProgramOutStandards findfromsubject(string id)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub_id = subs.Where(s => s.Course_Code.Equals(id)).SingleOrDefault();
            if (sub_id.ProgramOutStandar_ID.ToString() != "")
            {
                var POS_id = new ObjectId(sub_id.ProgramOutStandar_ID.ToString());
                var result = this.mongo.ReadByObjectId<ProgramOutStandards>("ProgramOutStandards", POS_id);
                return result;
            }
            else return null;
        }
        public void addExam(string id, OutCome outcome)
        {
            var obId = ObjectId.GenerateNewId();
            CProgramOutStandards cStandard = new CProgramOutStandards();
            var POSExist = cStandard.findfromsubject(id);
            if (!(POSExist is null))
            {
                POSExist.OutComes.Add(outcome);
                this.mongo.Update<ProgramOutStandards>("ProgramOutStandards", POSExist._id, POSExist);
            }
            else
            {
                var POSsNew = new ProgramOutStandards();
                POSsNew._id = obId;
                this.mongo.InsertRecord<ProgramOutStandards>("ProgramOutStandards", POSsNew);
                var POSs = this.mongo.ReadByObjectId<ProgramOutStandards>("ProgramOutStandards", obId);
                var result = new List<OutCome>();
                result.Add(outcome);
                POSsNew.OutComes = result;
                this.mongo.Update<ProgramOutStandards>("ProgramOutStandards", obId, POSsNew);
                cSub = new CSubject();
                var subs = cSub.findAll();
                var subID = new ObjectId(subs.Where(s => s.Course_Code == id).SingleOrDefault()._id.ToString());
                var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", subID);
                sub.ProgramOutStandar_ID = obId.ToString();
                this.mongo.Update<Subjects>("Subjects", subID, sub);
            }
        }
        public void Delete(string subid, string POSId)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", new ObjectId(subs.Where(s => s.Course_Code == subid).SingleOrDefault()._id.ToString()));
            var ObId_POS = new ObjectId(sub.ProgramOutStandar_ID.ToString());
            var POS = this.mongo.ReadByObjectId<ProgramOutStandards>("ProgramOutStandards", ObId_POS);
            var POSDel = POS.OutComes.Where(c => c.ID_CDR == POSId).SingleOrDefault();

            POS.OutComes.Remove(POSDel);
            this.mongo.Update<ProgramOutStandards>("ProgramOutStandards", ObId_POS, POS);
        }
        public void Update(string subid, string POSId, OutCome outcome)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", new ObjectId(subs.Where(s => s.Course_Code == subid).SingleOrDefault()._id.ToString()));
            var ObId_pos = new ObjectId(sub.ProgramOutStandar_ID.ToString());
            var posExist = this.mongo.ReadByObjectId<ProgramOutStandards>("ProgramOutStandards", ObId_pos);
            posExist.OutComes.Where(c => c.ID_CDR == POSId).SingleOrDefault().Description_CDR = outcome.Description_CDR;
            posExist.OutComes.Where(c => c.ID_CDR == POSId).SingleOrDefault().ID_CDIO = outcome.ID_CDIO;
            posExist.OutComes.Where(c => c.ID_CDR == POSId).SingleOrDefault().ID_CDR = outcome.ID_CDR;
            this.mongo.Update<ProgramOutStandards>("ProgramOutStandards", ObId_pos, posExist);
        }
    }
}

﻿using DA_CNTT.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNTT.Class
{
    public class CPPGD
    {
        private CMongoCRUD mongo;
        private CSubject cSub;

        public CPPGD()
        {
            mongo = new CMongoCRUD("QLCTDT");
        }
        public List<PPGDs> findAll()
        {
            var result = this.mongo.Read<PPGDs>("PPGD");
            return result;
        }
        public PPGDs findfromsubject(string id)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub_id = subs.Where(s => s.Course_Code.Equals(id)).SingleOrDefault();
            if (sub_id.PPGD_ID.ToString() != "")
            {
                var ppgd_id = new ObjectId(sub_id.PPGD_ID.ToString());
                var result = this.mongo.ReadByObjectId<PPGDs>("PPGDs", ppgd_id);
                return result;
            }
            else return null;
        }
        public void addPPGD(string id, PPGD ppgd)
        {
            var obId = ObjectId.GenerateNewId();
            CPPGD cPPGD = new CPPGD();
            var PPGDExist = cPPGD.findfromsubject(id);
            if (!(PPGDExist is null))
            {
                PPGDExist.PPGD.Add(ppgd);
                this.mongo.Update<PPGDs>("PPGDs", PPGDExist._id, PPGDExist);
            }
            else
            {
                var PPGDsnew = new PPGDs();
                PPGDsnew._id = obId;
                this.mongo.InsertRecord<PPGDs>("PPGDs", PPGDsnew);
                var PPGDnew = this.mongo.ReadByObjectId<PPGDs>("PPGDs", obId);
                var result = new List<PPGD>();
                result.Add(ppgd);
                PPGDsnew.PPGD = result;
                this.mongo.Update<PPGDs>("PPGDs", obId, PPGDsnew);
                cSub = new CSubject();
                var subs = cSub.findAll();
                var subID = new ObjectId(subs.Where(s => s.Course_Code == id).SingleOrDefault()._id.ToString());
                var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", subID);
                sub.PPGD_ID = obId.ToString();
                this.mongo.Update<Subjects>("Subjects", subID, sub);
            }
        }
        public void delete(string subid, string ppgdId)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", new ObjectId(subs.Where(s => s.Course_Code == subid).SingleOrDefault()._id.ToString()));
            var ObId_ppgd = new ObjectId(sub.PPGD_ID.ToString());
            var ppgd = this.mongo.ReadByObjectId<PPGDs>("PPGDs", ObId_ppgd);
            var ppgdDel = ppgd.PPGD.Where(c => c.ID == ppgdId).SingleOrDefault();

            ppgd.PPGD.Remove(ppgdDel);
            this.mongo.Update<PPGDs>("PPGDs", ObId_ppgd, ppgd);
        }
        public void Update(string subid, string ppgdId, PPGD ppgd)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", new ObjectId(subs.Where(s => s.Course_Code == subid).SingleOrDefault()._id.ToString()));
            var ObId_ppgd = new ObjectId(sub.PPGD_ID.ToString());
            var ppgdExist = this.mongo.ReadByObjectId<PPGDs>("PPGDs", ObId_ppgd);
            ppgdExist.PPGD.Where(c => c.ID == ppgdId).SingleOrDefault().Detail = ppgd.Detail;
            ppgdExist.PPGD.Where(c => c.ID == ppgdId).SingleOrDefault().ID = ppgd.ID;
            this.mongo.Update<PPGDs>("PPGDs", ObId_ppgd, ppgdExist);
        }
    }
}

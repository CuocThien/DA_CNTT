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
        private CSubject cSub;
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
        public Chapters findfromsubject(string id)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub_id = subs.Where(s => s.Course_Code.Equals(id)).SingleOrDefault();
            //var x = sub_id.Chapter_ID.ToString();
            if (sub_id.Chapter_ID.ToString() != "")
            {     
                var chapter_id = new ObjectId(sub_id.Chapter_ID.ToString());
                var result = this.mongo.ReadByObjectId<Chapters>("Chapters", chapter_id);
                return result;
            }
            else return null;
        }
        public void addChapter(string id, string ChapterID, string ChapterName, List<string> Detail)
        {
            var obId = ObjectId.GenerateNewId();
            CChapters cChapters = new CChapters();
            var chapterExist = cChapters.findfromsubject(id);
            if (!(chapterExist is null))
            {
                var chapterNew = new Chapter();
                chapterNew.ID = ChapterID;
                chapterNew.Name = ChapterName;
                chapterNew.Detail = Detail;
                chapterExist.Chapter.Add(chapterNew);
                this.mongo.Update<Chapters>("Chapters", chapterExist._id, chapterExist);
            }
            else
            {
                var x = new Chapters();
                x._id = obId;
                this.mongo.InsertRecord<Chapters>("Chapters", x);
                var chap = this.mongo.ReadByObjectId<Chapters>("Chapters", obId);
                var result = new List<Chapter>();
                var chapterNew = new Chapter();
                chapterNew.ID = ChapterID;
                chapterNew.Name = ChapterName;
                chapterNew.Detail = Detail;
                result.Add(chapterNew);
                chap.Chapter = result;
                this.mongo.Update<Chapters>("Chapters",obId, chap);
                cSub = new CSubject();
                var subs = cSub.findAll();
                var subID = new ObjectId(subs.Where(s => s.Course_Code == id).SingleOrDefault()._id.ToString());
                var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", subID);
                sub.Chapter_ID = obId.ToString();
                this.mongo.Update<Subjects>("Subjects", subID, sub);
            }
        }
        //truyền ob_ID từ controllers
        public void Delete(string subid, string chapterId)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", new ObjectId(subs.Where(s => s.Course_Code == subid).SingleOrDefault()._id.ToString()));
            var ObId_chap = new ObjectId(sub.Chapter_ID.ToString());
            var chapter = this.mongo.ReadByObjectId<Chapters>("Chapters", ObId_chap);
            var chapterDel = chapter.Chapter.Where(c => c.ID == chapterId).SingleOrDefault();
            
            chapter.Chapter.Remove(chapterDel);
            this.mongo.Update<Chapters>("Chapters", ObId_chap, chapter);
        }
        
        //Truyền record từ controllers
        public void Update(string subid,string chapterId,Chapter chapter)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", new ObjectId(subs.Where(s=>s.Course_Code==subid).SingleOrDefault()._id.ToString()));
            var ObId_chap = new ObjectId(sub.Chapter_ID.ToString());
            var chapterExist = this.mongo.ReadByObjectId<Chapters>("Chapters", ObId_chap);
            chapterExist.Chapter.Where(c => c.ID == chapterId).SingleOrDefault().Name = chapter.Name;
            chapterExist.Chapter.Where(c => c.ID == chapterId).SingleOrDefault().Detail = chapter.Detail;
            chapterExist.Chapter.Where(c => c.ID == chapterId).SingleOrDefault().ID=chapter.ID;
            this.mongo.Update<Chapters>("Chapters", ObId_chap, chapterExist);
        }
        //
    }
}

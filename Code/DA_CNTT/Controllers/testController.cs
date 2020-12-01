using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_CNTT.Class;
using MongoDB.Bson;

namespace DA_CNTT.Controllers
{
    public class testController
    {
        private CChapters chapter;
        private CDetailedOutline detail;
        private CCourseGoals course;
        private CSubject subject;
        private CExam exam;
        private CPPGD ppgd;
        private CSelfStudy selfstudy;

        public testController()
        {
            this.chapter = new CChapters();
            this.detail = new CDetailedOutline();
            this.course = new CCourseGoals();
            this.subject = new CSubject();
            this.exam = new CExam();
            this.ppgd = new CPPGD();
            this.selfstudy = new CSelfStudy();
        }
        public void chap()
        {
            var id = new ObjectId("5fc509436184428b8096c1d5");

            //this.chapter.findfromsubject(id);
            this.chapter.Update();
            //this.detail.Update();
            //this.course.findAll();
            //this.subject.findAll();
            //this.subject.Update();
            //this.exam.findAll();
            //this.exam.delete();
            //this.ppgd.delete();
            //this.selfstudy.findAll();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_CNTT.Class;
using DA_CNTT.Models;
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
            var id_CourseGoal = new ObjectId("5fc509cf6184428b8096c206");
            this.subject.findAll();
            //this.course.findFromSubject(id_CourseGoal);
            //this.detail.Update();
            //this.course.findAll();
            //this.subject.findAll();
            //this.subject.Update();
            //this.exam.findAll();
            //this.exam.delete();
            //this.ppgd.delete();
            //this.selfstudy.findAll();
        }
        public List<Subjects> loadsubjects()
        {
            var result = this.subject.findAll();
            return result;
        }
        public Chapters loadchapters(string id)
        {
            var result = this.chapter.findfromsubject(id);
            return result;
        }
    }
}

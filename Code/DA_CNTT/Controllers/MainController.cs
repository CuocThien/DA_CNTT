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
    public class MainController
    {
        private CChapters chapter;
        private CDetailedOutline detail;
        private CCourseGoals course;
        private CSubject subject;
        private CExam exam;
        private CPPGD ppgd;
        private CSelfStudy selfstudy;
        private CProgramOutStandards standards;

        public MainController()
        {
            this.chapter = new CChapters();
            this.detail = new CDetailedOutline();
            this.course = new CCourseGoals();
            this.subject = new CSubject();
            this.exam = new CExam();
            this.ppgd = new CPPGD();
            this.selfstudy = new CSelfStudy();
            this.standards = new CProgramOutStandards();
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
        public CourseGoals loadCourseGoals(string id)
        {
            var result = this.course.findFromSubject(id);
            return result;
        }
        public Exams loadExams(string id)
        {
            var result = this.exam.findfromsubject(id);
            return result;
        }
        public PPGDs loadPPGDs(string id)
        {
            var result = this.ppgd.findfromsubject(id);
            return result;
        }
        public ProgramOutStandards loadPOS(string id)
        {
            var result = this.standards.findfromsubject(id);
            return result;
        }
    }
}

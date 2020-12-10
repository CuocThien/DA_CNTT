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
        private CSubject cSub;

        public CExam()
        {
            mongo = new CMongoCRUD("QLCTDT");
        }
        public List<Exams> findAll()
        {
            var result = this.mongo.Read<Exams>("Exams");
            return result;
        }
        public Exams findfromsubject(string id)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub_id = subs.Where(s => s.Course_Code.Equals(id)).SingleOrDefault();
            if (sub_id.Exam_ID.ToString() != "")
            {
                var exam_id = new ObjectId(sub_id.Exam_ID.ToString());
                var result = this.mongo.ReadByObjectId<Exams>("Exams", exam_id);
                return result;
            }
            else return null;
        }
        public void addExam(string id, Exam exam)
        {
            var obId = ObjectId.GenerateNewId();
            CExam cExam = new CExam();
            var examExist = cExam.findfromsubject(id);
            if (!(examExist is null))
            {
                examExist.Exam.Add(exam);
                this.mongo.Update<Exams>("Exams", examExist._id, examExist);
            }
            else
            {
                var examsNew = new Exams();
                examsNew._id = obId;
                this.mongo.InsertRecord<Exams>("Exams", examsNew);
                var exams = this.mongo.ReadByObjectId<Exams>("Exams", obId);
                var result = new List<Exam>();
                result.Add(exam);
                examsNew.Exam = result;
                this.mongo.Update<Exams>("Exams", obId, examsNew);
                cSub = new CSubject();
                var subs = cSub.findAll();
                var subID = new ObjectId(subs.Where(s => s.Course_Code == id).SingleOrDefault()._id.ToString());
                var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", subID);
                sub.Exam_ID = obId.ToString();
                this.mongo.Update<Subjects>("Subjects", subID, sub);
            }
        }
        public void Delete(string subid, string examId)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", new ObjectId(subs.Where(s => s.Course_Code == subid).SingleOrDefault()._id.ToString()));
            var ObId_exam = new ObjectId(sub.Exam_ID.ToString());
            var exam = this.mongo.ReadByObjectId<Exams>("Exams", ObId_exam);
            var examDel = exam.Exam.Where(c => c.ID_Test == examId).SingleOrDefault();

            exam.Exam.Remove(examDel);
            this.mongo.Update<Exams>("Exams", ObId_exam, exam);
        }
        public void Update(string subid, string examId, Exam exam)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", new ObjectId(subs.Where(s => s.Course_Code == subid).SingleOrDefault()._id.ToString()));
            var ObId_exam = new ObjectId(sub.Exam_ID.ToString());
            var examExist = this.mongo.ReadByObjectId<Exams>("Exams", ObId_exam);
            examExist.Exam.Where(c => c.ID_Test == examId).SingleOrDefault().Exercise = exam.Exercise;
            examExist.Exam.Where(c => c.ID_Test == examId).SingleOrDefault().ID_CDR = exam.ID_CDR;
            examExist.Exam.Where(c => c.ID_Test == examId).SingleOrDefault().Date = exam.Date;
            examExist.Exam.Where(c => c.ID_Test == examId).SingleOrDefault().Tool = exam.Tool;
            examExist.Exam.Where(c => c.ID_Test == examId).SingleOrDefault().Percentage = exam.Percentage;
            examExist.Exam.Where(c => c.ID_Test == examId).SingleOrDefault().ID_Test = exam.ID_Test;
            this.mongo.Update<Exams>("Exams", ObId_exam, examExist);
        }
    }
}

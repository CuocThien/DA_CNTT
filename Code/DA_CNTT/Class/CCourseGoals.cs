using DA_CNTT.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_CNTT.Class
{
    public class CCourseGoals
    {
        private CSubject cSub;
        private CMongoCRUD mongo;
        public CCourseGoals()
        {
            mongo = new CMongoCRUD("QLCTDT");
        }
        public List<CourseGoals> findAll()
        {
            var result = this.mongo.Read<CourseGoals>("CourseGoals");
            return result;
        }
        public CourseGoals findFromSubject(string id)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub_id = subs.Where(s => s.Course_Code.Equals(id)).SingleOrDefault();
            if (sub_id.Goal_ID.ToString() != "")
            {
                var coursegoal_id = new ObjectId(sub_id.Goal_ID.ToString());
                var result = this.mongo.ReadByObjectId<CourseGoals>("CourseGoals", coursegoal_id);
                return result;
            }
            else return null;
        }
        public void addCourseGoal(string id, CourseGoal courseGoal)
        {
            var obId = ObjectId.GenerateNewId();
            CCourseGoals cCourseGoals = new CCourseGoals();
            var courseGoalsExist = cCourseGoals.findFromSubject(id);
            if (!(courseGoalsExist is null))
            {
                courseGoalsExist.Course_Goal.Add(courseGoal);
                this.mongo.Update<CourseGoals>("CourseGoals", courseGoalsExist._id, courseGoalsExist);
            }
            else
            {
                var courseGoalsnew = new CourseGoals();
                courseGoalsnew._id = obId;
                this.mongo.InsertRecord<CourseGoals>("CourseGoals", courseGoalsnew);
                var coursegoal = this.mongo.ReadByObjectId<CourseGoals>("CourseGoals", obId);
                var result = new List<CourseGoal>();
                result.Add(courseGoal);
                coursegoal.Course_Goal = result;
                this.mongo.Update<CourseGoals>("CourseGoals", obId, coursegoal);
                cSub = new CSubject();
                var subs = cSub.findAll();
                var subID = new ObjectId(subs.Where(s => s.Course_Code == id).SingleOrDefault()._id.ToString());
                var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", subID);
                sub.Goal_ID = obId.ToString();
                this.mongo.Update<Subjects>("Subjects", subID, sub);
            }
        }
        public void Delete(string subid, string coursegoalId)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", new ObjectId(subs.Where(s => s.Course_Code == subid).SingleOrDefault()._id.ToString()));
            var ObId_coursegoal = new ObjectId(sub.Goal_ID.ToString());
            var coursegoal = this.mongo.ReadByObjectId<CourseGoals>("CourseGoals", ObId_coursegoal);
            var coursegoaldel = coursegoal.Course_Goal.Where(c => c.ID_Goal == coursegoalId).SingleOrDefault();

            coursegoal.Course_Goal.Remove(coursegoaldel);
            this.mongo.Update<CourseGoals>("CourseGoals", ObId_coursegoal, coursegoal);
        }
        public void Update(string subid, string coursegoalId, CourseGoal courseGoal)
        {
            cSub = new CSubject();
            var subs = cSub.findAll();
            var sub = this.mongo.ReadByObjectId<Subjects>("Subjects", new ObjectId(subs.Where(s => s.Course_Code == subid).SingleOrDefault()._id.ToString()));
            var ObId_coursegoal = new ObjectId(sub.Goal_ID.ToString());
            var coursegoalExist = this.mongo.ReadByObjectId<CourseGoals>("CourseGoals", ObId_coursegoal);
            coursegoalExist.Course_Goal.Where(c => c.ID_Goal == coursegoalId).SingleOrDefault().Description_Goal = courseGoal.Description_Goal;
            coursegoalExist.Course_Goal.Where(c => c.ID_Goal == coursegoalId).SingleOrDefault().ID_CDR = courseGoal.ID_CDR;
            coursegoalExist.Course_Goal.Where(c => c.ID_Goal == coursegoalId).SingleOrDefault().ID_CTDT = courseGoal.ID_CTDT;
            coursegoalExist.Course_Goal.Where(c => c.ID_Goal == coursegoalId).SingleOrDefault().ID_Goal = courseGoal.ID_Goal;
            this.mongo.Update<CourseGoals>("CourseGoals", ObId_coursegoal, coursegoalExist);
        }
    }
}

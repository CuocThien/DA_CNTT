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
        //truyền ob_ID từ controllers
        public void delete()
        {
            var id = new ObjectId("5fbbcadb889853cc7e570d30");
            this.mongo.DeleteByObjectId<CourseGoals>("CourseGoals", id);
        }
        //Truyền record từ controllers
        public void Update()
        {
            var id = new ObjectId("5fbbcadb889853cc7e570d30");
            string ID_Goal = "G2";
            var a = this.mongo.ReadByObjectId<CourseGoals>("CourseGoals", id);
            //a.ID_Goal = ID_Goal;
            this.mongo.Update<CourseGoals>("CourseGoals", id, a);
        }
    }
}

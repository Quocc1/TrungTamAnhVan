using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UpdateInstanceDAL
    {
        public void UpdateStudent(int id)
        {
            using (var db =  new Connection())
            {

            }
        }

        public void UpdateCourse(int id, int lessons, string description, string term, int level_id, int category_id)
        {
            using (var db = new Connection())
            {
                var course = (from cs in db.Courses
                              where id == cs.id
                              select cs).FirstOrDefault();
                course.lessons = lessons;
                course.description = description;
                course.term = term;
                course.level_id = level_id;
                course.category_id = category_id;

                db.SaveChanges();
            }
        }
    }
}

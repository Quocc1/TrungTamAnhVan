using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeleteInstanceDAL
    {
        public void DeleteStudent(int id)
        {
            using (var db = new Connection())
            {
                var student = (from st in db.Students
                               where st.id == id
                               select st).FirstOrDefault();
                db.Students.Remove(student);
                db.SaveChanges();
            }
        }

        public void DeleteStudentAccount(int id)
        {
            using (var db = new Connection())
            {
                var studentAccount = (from sa in db.Student_account
                                      where sa.id == id
                                      select sa).FirstOrDefault();
                db.Student_account.Remove(studentAccount);
                db.SaveChanges();
            }
        }

        public void DeleteTeacher(int id)
        {
            using (var db = new Connection())
            {
                var classes = (from cl in db.Classes
                               where cl.teacher_id == id
                               select cl).FirstOrDefault();

                if (classes != null)
                {
                    classes.teacher_id = null;
                }
                db.SaveChanges();

                var teacher = (from tc in db.Teachers
                               where tc.id == id
                               select tc).FirstOrDefault();
                db.Teachers.Remove(teacher);
                db.SaveChanges();
            }
        }

        public void DeleteTeacherAccount(int id)
        {
            using (var db = new Connection())
            {
                var teacherAccount = (from ta in db.Teacher_account
                                      where ta.id == id
                                      select ta).FirstOrDefault();
                if (teacherAccount != null)
                {
                    db.Teacher_account.Remove(teacherAccount);
                }
                db.SaveChanges();
            }
        }

        public void DeleteCourse(int id)
        {
            using (var db = new Connection())
            {
                var classes = (from cs in db.Classes
                               where cs.course_id == id
                               select cs).FirstOrDefault();

                if (classes != null)
                {
                    classes.course_id = null;
                }
                db.SaveChanges();

                var course = (from cs in db.Courses
                              where cs.id == id
                              select cs).FirstOrDefault();
                db.Courses.Remove(course);
                db.SaveChanges();
            }
        }

        public void DeleteClass(int id)
        {
            using (var db = new Connection())
            {
                var classes = (from cl in db.Classes
                               where cl.teacher_id == id
                               select cl).FirstOrDefault();
                db.Classes.Remove(classes);
                db.SaveChanges();
            }
        }
    }
}

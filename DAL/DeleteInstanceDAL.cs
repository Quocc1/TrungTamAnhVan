using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeleteInstanceDAL
    {
        public void DeleteStudent(int student_id)
        {
            using (var db = new Connection())
            {
                var student = (from st in db.Students
                               where st.id == student_id
                               select st).FirstOrDefault();
                db.Students.Remove(student);
                db.SaveChanges();
            }
        }

        public void DeleteStudentFromClass(int student_id, int type)
        {
            using (var db = new Connection())
            {
                var classStudent = (from ct in db.Class_student
                                    where ct.student_id == student_id
                                    select ct).FirstOrDefault();
                if (type == 0)
                {
                    db.Class_student.Remove(classStudent);
                }
                else
                {
                    classStudent.class_id = null;
                }
                db.SaveChanges();
            }
        }

        public void DeleteStudentAccount(int student_id)
        {
            using (var db = new Connection())
            {
                var studentAccount = (from sa in db.Student_account
                                      where sa.student_id == student_id
                                      select sa).FirstOrDefault();
                db.Student_account.Remove(studentAccount);
                db.SaveChanges();
            }
        }

        public void DeleteStudentScore(int student_id)
        {
            using (var db = new Connection())
            {
                var score = (from sc in db.Scores
                             where sc.student_id == student_id
                             select sc).FirstOrDefault();
                db.Scores.Remove(score);
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

        public void DeleteTeacherInClass(int id)
        {
            using (var db = new Connection())
            {
                var classes = (from cl in db.Classes
                                      where cl.teacher_id == id
                                      select cl);
                foreach (var cl in classes)
                {
                    cl.teacher_id = null;
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
                               where cl.id == id
                               select cl).FirstOrDefault();
                db.Classes.Remove(classes);
                db.SaveChanges();
            }
        }

        public void DeleteClassWeekday(int id)
        {
            using (var db = new Connection())
            {
                var classWeekday = (from cw in db.Class_weekday
                               where cw.class_id == id
                               select cw);
                foreach (var cw in classWeekday)
                {
                    db.Class_weekday.Remove(cw);
                }
                db.SaveChanges();
            }
        }
    }
}

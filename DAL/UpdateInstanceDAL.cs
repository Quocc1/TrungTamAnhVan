using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UpdateInstanceDAL
    {
        AddInstanceDAL addInstance = new AddInstanceDAL();

        public void UpdateTeacher(int teacher_id, string full_name, string gender, DateTime date_birth, string phone, string address, string description)
        {
            using (var db = new Connection())
            {
                var teacher = (from tc in db.Teachers
                               where tc.id == teacher_id
                               select tc).FirstOrDefault();
                teacher.full_name = full_name;
                teacher.gender = gender;
                teacher.date_birth = date_birth;
                teacher.phone = phone;
                teacher.address = address;
                teacher.description = description;

                db.SaveChanges();
            }
        }

        public void UpdateTeacherInfo(int teacher_id, string phone, string address, string description)
        {
            using (var db = new Connection())
            {
                var teacher = (from tc in db.Teachers
                               where tc.id == teacher_id
                               select tc).FirstOrDefault();
                teacher.phone = phone;
                teacher.address = address;
                teacher.description = description;

                db.SaveChanges();
            }
        }

        public void UpdateStudent(int student_id, string full_name, string gender, DateTime date_birth, string phone, string address, int level_id)
        {
            
            using (var db =  new Connection())
            {
                var student = (from st in db.Students
                               where st.id == student_id
                               select st).FirstOrDefault();
                student.full_name = full_name;
                student.gender = gender;
                student.date_birth = date_birth;
                student.phone = phone;
                student.address = address;
                student.level_id = level_id;

                db.SaveChanges();
            }
        }

        public void UpdateStudentInfo(int student_id, string phone, string address)
        {
            using (var db = new Connection())
            {
                var student = (from st in db.Students
                               where st.id == student_id
                               select st).FirstOrDefault();
                student.phone = phone;
                student.address = address;

                db.SaveChanges();
            }
        }

        public void UpdateStudentScore(int student_id, string listening_score, string speakning_score, string reading_score, string writing_score)
        {
            using (var db = new Connection())
            {
                var score = (from sc in db.Scores
                             where sc.student_id == student_id
                             select sc).FirstOrDefault();
                if (listening_score == "")
                {
                    score.listening_score = null;
                }
                else
                {
                    score.listening_score = Convert.ToDouble(listening_score);
                }
                if (listening_score == "")
                {
                    score.speaking_score = null;
                }
                else
                {
                    score.speaking_score = Convert.ToDouble(speakning_score);
                }
                if (listening_score == "")
                {
                    score.reading_score = null;
                }
                else
                {
                    score.reading_score = Convert.ToDouble(reading_score);
                }
                if (listening_score == "")
                {
                    score.writing_score = null;
                }
                else
                {
                    score.writing_score = Convert.ToDouble(writing_score);
                }

                db.SaveChanges();
            }
        }

        public void UpdateClassStudent(int student_id, int class_id)
        {
            using (var db = new Connection())
            {
                var classStudent = (from ct in db.Class_student
                                    where ct.student_id == student_id
                                    select ct).FirstOrDefault();
                if (class_id < 0)
                {
                    classStudent.class_id = null;
                }
                else
                {
                    classStudent.class_id = class_id;
                }

                db.SaveChanges();
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

        public void UpdateClass(int id, string name, DateTime start_day, DateTime end_day, int price, int teacher_id, int course_id)
        {
            using (var db = new Connection())
            {
                var classes = (from cl in db.Classes
                              where id == cl.id
                              select cl).FirstOrDefault();
                classes.name = name;
                classes.start_day = start_day;
                classes.end_day = end_day;
                classes.price = price;
                classes.teacher_id = teacher_id;
                classes.course_id = course_id;

                db.SaveChanges();
            }
        }
    }
}

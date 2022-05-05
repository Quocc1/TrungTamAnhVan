using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AddInstanceDAL
    {
        public void AddCourse(Course course)
        {
            using (var db = new Connection())
            {
                db.Courses.Add(course);
                db.SaveChanges();
            }
        }

        public void AddClassWeekday(Class_weekday classWeekday)
        {
            using (var db = new Connection())
            {
                db.Class_weekday.Add(classWeekday);
                db.SaveChanges();
            }
        }

        public void AddClass(Class classes)
        {
            using (var db = new Connection())
            {
                db.Classes.Add(classes);
                db.SaveChanges();
            }    
        }

        public void AddStudent(Student student)
        {
            using (var db = new Connection())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }

        public void AddStudentAccount(Student_account studentAccount)
        {
            using (var db = new Connection())
            {
                db.Student_account.Add(studentAccount);
                db.SaveChanges();
            }

        }

        public void AddTeacher(Teacher teacher)
        {
            using (var db = new Connection())
            {
                db.Teachers.Add(teacher);
                db.SaveChanges();
            }
        }

        public void AddTeacherAccount(Teacher_account TeacherAccount)
        {
            using (var db = new Connection())
            {
                db.Teacher_account.Add(TeacherAccount);
                db.SaveChanges();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class InstanceDAL
    {
        Connection db = new Connection();
        public Admin GetAdminFromId(int id)
        {
            Admin admin = new Admin();
            using (var db = new Connection())
            {
                admin = (from ad in db.Admins
                         where ad.id == id
                         select ad).FirstOrDefault();
            }
            return admin;
        }

        public Teacher GetTeacherFromId(int id)
        {
            Teacher teacher = new Teacher();
            using (var db = new Connection())
            {
                teacher = (from tc in db.Teachers
                           where tc.id == id
                           select tc).FirstOrDefault();
            }
            return teacher;
        }

        public Student GetStudentFromId(int id)
        {
            Student student = new Student();
            using (var db = new Connection())
            {
                student = (from st in db.Students
                          where st.id == id
                          select st).FirstOrDefault();
            }
            return student;
        }

        public List<Admin> GetAllAdmin()
        {
            using (var db = new Connection())
            {
                var admins = (from ad in db.Admins.Include("Admin_account")
                             select ad).ToList();
                return admins;
            }
        }

        public List<Teacher> GetAllTeacher()
        {
            var teachers = (from tc in db.Teachers.Include("Teacher_account")
                         select tc).ToList();
            return teachers;
        }

        public List<Student> GetAllStudent()
        {
            using (var db = new Connection())
            {
                var students = (from st in db.Students.Include("Student_account").Include("Class_student")
                               select st).ToList();
                return students;
            }
        }
    }
}

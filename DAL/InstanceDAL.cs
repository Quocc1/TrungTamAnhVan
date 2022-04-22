using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InstanceDAL
    {
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
    }
}

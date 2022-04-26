using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class LoginBUS
    {
        LoginDAL loginDAL = new LoginDAL();
        InstanceDAL instanceDAL = new InstanceDAL();
        InformationDAL infoDAL = new InformationDAL();

        public string CheckLoginAdmin(string username, string password)
        {
            List<Admin_account> admin_Accounts = new List<Admin_account>();
            admin_Accounts = loginDAL.GetAdminAccounts();
            foreach (var account in admin_Accounts)
            {
                if (account.login == username && account.password == password)
                {
                    return infoDAL.GetNameAdmin(instanceDAL.GetAdminFromId((int)account.admin_id));
                }
            }
            return null;
        }
        public string CheckLoginTeacher(string username, string password)
        {
            List<Teacher_account> teacher_Accounts = new List<Teacher_account>();
            teacher_Accounts = loginDAL.GetTeacherAccounts();
            foreach (var account in teacher_Accounts)
            {
                if (account.login == username && account.password == password)
                {
                    return infoDAL.GetNameTeacher(instanceDAL.GetTeacherFromId((int)account.teacher_id));
                }
            }
            return null;
        }
        public string CheckLoginStudent(string username, string password)
        {
            List<Student_account> student_Accounts = new List<Student_account>();
            student_Accounts = loginDAL.GetStudentAccounts();
            foreach (var account in student_Accounts)
            {
                if (account.login == username && account.password == password)
                {
                    return infoDAL.GetNameStudent(instanceDAL.GetStudentFromId((int)account.student_id));
                }
            }
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL
    {
        public List<Admin_account> GetAdminAccounts()
        {
            List<Admin_account> listAccount = new List<Admin_account>();
            using (var db = new Connection())
            {
                var accounts = from account in db.Admin_account
                               select account;
                foreach (var account in accounts)
                {
                    listAccount.Add(account);
                }
            }
            return listAccount;
        }
        public List<Teacher_account> GetTeacherAccounts()
        {
            List<Teacher_account> listAccount = new List<Teacher_account>();
            using (var db = new Connection())
            {
                var accounts = from account in db.Teacher_account
                               select account;
                foreach (var account in accounts)
                {
                    listAccount.Add(account);
                }
            }
            return listAccount;
        }
        public List<Student_account> GetStudentAccounts()
        {
            List<Student_account> listAccount = new List<Student_account>();
            using (var db = new Connection())
            {
                var accounts = from account in db.Student_account
                               select account;
                foreach (var account in accounts)
                {
                    listAccount.Add(account);
                }
            }
            return listAccount;
        }
    }
}

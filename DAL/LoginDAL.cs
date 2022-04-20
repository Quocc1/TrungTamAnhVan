using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL
    {
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

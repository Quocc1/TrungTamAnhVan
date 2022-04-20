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
        public bool CheckLogin(string username, string password)
        {
            List<Student_account> listAccount = new List<Student_account>();
            LoginDAL loginDAL = new LoginDAL();
            listAccount = loginDAL.GetStudentAccounts();
            foreach (var account in listAccount)
            {
                if (account.login == username && account.password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

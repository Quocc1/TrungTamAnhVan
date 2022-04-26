using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class InformationBUS
    {
        InformationDAL infoDAL = new InformationDAL();
        public string CountAdmin()
        {
            return infoDAL.CountAdmin().ToString();
        }

        public string CountTeacher()
        {
            return infoDAL.CountTeacher().ToString();
        }

        public string CountStudent()
        {
            return infoDAL.CountStudent().ToString();
        }
    }
}

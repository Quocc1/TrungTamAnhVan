using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InformationDAL
    {
        public string GetNameAdmin(Admin ad)
        {
            return ad.full_name;
        }
        public string GetNameTeacher(Teacher tc)
        {
            return tc.full_name;
        }
        public string GetNameStudent(Student st)
        {
            return st.full_name;
        }
    }
}

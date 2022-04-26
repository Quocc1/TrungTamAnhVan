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

        public int CountAdmin()
        {
            int count = 0;
            using (var db = new Connection())
            {
                count = (from ad in db.Admins select ad).Count();
            }
            return count;
        }

        public int CountTeacher()
        {
            int count = 0;
            using (var db = new Connection())
            {
                count = (from tc in db.Teachers select tc).Count();
            }
            return count;
        }

        public int CountStudent()
        {
            int count = 0;
            using (var db = new Connection())
            {
                count = (from st in db.Students select st).Count();
            }
            return count;
        }
    }
}

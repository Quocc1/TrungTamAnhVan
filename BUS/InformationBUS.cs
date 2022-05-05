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
        GetInstanceDAL getInstance = new GetInstanceDAL();
        InformationDAL infoDAL = new InformationDAL();

        public int GetTermCourse(int id)
        {
            return Convert.ToInt32(infoDAL.GetTermCourse(getInstance.GetCourseFromId(id)));
        }

        public int GetNewestTeacherId()
        {
            return infoDAL.GetNewestTeacherId();
        }

        public int GetNewestStudentId()
        {
            return infoDAL.GetNewestStudentId();
        }

        public int GetNewestClassId()
        {
            return infoDAL.GetNewestClassId();
        }

        public int CountAdmin()
        {
            return infoDAL.CountAdmin();
        }

        public int CountTeacher()
        {
            return infoDAL.CountTeacher();
        }

        public int CountStudent()
        {
            return infoDAL.CountStudent();
        }
    }
}

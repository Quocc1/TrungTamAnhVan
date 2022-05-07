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

        public int CountClass()
        {
            return infoDAL.CountClass();
        }

        public int CountCourse()
        {
            return infoDAL.CountCourse();
        }

        public string CheckAvailableTeacher(int teacher_id, List<int> listWeekday, string start_day, string end_day, int start_hour, int end_hour)
        {
            bool flag = false;
            string result = "";
            DateTime start_dayx = DateTime.Parse(start_day);
            DateTime end_dayx = DateTime.Parse(end_day);
            foreach (int weekday in listWeekday)
            {
                result += infoDAL.CheckAvailableTeacher(teacher_id, weekday, start_dayx, end_dayx, start_hour, end_hour, flag).Item1;
                flag = infoDAL.CheckAvailableTeacher(teacher_id, weekday, start_dayx, end_dayx, start_hour, end_hour, flag).Item2;
            }
            return result;
        }
    }
}

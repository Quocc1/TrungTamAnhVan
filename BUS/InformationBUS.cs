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

        public string GetAdminPassword(int admin_id)
        {
            return infoDAL.GetAdminPassword(admin_id);
        }

        public List<string> GetInfoTeacher(int teacher_id)
        {
            return infoDAL.GetInfoTeacher(teacher_id);
        }

        public int GetNewestTeacherId()
        {
            return infoDAL.GetNewestTeacherId();
        }

        public string GetTeacherPassword(int teacher_id)
        {
            return infoDAL.GetTeacherPassword(teacher_id);
        }

        public List<string> GetInfoStudent(int student_id)
        {
            return infoDAL.GetInfoStudent(student_id);
        }

        public int GetNewestStudentId()
        {
            return infoDAL.GetNewestStudentId();
        }

        public string GetStudentPassword(int student_id)
        {
            return infoDAL.GetStudentPassword(student_id);
        }

        public int GetNewestClassId()
        {
            return infoDAL.GetNewestClassId();
        }

        public string GetTimeClass(string className)
        {
            return infoDAL.GetTimeClass(className);
        }

        public int GetStartHour(int id)
        {
            return infoDAL.GetStartHour(id);
        }

        public int GetEndHour(int id)
        {
            return infoDAL.GetEndHour(id);
        }

        public List<int> GetWeekday(int id)
        {
            return infoDAL.GetWeekday(id);
        }

        public decimal GetClassPrice(int student_id)
        {
            return infoDAL.GetClassPrice(student_id);
        }

        public string GetClassName(int student_id)
        {
            return infoDAL.GetClassName(student_id);
        }

        public string GetCourseName(int student_id)
        {
            return infoDAL.GetCourseName(student_id);
        }

        public decimal GetTeacherSalary(int teacher_id)
        {
            return infoDAL.GetTeacherSalary(teacher_id);
        }

        public decimal GetIncome()
        {
            return infoDAL.GetIncome();
        }

        public decimal GetExpenses()
        {
            return infoDAL.GetExpenses();
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

        public int CountTeachingDay(int teacher_id)
        {
            return infoDAL.CountTeachingDay(teacher_id);
        }

        public string CheckAvailableTeacher(int class_id, int teacher_id, List<int> listWeekday, DateTime start_day, DateTime end_day, int start_hour, int end_hour)
        {
            bool flag = false;
            string result = "";
            foreach (int weekday in listWeekday)
            {
                result += infoDAL.CheckAvailableTeacher(class_id, teacher_id, weekday, start_day, end_day, start_hour, end_hour, flag).Item1;
                flag = infoDAL.CheckAvailableTeacher(class_id, teacher_id, weekday, start_day, end_day, start_hour, end_hour, flag).Item2;
            }
            return result;
        }

        public bool CheckStudentHaveClass(int student_id)
        {
            return infoDAL.CheckStudentHaveClass(student_id);
        }
    }
}

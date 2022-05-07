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

        public string GetNameCategory(Category ct)
        {
            return ct.name;
        }

        public string GetNameLevel(Level lv)
        {
            return lv.sign;
        }

        public string GetTermCourse(Course cs)
        {
            return cs.term;
        }

        public int GetNewestTeacherId()
        {
            using (var db = new Connection())
            {
                var teacher = (from tc in db.Teachers
                               orderby tc.id descending
                               select tc).FirstOrDefault();
                return teacher.id;
            }
        }

        public int GetNewestStudentId()
        {
            using (var db = new Connection())
            {
                var student = (from st in db.Students
                               orderby st.id descending
                               select st).FirstOrDefault();
                return student.id;
            }
        }

        public int GetNewestClassId()
        {
            using (var db = new Connection())
            {
                var classes = (from cs in db.Classes
                               orderby cs.id descending
                               select cs).FirstOrDefault();
                return classes.id;
            }
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

        public int CountClass()
        {
            int count = 0;
            using (var db = new Connection())
            {
                count = (from cl in db.Classes select cl).Count();
            }
            return count;
        }

        public int CountCourse()
        {
            int count = 0;
            using (var db = new Connection())
            {
                count = (from cs in db.Courses select cs).Count();
            }
            return count;
        }

        public (string, bool) CheckAvailableTeacher(int teacher_id, int weekday, DateTime start_dayx, DateTime end_dayx, int start_hourx, int end_hourx, bool flag)
        {
            string result = "";
            using (var db = new Connection())
            {
                var classes = (from cl in db.Classes.Include("Class_weekday")
                               where cl.teacher_id == teacher_id
                               select cl);

                foreach(var cl in classes)
                {
                    DateTime dt1 = cl.start_day ?? DateTime.Now;
                    DateTime dt2 = cl.end_day ?? DateTime.Now;
                    if (DateTime.Compare(start_dayx, dt2) < 0 && DateTime.Compare(end_dayx, dt1) > 0)
                    {
                        foreach (var wd in cl.Class_weekday)
                        {
                            if (wd.weekday_id == weekday)
                            {
                                if (start_hourx < wd.end_hour && end_hourx > wd.start_hour)
                                {
                                    if (!flag)
                                    {
                                        result += $"Giáo viên {cl.Teacher.full_name} bị kẹt lịch: ";
                                        result += $"\nLớp {cl.name} thứ {wd.Weekday.name} lúc {wd.start_hour} - {wd.end_hour}";
                                    }
                                    else
                                    {
                                        result += $"\nLớp {cl.name} thứ {wd.Weekday.name} lúc {wd.start_hour} - {wd.end_hour}";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return (result, true);
        }
    }
}

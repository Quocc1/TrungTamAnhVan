using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InformationDAL
    {
        public List<string> GetInfoTeacher(int teacher_id)
        {
            List<string> list = new List<string>();
            using (var db = new Connection())
            {
                var teacher = (from tc in db.Teachers
                               where tc.id == teacher_id
                               select tc).FirstOrDefault();

                list.Add(teacher.full_name);
                list.Add(teacher.gender);
                list.Add(teacher.date_birth.ToString());
                list.Add(teacher.phone);
                list.Add(teacher.address);
                list.Add(teacher.description);
            }
            return list;
        }

        public List<string> GetInfoStudent(int student_id)
        {
            List<string> list = new List<string>();
            using (var db = new Connection())
            {
                var student = (from st in db.Students
                               where st.id == student_id
                               select st).FirstOrDefault();

                list.Add(student.full_name);
                list.Add(student.gender);
                list.Add(student.date_birth.ToString());
                list.Add(student.phone);
                list.Add(student.address);
                list.Add(student.Level.sign);
                string className = student.Class_student.FirstOrDefault().Class != null ? student.Class_student.FirstOrDefault().Class.name : "";
                list.Add(className);
            }
            return list;
        }

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

        public string GetTimeClass(string className)
        {
            if (className != "")
            {
                using (var db = new Connection())
                {
                    string time = "";
                    string day = "";
                    string hour = "";
                    var weekday = (from cw in db.Class_weekday
                                   where cw.Class.name == className
                                   select cw).ToList();

                    foreach (var wd in weekday)
                    {
                        day += wd.Weekday.name + " ";
                    }
                    var classes = (from cl in db.Classes
                                   where cl.name == className
                                   select cl).FirstOrDefault();
                    hour = classes.Class_weekday.FirstOrDefault().start_hour + "h - " + classes.Class_weekday.FirstOrDefault().end_hour + "h";
                    time = day + hour;

                    return time;
                }
            }
            else
            {
                return "";
            }
        }

        public int GetStartHour(int id)
        {
            using (var db = new Connection())
            {
                var classWeekend = (from cw in db.Class_weekday
                                    where cw.class_id == id
                                    select cw).FirstOrDefault();
                return classWeekend.start_hour ?? 0;
            }
        }

        public int GetEndHour(int id)
        {
            using (var db = new Connection())
            {
                var classWeekend = (from cw in db.Class_weekday
                                    where cw.class_id == id
                                    select cw).FirstOrDefault();
                return classWeekend.end_hour ?? 0;
            }
        }

        public List<int> GetWeekday(int id)
        {
            List<int> result = new List<int>();
            using (var db = new Connection())
            {
                var weekday = (from wd in db.Class_weekday
                               where wd.class_id == id
                               select wd);
                foreach (var wd in weekday)
                {
                    result.Add(wd.weekday_id);
                }
            }
            return result;
        }

        public decimal GetClassPrice(int student_id)
        {
            decimal fee = 0;
            using (var db = new Connection())
            {
                var classes = (from cl in db.Class_student
                               where cl.student_id == student_id
                               select cl).FirstOrDefault();
                fee = classes.Class != null ? (decimal)classes.Class.price : 0;
            }
            return fee;
        }

        public string GetClassName(int student_id)
        {
            string name = "";
            using (var db = new Connection())
            {
                var classes = (from cl in db.Class_student
                               where cl.student_id == student_id
                               select cl).FirstOrDefault();
                name = classes.Class != null ? (string)classes.Class.name : "";
            }
            return name;
        }

        public string GetCourseName(int student_id)
        {
            string name = "";
            using (var db = new Connection())
            {
                var classes = (from cs in db.Class_student
                               where cs.student_id == student_id
                               select cs).FirstOrDefault();
                name = classes.Class != null ? (string)classes.Class.Course.description : "";
            }
            return name;
        }

        public decimal GetTeacherSalary(int teacher_id)
        {
            int day = CountTeachingDay(teacher_id);
            decimal salary = 100000 * day;
            using (var db = new Connection())
            {
                var teacher = (from tc in db.Teachers
                               where tc.id == teacher_id
                               select tc).FirstOrDefault();
                teacher.salary = salary;
            
                db.SaveChanges();
            }
            return salary;
        }

        public decimal GetIncome()
        {
            decimal income = 0;
            using (var db = new Connection())
            {
                var students = (from st in db.Class_student
                               where st.class_id != null
                               select st).ToList();
                foreach(var st in students)
                {
                    income += st.Class.price ?? 0;
                }
            }
            return income;
        }

        public decimal GetExpenses()
        {
            decimal expenses = 0;
            using (var db = new Connection())
            {
                var teachers = (from tc in db.Teachers
                                select tc).ToList();
                foreach (var tc in teachers)
                {
                    expenses += tc.salary ?? 0;
                }
            }
            return expenses;
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

        public (string, bool) CheckAvailableTeacher(int class_id, int teacher_id, int weekday, DateTime start_dayx, DateTime end_dayx, int start_hourx, int end_hourx, bool flag)
        {
            string result = "";
            using (var db = new Connection())
            {
                IQueryable<Class> classes;
                if (class_id != 0)
                {
                    classes = (from cl in db.Classes.Include("Class_weekday")
                                   where cl.teacher_id == teacher_id && cl.id != class_id
                                   select cl);
                }
                else
                {
                    classes = (from cl in db.Classes.Include("Class_weekday")
                                   where cl.teacher_id == teacher_id
                                   select cl);
                }

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
                                        result += $"\nLớp {cl.name} thứ {wd.Weekday.name} lúc {wd.start_hour}h - {wd.end_hour}h";
                                    }
                                    else
                                    {
                                        result += $"\nLớp {cl.name} thứ {wd.Weekday.name} lúc {wd.start_hour}h - {wd.end_hour}h";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return (result, true);
        }

        public int CountTeachingDay(int teacher_id)
        {
            int day = 0;
            using (var db = new Connection())
            {
                day += (from cl in db.Class_weekday
                               select cl.Class.teacher_id == teacher_id).Count() * 4;
            }
            return day;
        }

        public bool CheckStudentHaveClass(int student_id)
        {
            using (var db = new Connection())
            {
                var student = (from st in db.Students
                               where st.id == student_id
                               select st).FirstOrDefault();
                if (student.Class_student.FirstOrDefault().class_id != null)
                {
                    return true;
                }
                return false;
            }
        }
    }
}

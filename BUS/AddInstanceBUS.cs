using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class AddInstanceBUS
    {
        AddInstanceDAL addInstance = new AddInstanceDAL();

        public void AddCourse(int lessons, string description, string term, int level_id, int category_id)
        {
            Course course = new Course();
            {
                course.lessons = lessons;
                course.description = description;
                course.term = term;
                course.level_id = level_id;
                course.category_id = category_id;
            }
            addInstance.AddCourse(course);
        }

        public void AddClassWeekday(int class_id, List<int> listWeekday, int start_hour, int end_hour)
        {
            foreach(int item in listWeekday)
            {
                Class_weekday classWeekday = new Class_weekday();
                classWeekday.class_id = class_id;
                classWeekday.weekday_id = item;
                classWeekday.start_hour = start_hour;
                classWeekday.end_hour = end_hour;

                addInstance.AddClassWeekday(classWeekday);
            }
        }

        public void AddClass(string name, DateTime start_day, DateTime end_day, int price, int teacher_id, int course_id)
        {
            Class classes = new Class();
            {
                classes.name = name;
                classes.start_day = start_day;
                classes.end_day = end_day;
                classes.price = price;
                classes.teacher_id = teacher_id;
                classes.course_id = course_id;
            }
            addInstance.AddClass(classes);
        }

        public void AddStudentToClass(int student_id, int class_id)
        {
            Class_student classStudent = new Class_student();
            {
                classStudent.student_id = student_id;
                if (class_id < 0)
                {
                    classStudent.class_id = null;
                }
                else
                {
                    classStudent.class_id = class_id;
                }
            }
            addInstance.AddStudentToClass(classStudent);
        }

        public void AddStudent(string full_name, string gender, DateTime date_birth, string phone, string address, int level_id)
        {
            Student student = new Student();
            {
                student.full_name = full_name;
                student.gender = gender;
                student.date_birth = date_birth;
                student.phone = phone;
                student.address = address;
                student.level_id = level_id;
            }
            addInstance.AddStudent(student);
        }

        public void AddStudentAccount(int id, string login, string password)
        {
            Student_account studentAccount = new Student_account();
            {
                studentAccount.student_id = id;
                studentAccount.login = login;
                studentAccount.password = password;
            }
            addInstance.AddStudentAccount(studentAccount);
        }


        public void AddStudentScore(int student_id)
        {
            Score score = new Score();
            {
                score.student_id = student_id;
            }
            addInstance.AddStudentScore(score);
        }

        public void AddTeacher(string full_name, string gender, DateTime date_birth, string phone, string address, string description)
        {
            Teacher teacher = new Teacher();
            {
                teacher.full_name = full_name;
                teacher.gender = gender;
                teacher.date_birth = date_birth;
                teacher.phone = phone;
                teacher.address = address;
                teacher.description = description;
                teacher.salary = 0;
            }
            addInstance.AddTeacher(teacher);
        }

        public void AddTeacherAccount(int id, string login, string password)
        {
            Teacher_account teacherAccount = new Teacher_account();
            {
                teacherAccount.teacher_id = id;
                teacherAccount.login = login;
                teacherAccount.password = password;
            }
            addInstance.AddTeacherAccount(teacherAccount);
        }

        public void AddEvent(string title, string description, DateTime sending_time, int class_id)
        {
            Event events = new Event();
            {
                events.title = title;
                events.description = description;
                events.sending_time = sending_time;
                events.class_id = class_id;
            }
            addInstance.AddEvent(events);
        }
    }
}

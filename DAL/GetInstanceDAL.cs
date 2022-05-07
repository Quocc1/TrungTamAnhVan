using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class GetInstanceDAL
    {
        public Admin GetAdminFromId(int id)
        {
            Admin admin = new Admin();
            using (var db = new Connection())
            {
                admin = (from ad in db.Admins
                         where ad.id == id
                         select ad).FirstOrDefault();
            }
            return admin;
        }

        public Teacher GetTeacherFromId(int id)
        {
            Teacher teacher = new Teacher();
            using (var db = new Connection())
            {
                teacher = (from tc in db.Teachers
                           where tc.id == id
                           select tc).FirstOrDefault();
            }
            return teacher;
        }

        public Student GetStudentFromId(int id)
        {
            Student student = new Student();
            using (var db = new Connection())
            {
                student = (from st in db.Students
                          where st.id == id
                          select st).FirstOrDefault();
            }
            return student;
        }

        public Category GetCategoryFromId(int id)
        {
            Category category = new Category();
            using (var db = new Connection())
            {
                category = (from ct in db.Categories
                            where ct.id == id
                            select ct).FirstOrDefault();
            }
            return category;
        }

        public Level GetLevelFromId(int id)
        {
            Level level = new Level();
            using (var db = new Connection())
            {
                level = (from lv in db.Levels
                         where lv.id == id
                         select lv).FirstOrDefault();
            }
            return level;
        }

        public Course GetCourseFromId(int id)
        {
            Course course = new Course();
            using (var db = new Connection())
            {
                course = (from cs in db.Courses
                          where cs.id == id
                          select cs).FirstOrDefault();
            }
            return course;
        }

        public List<Admin> GetAllAdmin()
        {
            using (var db = new Connection())
            {
                var admins = (from ad in db.Admins.Include("Admin_account")
                             select ad).ToList();
                return admins;
            }
        }

        public List<dynamic> GetAllTeacher()
        {
            using (var db = new Connection())
            {
                var teachers = (from tc in db.Teachers
                                select new
                                {
                                    id = tc.id,
                                    full_name = tc.full_name,
                                    gender = tc.gender,
                                    date_birth = tc.date_birth,
                                    phone = tc.phone,
                                    address = tc.address,
                                    description = tc.description
                                }).ToList<dynamic>();
                return teachers;
            }
                
        }

        public List<dynamic> GetAllTeacherByGender(string gender)
        {
            using (var db = new Connection())
            {
                var teachers = (from tc in db.Teachers
                                where tc.gender == gender
                                select new
                                {
                                    id = tc.id,
                                    full_name = tc.full_name,
                                    gender = tc.gender,
                                    date_birth = tc.date_birth,
                                    phone = tc.phone,
                                    address = tc.address,
                                    description = tc.description
                                }).ToList<dynamic>();
                return teachers;
            }
        }

        public List<dynamic> GetAllStudent()
        {
            using (var db = new Connection())
            {
                var students = (from st in db.Students
                                select new
                                {
                                    id = st.id,
                                    full_name = st.full_name,
                                    gender = st.gender,
                                    date_birth = st.date_birth,
                                    phone = st.phone,
                                    address = st.address,
                                    classes = st.Class.name ?? "Chưa có lớp",
                                    level = st.Level.sign
                                }).ToList<dynamic>();
                return students;
            }
        }

        public List<dynamic> GetAllStudentByGenderAndClass(string gender, string className)
        {
            if (className == "Chưa có lớp")
            {
                className = null;
            }

            using (var db = new Connection())
            {
                if (gender == "Tất cả" && className != "Tất cả")
                {
                    var students = (from st in db.Students
                                    where st.Class.name == className
                                    select new
                                    {
                                        id = st.id,
                                        full_name = st.full_name,
                                        gender = st.gender,
                                        date_birth = st.date_birth,
                                        phone = st.phone,
                                        address = st.address,
                                        classes = st.Class.name ?? "Chưa có lớp",
                                        level = st.Level.sign
                                    }).ToList<dynamic>();
                    return students;
                }
                else if (gender != "Tất cả" && className == "Tất cả")
                {
                    var students = (from st in db.Students
                                    where st.gender == gender
                                    select new
                                    {
                                        id = st.id,
                                        full_name = st.full_name,
                                        gender = st.gender,
                                        date_birth = st.date_birth,
                                        phone = st.phone,
                                        address = st.address,
                                        classes = st.Class.name ?? "Chưa có lớp",
                                        level = st.Level.sign
                                    }).ToList<dynamic>();
                    return students;
                }
                else
                {
                    var students = (from st in db.Students
                                    where st.gender == gender && st.Class.name == className
                                    select new
                                    {
                                        id = st.id,
                                        full_name = st.full_name,
                                        gender = st.gender,
                                        date_birth = st.date_birth,
                                        phone = st.phone,
                                        address = st.address,
                                        classes = st.Class.name ?? "Chưa có lớp",
                                        level = st.Level.sign
                                    }).ToList<dynamic>();
                return students;
                }
            }
        }

        public List<dynamic> GetAllCourse()
        {
            using (var db = new Connection())
            {
                var courses = (from cs in db.Courses
                               select new
                               {
                                   id = cs.id,
                                   lessons = cs.lessons,
                                   description = cs.description,
                                   term = cs.term,
                                   category = cs.Category.name,
                                   level = cs.Level.sign
                               }).ToList<dynamic>();
                return courses;
            }
        }

        public List<dynamic> GetAllCourseByLevelAndCategory(int level_id, int category_id)
        {
            using (var db = new Connection())
            {
                if (level_id == 0 && category_id > 0)
                {
                    var courses = (from cs in db.Courses
                                   where cs.category_id == category_id
                                   select new
                                   {
                                       id = cs.id,
                                       lessons = cs.lessons,
                                       description = cs.description,
                                       term = cs.term,
                                       category = cs.Category.name,
                                       level = cs.Level.sign
                                   }).ToList<dynamic>();
                    return courses;
                }
                else if (level_id > 0 && category_id == 0)
                {
                    var courses = (from cs in db.Courses
                                   where cs.level_id == level_id
                                   select new
                                   {
                                       id = cs.id,
                                       lessons = cs.lessons,
                                       description = cs.description,
                                       term = cs.term,
                                       category = cs.Category.name,
                                       level = cs.Level.sign
                                   }).ToList<dynamic>();
                    return courses;
                }
                else
                {
                    var courses = (from cs in db.Courses
                                   where cs.level_id == level_id && cs.category_id == category_id
                                   select new
                                   {
                                       id = cs.id,
                                       lessons = cs.lessons,
                                       description = cs.description,
                                       term = cs.term,
                                       category = cs.Category.name,
                                       level = cs.Level.sign
                                   }).ToList<dynamic>();
                    return courses;
                }
            }
        }

        public List<dynamic> GetAllClass()
        {
            using (var db = new Connection())
            {
                var classes = (from cl in db.Classes
                               select new
                               {
                                   id = cl.id,
                                   name = cl.name,
                                   start_day = cl.start_day,
                                   end_day = cl.end_day,
                                   price = cl.price,
                                   quantity = cl.quantity + "/" + cl.max_quantity,
                                   teacher_id = cl.Teacher.full_name,
                                   course_id = cl.Course.description
                               }).ToList<dynamic>();
                return classes;
            }
        }

        public List<dynamic> GetAllAvailableClass()
        {
            using (var db = new Connection())
            {
                var classes = (from cl in db.Classes
                               where cl.quantity < cl.max_quantity
                               select new
                               {
                                   id = cl.id,
                                   name = cl.name,
                                   start_day = cl.start_day,
                                   end_day = cl.end_day,
                                   price = cl.price,
                                   quantity = cl.quantity + "/" + cl.max_quantity,
                                   teacher_id = cl.Teacher.full_name,
                                   course_id = cl.Course.description
                               }).ToList<dynamic>();
                return classes;
            }
        }

        public List<dynamic> GetAllClassByLevelAndCategory(int level_id, int age)
        {
            using (var db = new Connection())
            {
                if (age > 18)
                {
                    var classes = (from cl in db.Classes
                                   where cl.Course.level_id == level_id && cl.Course.category_id == 3
                                   select new
                                   {
                                       id = cl.id,
                                       name = cl.name,
                                       start_day = cl.start_day,
                                       end_day = cl.end_day,
                                       price = cl.price,
                                       quantity = cl.quantity + "/" + cl.max_quantity,
                                       teacher_id = cl.Teacher.full_name,
                                       course_id = cl.Course.description
                                   }).ToList<dynamic>();
                    return classes;
                }
                else if (age > 12 && age <= 18)
                {
                    var classes = (from cl in db.Classes
                                   where cl.Course.level_id == level_id && cl.Course.category_id == 2
                                   select new
                                   {
                                       id = cl.id,
                                       name = cl.name,
                                       start_day = cl.start_day,
                                       end_day = cl.end_day,
                                       price = cl.price,
                                       quantity = cl.quantity + "/" + cl.max_quantity,
                                       teacher_id = cl.Teacher.full_name,
                                       course_id = cl.Course.description
                                   }).ToList<dynamic>();
                    return classes;
                }
                else
                {
                    var classes = (from cl in db.Classes
                                   where cl.Course.level_id == level_id && cl.Course.category_id == 1
                                   select new
                                   {
                                       id = cl.id,
                                       name = cl.name,
                                       start_day = cl.start_day,
                                       end_day = cl.end_day,
                                       price = cl.price,
                                       quantity = cl.quantity + "/" + cl.max_quantity,
                                       teacher_id = cl.Teacher.full_name,
                                       course_id = cl.Course.description
                                   }).ToList<dynamic>();
                    return classes;
                }
            }
        }

        public List<dynamic> FindTeacherByNameOrPhone(string keyword)
        {
            using (var db = new Connection())
            {
                var teachers = (from tc in db.Teachers
                                where tc.full_name.Contains(keyword) || tc.phone.Contains(keyword)
                                select new
                                {
                                    id = tc.id,
                                    full_name = tc.full_name,
                                    gender = tc.gender,
                                    date_birth = tc.date_birth,
                                    phone = tc.phone,
                                    address = tc.address,
                                    description = tc.description
                                }).ToList<dynamic>();
                return teachers;
            }
        }

        public List<dynamic> FindStudentByNameOrPhone(string keyword)
        {
            using (var db = new Connection())
            {
                var students = (from st in db.Students
                                where st.full_name.Contains(keyword) || st.phone.Contains(keyword)
                                select new
                                {
                                    id = st.id,
                                    full_name = st.full_name,
                                    gender = st.gender,
                                    date_birth = st.date_birth,
                                    phone = st.phone,
                                    address = st.address,
                                    classes = st.Class.name ?? "Chưa có lớp",
                                    level = st.Level.sign
                                }).ToList<dynamic>();
                return students;
            }
        }

        public List<dynamic> FindCourseByName(string keyword)
        {
            using (var db = new Connection())
            {
                var courses = (from cs in db.Courses
                               where cs.description.Contains(keyword)
                               select new
                               {
                                   id = cs.id,
                                   lessons = cs.lessons,
                                   description = cs.description,
                                   term = cs.term,
                                   category = cs.Category.name,
                                   level = cs.Level.sign
                               }).ToList<dynamic>();
                return courses;
            }
        }

        public List<dynamic> FindClassByNameOrTeacher(string keyword)
        {
            using (var db = new Connection())
            {
                var classes = (from cl in db.Classes
                               where cl.name.Contains(keyword) || cl.Teacher.full_name.Contains(keyword)
                               select new
                               {
                                   id = cl.id,
                                   name = cl.name,
                                   start_day = cl.start_day,
                                   end_day = cl.end_day,
                                   price = cl.price,
                                   quantity = cl.quantity + "/" + cl.max_quantity,
                                   teacher_id = cl.Teacher.full_name,
                                   course_id = cl.Course.description
                               }).ToList<dynamic>();
                return classes;
            }
        }
    }
}

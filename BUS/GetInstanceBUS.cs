using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace BUS
{
    public class GetInstanceBUS
    {
        GetInstanceDAL getInstance = new GetInstanceDAL();

        public Course GetCourseFromId(int id)
        {
            return getInstance.GetCourseFromId(id);
        }

        public void GetAllLevel(ComboBox cbo)
        {
            cbo.DataSource = getInstance.GetAllLevel();
        }

        public void GetAllCategory(ComboBox cbo)
        {
            cbo.DataSource = getInstance.GetAllCategory();
        }

        public void GetAllAdmin(DataGridView data)
        {
            data.DataSource = getInstance.GetAllAdmin();
        }

        public void GetAllTeacher(DataGridView data, ComboBox cbo)
        {
            data.DataSource = getInstance.GetAllTeacher();
            cbo.DataSource = getInstance.GetAllTeacher();
        }

        public void GetAllTeacherByGender(DataGridView data, string gender)
        {
            if (gender == "Tất cả")
            {
                data.DataSource = getInstance.GetAllTeacher();
            }
            else
            {
                data.DataSource = getInstance.GetAllTeacherByGender(gender);
            }
        }

        public void GetScoreStudent(DataGridView data, int student_id)
        {
            data.DataSource = getInstance.GetScoreStudent(student_id);
        }

        public void GetAllStudent(DataGridView data)
        {
            data.DataSource = getInstance.GetAllStudent();
        }

        public void GetAllStudentByClass(DataGridView data, string className)
        {
            data.DataSource = getInstance.GetAllStudentByClass(className);
        }

        public void GetAllStudentByGenderAndClass(DataGridView data, string gender, string className)
        {
            if (gender == "Tất cả" && className == "Tất cả")
            {
                data.DataSource = getInstance.GetAllStudent();
            }
            else
            {
                data.DataSource = getInstance.GetAllStudentByGenderAndClass(gender, className);
            }
        }

        public void GetAllCourse(DataGridView data, ComboBox cbo)
        {
            data.DataSource = getInstance.GetAllCourse();
            cbo.DataSource = getInstance.GetAllCourse();
        }

        public void GetAllCourseByLevelAndCategory(DataGridView data, int level_id, int category_id)
        {
            if (level_id == 0 && category_id == 0)
            {
                data.DataSource = getInstance.GetAllCourse();
            }
            else
            {
                data.DataSource = getInstance.GetAllCourseByLevelAndCategory(level_id, category_id);
            }
        }

        public void GetAllClass(DataGridView data, ComboBox cbo, string status)
        {
            if (status == "Tất cả")
            {
                data.DataSource = getInstance.GetAllClass();
                cbo.DataSource = getInstance.GetAllClass();
            }
            else if (status == "Lớp còn trống")
            {
                data.DataSource = getInstance.GetAllAvailableClass();
                cbo.DataSource = getInstance.GetAllAvailableClass();
            }   
        }

        public void GetAllClassInCharge(DataGridView data, ComboBox cbo, int teacher_id)
        {
            data.DataSource = getInstance.GetAllClassInCharge(teacher_id);
            cbo.DataSource = getInstance.GetAllClassInCharge(teacher_id);
        }

        public void GetAllClassByLevelAndCategory(ComboBox cbo, int level_id, int age)
        {
            cbo.DataSource = getInstance.GetAllClassByLevelAndCategory(level_id, age);
        }

        public void GetAllEvent(DataGridView data, string className, int teacher_id)
        {
            data.DataSource = getInstance.GetAllEvent(className, teacher_id);
        }

        public void FindTeacherByNameOrPhone(DataGridView data, string keyword)
        {
            data.DataSource = getInstance.FindTeacherByNameOrPhone(keyword);
        }

        public void FindStudentByNameOrPhone(DataGridView data, string keyword)
        {
            data.DataSource = getInstance.FindStudentByNameOrPhone(keyword);
        }

        public void FindStudentByNameOrPhoneInClass(DataGridView data, string keyword, string className)
        {
            data.DataSource = getInstance.FindStudentByNameOrPhoneInClass(keyword, className);
        }

        public void FindCourseByName(DataGridView data, string keyword)
        {
            data.DataSource = getInstance.FindCourseByName(keyword);
        }

        public void FindClassByNameOrTeacher(DataGridView data, string keyword)
        {
            data.DataSource = getInstance.FindClassByNameOrTeacher(keyword);
        }

        public void FindClassInChargeByName(DataGridView data, string keyword, int teacher_id)
        {
            data.DataSource = getInstance.FindClassInChargeByName(keyword, teacher_id);
        }
    }
}

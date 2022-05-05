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

        public void GetAllStudent(DataGridView data)
        {
            data.DataSource = getInstance.GetAllStudent();
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
    }
}

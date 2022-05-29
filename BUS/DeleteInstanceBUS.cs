using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class DeleteInstanceBUS
    {
        DeleteInstanceDAL deleteInstance = new DeleteInstanceDAL();

        public void DeleteStudent(int student_id)
        {
            deleteInstance.DeleteStudent(student_id);
        }

        public void DeleteStudentFromClass(int student_id, int type)
        {
            deleteInstance.DeleteStudentFromClass(student_id, type);
        }

        public void DeleteStudentAccount(int student_id)
        {
            deleteInstance.DeleteStudentAccount(student_id);
        }

        public void DeleteStudentScore(int student_id)
        {
            deleteInstance.DeleteStudentScore(student_id);
        }


        public void DeleteTeacher(int id)
        {
            deleteInstance.DeleteTeacher(id);
        }

        public void DeleteTeacherAccount(int id)
        {
            deleteInstance.DeleteTeacherAccount(id);
        }

        public void DeleteTeacherInClass(int id)
        {
            deleteInstance.DeleteTeacherInClass(id);
        }

        public void DeleteCourse(int id)
        {
            deleteInstance.DeleteCourse(id);
        }

        public void DeleteClass(int id)
        {
            deleteInstance.DeleteClass(id);
        }

        public void DeleteClassWeekday(int id)
        {
            deleteInstance.DeleteClassWeekday(id);
        }
    }
}

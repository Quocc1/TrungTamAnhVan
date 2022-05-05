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

        public void DeleteStudent(int id)
        {
            deleteInstance.DeleteStudent(id);
        }

        public void DeleteStudentAccount(int id)
        {
            deleteInstance.DeleteStudentAccount(id);
        }

        public void DeleteTeacher(int id)
        {
            deleteInstance.DeleteTeacher(id);
        }

        public void DeleteTeacherAccount(int id)
        {
            deleteInstance.DeleteTeacherAccount(id);
        }

        public void DeleteCourse(int id)
        {
            deleteInstance.DeleteCourse(id);
        }

        public void DeleteClass(int id)
        {
            deleteInstance.DeleteClass(id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class UpdateInstanceBUS
    {
        UpdateInstanceDAL updateInstance = new UpdateInstanceDAL();

        public void UpdateTeacher(int teacher_id, string full_name, string gender, DateTime date_birth, string phone, string address, string description)
        {
            updateInstance.UpdateTeacher(teacher_id, full_name, gender, date_birth, phone, address, description);

        }

        public void UpdateTeacherInfo(int teacher_id, string phone, string address, string description)
        {
            updateInstance.UpdateTeacherInfo(teacher_id, phone, address, description);
        }

        public void UpdateStudent(int student_id, string full_name, string gender, DateTime date_birth, string phone, string address, int class_id, int level_id)
        {
            updateInstance.UpdateStudent(student_id, full_name, gender, date_birth, phone, address, level_id);
        }

        public void UpdateStudentInfo(int student_id, string phone, string address)
        {
            updateInstance.UpdateStudentInfo(student_id, phone, address);
        }


        public void UpdateStudentScore(int student_id, string listening_score, string speakning_score, string reading_score, string writing_score)
        {
            updateInstance.UpdateStudentScore(student_id, listening_score, speakning_score, reading_score, writing_score);
        }

        public void UpdateClassStudent(int student_id, int class_id)
        {
            updateInstance.UpdateClassStudent(student_id, class_id);
        }


        public void UpdateCourse(int id, int lessons, string description, string term, int level_id, int category_id)
        {
            updateInstance.UpdateCourse(id, lessons, description, term, level_id, category_id);
        }

        public void UpdateClass(int id, string name, DateTime start_day, DateTime end_day, int price, int teacher_id, int course_id)
        {
            updateInstance.UpdateClass(id, name, start_day, end_day, price, teacher_id, course_id);
        }
    }
}

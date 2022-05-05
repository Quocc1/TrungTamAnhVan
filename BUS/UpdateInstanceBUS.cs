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

        public void UpdateStudent(int id)
        {
            updateInstance.UpdateStudent(id);
        }

        public void UpdateCourse(int id, int lessons, string description, string term, int level_id, int category_id)
        {
            updateInstance.UpdateCourse(id, lessons, description, term, level_id, category_id);
        }
    }
}

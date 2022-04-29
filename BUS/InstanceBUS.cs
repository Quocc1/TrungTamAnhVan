using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace BUS
{
    public class InstanceBUS
    {
        InstanceDAL instanceDAL = new InstanceDAL();

        public void GetAllAdmin(DataGridView data)
        {
            data.DataSource = instanceDAL.GetAllAdmin();
        }

        public void GetAllTeacher(DataGridView data)
        {
            data.DataSource = instanceDAL.GetAllTeacher();
        }

        public void GetAllStudent(DataGridView data)
        {
            data.DataSource = instanceDAL.GetAllStudent();
        }
    }
}

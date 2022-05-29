using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace TrungTamAnhVan
{
    public partial class ucStudentHome : UserControl
    {
        static ucStudentHome _obj;

        GetInstanceBUS getInstance = new GetInstanceBUS();
        UpdateInstanceBUS updateInstance = new UpdateInstanceBUS();
        InformationBUS infoBUS = new InformationBUS();

        public static ucStudentHome Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ucStudentHome();
                }
                return _obj;
            }
        }

        public void Reload()
        {
            if (!DesignMode)
            {
                if (infoBUS.CheckStudentHaveClass(frmStudentMain.ID))
                {
                    pnSetClass.Visible = false;
                    pnHome.Visible = true;

                    List<string> list = new List<string>();
                    list = infoBUS.GetInfoStudent(frmStudentMain.ID);
                    getInstance.GetAllEvent(dataGridView1, list[6], 0);
                }
                else
                {
                    int level_id;
                    int age;
                    pnSetClass.Visible = true;
                    pnHome.Visible = false;

                    List<string> list = new List<string>();
                    list = infoBUS.GetInfoStudent(frmStudentMain.ID);
                    lbLevelValue.Text = list[5];
                    lbAgeValue.Text = (DateTime.Now.Year - Convert.ToDateTime(list[2]).Year).ToString();
                    age = Convert.ToInt32(lbAgeValue.Text);

                    if (lbLevelValue.Text == "A1")
                    {
                        level_id = 0;
                    }
                    else if (lbLevelValue.Text == "A2")
                    {
                        level_id = 1;
                    }
                    else if (lbLevelValue.Text == "B1")
                    {
                        level_id = 2;
                    }
                    else if (lbLevelValue.Text == "B2")
                    {
                        level_id = 3;
                    }
                    else if (lbLevelValue.Text == "C1")
                    {
                        level_id = 4;
                    }
                    else
                    {
                        level_id = 5;
                    }

                    cboClass.DisplayMember = "name";
                    cboClass.ValueMember = "id";
                    getInstance.GetAllClassByLevelAndCategory(cboClass, level_id, age);
                }
            }
        }

        public ucStudentHome()
        {
            _obj = this;
            InitializeComponent();
        }

        private void ucStudentHome_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                if (infoBUS.CheckStudentHaveClass(frmStudentMain.ID))
                {
                    pnSetClass.Visible = false;
                    pnHome.Visible = true;

                    List<string> list = new List<string>();
                    list = infoBUS.GetInfoStudent(frmStudentMain.ID);
                    getInstance.GetAllEvent(dataGridView1, list[6], 0);
                }
                else
                {
                    pnHome.Visible = false;
                    pnSetClass.Visible = true;

                    int level_id;
                    int age;
                    pnHome.Visible = false;
                    List<string> list = new List<string>();
                    list = infoBUS.GetInfoStudent(frmStudentMain.ID);
                    lbLevelValue.Text = list[5];
                    lbAgeValue.Text = (DateTime.Now.Year - Convert.ToDateTime(list[2]).Year).ToString();
                    age = Convert.ToInt32(lbAgeValue.Text);

                    if (lbLevelValue.Text == "A1")
                    {
                        level_id = 1;
                    }
                    else if (lbLevelValue.Text == "A2")
                    {
                        level_id = 2;
                    }
                    else if (lbLevelValue.Text == "B1")
                    {
                        level_id = 3;
                    }
                    else if (lbLevelValue.Text == "B2")
                    {
                        level_id = 4;
                    }
                    else if (lbLevelValue.Text == "C1")
                    {
                        level_id = 5;
                    }
                    else
                    {
                        level_id = 6;
                    }

                    cboClass.DisplayMember = "name";
                    cboClass.ValueMember = "id";
                    getInstance.GetAllClassByLevelAndCategory(cboClass, level_id, age);
                }
            }
        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                lbTimeValue.Text = infoBUS.GetTimeClass(cboClass.Text);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                updateInstance.UpdateClassStudent(frmStudentMain.ID, Convert.ToInt32(cboClass.SelectedValue));
            }
            Reload();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbDescription.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}

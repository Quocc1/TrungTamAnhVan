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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginBUS loginBUS = new LoginBUS();
            if (txtUsername.Text == "" || txtPassword.Text == "" || (rbtnStudent.Checked == false && rbtnTeacher.Checked == false && rbtnAdmin.Checked == false))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin!");
            }
            else
            {
                if (rbtnAdmin.Checked)
                {
                    string name = loginBUS.CheckLoginAdmin(txtUsername.Text, txtPassword.Text);
                    if (name != null)
                    {
                        frmAdminMain fMain = new frmAdminMain(name);
                        fMain.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                    }
                }
                else if (rbtnTeacher.Checked)
                {
                    string name = loginBUS.CheckLoginTeacher(txtUsername.Text, txtPassword.Text);
                    if (name != null)
                    {
                        frmTeacherMain fMain = new frmTeacherMain(name);
                        fMain.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                    }
                }
                else
                {
                    string name = loginBUS.CheckLoginStudent(txtUsername.Text, txtPassword.Text);
                    if (name != null)
                    {
                        frmStudentMain fMain = new frmStudentMain(name);
                        fMain.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                    }
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }
    }
}

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
            if (txtUsername.Text == "" || txtPassword.Text == "" || (rbtnStudent.Checked == false && rbtnTeacher.Checked == false && rbtnAdmin.Checked == false))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin!");
            }
            else
            {
                LoginBUS loginBUS = new LoginBUS();
                if (loginBUS.CheckLogin(txtUsername.Text, txtPassword.Text))
                {
                    frmMain fMain = new frmMain();
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
}

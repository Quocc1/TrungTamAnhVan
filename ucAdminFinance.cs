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
    public partial class ucAdminFinance : UserControl
    {
        static ucAdminFinance _obj;
        InformationBUS infoBUS = new InformationBUS();


        public static ucAdminFinance Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ucAdminFinance();
                }
                return _obj;
            }
        }

        public void Reload()
        {
            if (!DesignMode)
            {
                lbIncomeValue.Text = infoBUS.GetIncome().ToString();
                lbExpensesValue.Text = infoBUS.GetExpenses().ToString();

                foreach (var series in cFinance.Series)
                {
                    series.Points.Clear();
                }
                cFinance.Series["s1"].Points.AddXY("Lợi nhuận", lbIncomeValue.Text);
                cFinance.Series["s1"].Points.AddXY("Chi Phí", lbExpensesValue.Text);
                cFinance.Series["s1"].IsValueShownAsLabel = true;
            }
        }

        public ucAdminFinance()
        {
            _obj = this;
            InitializeComponent();

        }

        private void ucAdminFinance_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                lbIncomeValue.Text = infoBUS.GetIncome().ToString();
                lbExpensesValue.Text = infoBUS.GetExpenses().ToString();

                foreach (var series in cFinance.Series)
                {
                    series.Points.Clear();
                }
                cFinance.Series["s1"].Points.AddXY("Lợi nhuận", lbIncomeValue.Text);
                cFinance.Series["s1"].Points.AddXY("Chi Phí", lbExpensesValue.Text);
                cFinance.Series["s1"].IsValueShownAsLabel = true;
            }
        }
    }
}

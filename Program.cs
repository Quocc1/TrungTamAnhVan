using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrungTamAnhVan
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmAdminMain("Demo"));
            //Application.Run(new frmTeacherMain("Lê Văn A", 1));
            //Application.Run(new frmStudentMain("Nguyen Văn B", 2));
            Application.Run(new frmLogin());
        }
    }
}

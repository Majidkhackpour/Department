using System;
using System.Drawing;
using System.Security.Principal;
using System.Windows.Forms;
using Department.Users;
using DepartmentDal.Classes;
using Notification;
using Services;

namespace Department
{
    static class Program
    {
        private static bool isAdmin()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        [STAThread]
        static void Main()
        {
            //if (!isAdmin())
            //{
            //    MessageBox.Show("اجرا نمایید Run As Adminstrator لطفا برنامه را در حالت");
            //    return;
            //}

            DepartmentDal.Utilities.NEVER_EAT_POISON_Disable_CertificateValidation();
            var currentVersion = AccGlobalSettings.AppVersion.ParseToInt();

            ErrorHandler.AddHandler(currentVersion.ToString(), ENSource.Department, Application.StartupPath);


            clsNotification.Init(Color.Silver);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var logForm = new frmLogin();
            if (logForm.ShowDialog() != DialogResult.OK) return;



            Application.Run(new frmMain());
        }
    }
}

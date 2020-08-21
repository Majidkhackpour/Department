using System;
using System.Drawing;
using System.Security.Principal;
using System.Windows.Forms;
using Department.Users;
using EntityCache.Assistence;
using Notification;
using Services;
using Setting.Classes;

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

            ClsCache.Init();

            var currentVersion = AccGlobalSettings.AppVersion.ParseToInt();
            var dbVersion = clsGlobalSetting.ApplicationVersion.ParseToInt();

            ErrorHandler.AddHandler(currentVersion.ToString(), ENSource.Department, Application.StartupPath);


            if (dbVersion <= 0)
            {
                dbVersion = currentVersion;
                clsGlobalSetting.ApplicationVersion = dbVersion.ToString();
            }

            if (currentVersion < dbVersion)
            {
                MessageBox.Show($"نسخه فایل اجرایی {currentVersion} و نسخه بانک اطلاعاتی {dbVersion} می باشد. \r\n" +
                                $"لطفا جهت بروزرسانی نسخه اجرایی خود، با تیم پشتیبانی تماس حاصل فرمایید");
                return;
            }

            if (currentVersion > dbVersion)
                clsGlobalSetting.ApplicationVersion = currentVersion.ToString();
          

            clsNotification.Init(Color.Silver);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var logForm = new frmLogin();
            if (logForm.ShowDialog() != DialogResult.OK) return;



            Application.Run(new frmMain());
        }
    }
}

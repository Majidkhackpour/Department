using System;
using System.Drawing;
using System.Windows.Forms;
using EntityCache.Assistence;
using Notification;

namespace Department
{
    static class Program
    {
        [STAThread]
        static void Main()
        {

            ClsCache.Init();

            clsNotification.Init(Color.Silver);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}

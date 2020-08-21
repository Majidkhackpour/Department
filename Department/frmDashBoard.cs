using System;
using System.Windows.Forms;
using Department.Users;
using Services;

namespace Department
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void SetData()
        {
            try
            {
                lblUserName.Text = CurentUser.CurrentUser.Name;
                lblTypeName.Text = CurentUser.CurrentUser.TypeName;
                var date = Calendar.MiladiToShamsi(CurentUser.LastVorrod);
                var time = CurentUser.LastVorrod.Hour + ":" + CurentUser.LastVorrod.Minute;
                lblLastVorrod.Text = time + " " + date;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void frmDashBoard_Load(object sender, System.EventArgs e)
        {
            SetData();
        }
    }
}

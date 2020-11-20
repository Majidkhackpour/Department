using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DepartmentDal.Classes;
using MetroFramework.Forms;
using Notification;
using Services;

namespace Department.Users
{
    public partial class frmUserLogFilter : MetroForm
    {
        private async Task SetDataAsync()
        {
            try
            {
                await LoadUsersAsync();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private async Task LoadUsersAsync()
        {
            try
            {
                var list = await UserBussines.GetAllAsync();
                userBindingSource.DataSource = list.Where(q => q.Status).OrderBy(q => q.Name).ToList();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public frmUserLogFilter()
        {
            InitializeComponent();
        }

        private async void frmUserLogFilter_Load(object sender, EventArgs e) => await SetDataAsync();

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void frmUserLogFilter_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        if (!btnFinish.Focused && !btnCancel.Focused)
                            SendKeys.Send("{Tab}");
                        break;
                    case Keys.F5:
                        btnFinish.PerformClick();
                        break;
                    case Keys.Escape:
                        btnCancel.PerformClick();
                        break;
                }
            }
            catch (Exception exception)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(exception);
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUser.SelectedValue == null)
                {
                    frmNotification.PublicInfo.ShowMessage("کاربر نمی تواند خالی باشد");
                    cmbUser.Focus();
                    return;
                }


                var userGuid = (Guid)cmbUser.SelectedValue;

                var frm = new frmUserLog(userGuid);
                frm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}

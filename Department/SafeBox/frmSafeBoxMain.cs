using System;
using System.Windows.Forms;
using EntityCache.Bussines;
using MetroFramework.Forms;
using Notification;
using Services;

namespace Department.SafeBox
{
    public partial class frmSafeBoxMain : MetroForm
    {
        private SafeBoxBussines cls;

        private void SetData()
        {
            try
            {
                txtName.Text = cls?.Name;
                if (cls?.Type == EnSafeBox.Bank) rbtnBank.Checked = true;
                else rbtnSandouq.Checked = true;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public frmSafeBoxMain()
        {
            InitializeComponent();
            cls = new SafeBoxBussines();
        }
        public frmSafeBoxMain(Guid guid)
        {
            InitializeComponent();
            cls = SafeBoxBussines.Get(guid);
        }

        private void frmSafeBoxMain_Load(object sender, EventArgs e)
        {
            SetData();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtName, true);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtName);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmSafeBoxMain_KeyDown(object sender, KeyEventArgs e)
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

        private async void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                if (cls.Guid == Guid.Empty)
                    cls.Guid = Guid.NewGuid();

                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("عنوان نمی تواند خالی باشد");
                    txtName.Focus();
                    return;
                }
                

                cls.Name = txtName.Text.Trim();
                cls.Type = rbtnBank.Checked ? EnSafeBox.Bank : EnSafeBox.Sandouq;

                var res = await cls.SaveAsync();
                if (res.HasError)
                {
                    frmNotification.PublicInfo.ShowMessage(res.ErrorMessage);
                    return;
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exception)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(exception);
            }
        }
    }
}

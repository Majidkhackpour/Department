using System;
using System.Windows.Forms;
using DepartmentDal.Classes;
using MetroFramework.Forms;
using Notification;
using Services;

namespace Department.SmsPanels
{
    public partial class frmSmsPanelsMain : MetroForm
    {
        private SmsPanelBussines cls;

        private void SetData()
        {
            try
            {
                txtName.Text = cls?.Name;
                txtApi.Text = cls?.API;
                txtLineNumber.Text = cls?.Sender;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public frmSmsPanelsMain()
        {
            InitializeComponent();
            cls = new SmsPanelBussines();
        }
        public frmSmsPanelsMain(Guid guid)
        {
            InitializeComponent();
            cls = SmsPanelBussines.Get(guid);
        }
        private void frmSmsPanelsMain_Load(object sender, EventArgs e)
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

        private void frmSmsPanelsMain_KeyDown(object sender, KeyEventArgs e)
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

                if (string.IsNullOrWhiteSpace(txtLineNumber.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("شماره خط نمی تواند خالی باشد");
                    txtLineNumber.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtApi.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("پل ارتباطی نمی تواند خالی باشد");
                    txtApi.Focus();
                    return;
                }


                cls.Name = txtName.Text.Trim();
                cls.Sender = txtLineNumber.Text.Trim();
                cls.API = txtApi.Text.Trim();
                cls.IsCurrent = false;
                cls.Status = true;

                var res = await SmsPanelBussines.SaveAsync(cls);
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

        private void txtLineNumber_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtLineNumber, true);
        }

        private void txtLineNumber_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtLineNumber);
        }
    }
}

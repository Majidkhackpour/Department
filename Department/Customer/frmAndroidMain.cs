using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DepartmentDal.Classes;
using MetroFramework.Forms;
using Notification;
using Services;

namespace Department.Customer
{
    public partial class frmAndroidMain : MetroForm
    {
        private CustomerAndroidsBussines cls;
        private Guid CusGuid;

        private void SetData()
        {
            try
            {
                txtImei.Text = cls?.IMEI;
                txtName.Text = cls?.Name;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public frmAndroidMain(Guid cusGuid)
        {
            InitializeComponent();
            cls = new CustomerAndroidsBussines();
            CusGuid = cusGuid;
        }
        public frmAndroidMain(Guid guid, Guid cusGuid)
        {
            InitializeComponent();
            cls = CustomerAndroidsBussines.Get(guid);
            CusGuid = cusGuid;
        }

        private void frmAndroidMain_Load(object sender, EventArgs e) => SetData();
        private void txtName_Enter(object sender, EventArgs e) => txtSetter.Focus(txtName, true);
        private void txtImei_Enter(object sender, EventArgs e) => txtSetter.Focus(txtImei, true);
        private void txtImei_Leave(object sender, EventArgs e) => txtSetter.Follow(txtImei);
        private void txtName_Leave(object sender, EventArgs e) => txtSetter.Follow(txtName);
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void frmAndroidMain_KeyDown(object sender, KeyEventArgs e)
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
                if (cls.Guid == Guid.Empty) cls.Guid = Guid.NewGuid();

                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("عنوان نمی تواند خالی باشد");
                    txtName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtImei.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("IMEI نمی تواند خالی باشد");
                    txtImei.Focus();
                    return;
                }


                cls.Name = txtName.Text.Trim();
                cls.IMEI = txtImei.Text.Trim();
                cls.CustomerGuid = CusGuid;

                var res = await CustomerAndroidsBussines.SaveAsync(cls);
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

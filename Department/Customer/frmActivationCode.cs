using System;
using System.Windows.Forms;
using EntityCache.Bussines;
using MetroFramework.Forms;
using Notification;
using Services;

namespace Department.Customer
{
    public partial class frmActivationCode : MetroForm
    {
        private CustomerBussines cls;

        private void SetData()
        {
            try
            {
                lblName.Text = cls?.Name;
                lblActivationCode.Text = "";
                lblAppSerial.Text = cls?.AppSerial;
                lblExpDate.Text = cls?.ExpireDateSh;
                txtTerm.Text = "12";
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public frmActivationCode(CustomerBussines cus)
        {
            InitializeComponent();
            cls = cus;
        }

        private void frmActivationCode_Load(object sender, EventArgs e) => SetData();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmActivationCode_KeyDown(object sender, KeyEventArgs e)
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
                if (string.IsNullOrWhiteSpace(txtFanni.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("مشخصه فنی مشتری نمی تواند خالی باشد");
                    txtFanni.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(lblAppSerial.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("کد فعالسازی را تولید نکرده اید");
                    return;
                }


                cls.ExpireDate = DateTime.Now.AddMonths(txtTerm.Value.ToString().ParseToInt());

                var res = await cls.SaveAsync();
                if (res.HasError)
                {
                    frmNotification.PublicInfo.ShowMessage(res.ErrorMessage);
                    return;
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void txtFanni_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtFanni, true);
        }

        private void txtFanni_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtFanni);
        }

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFanni.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("مشخصه فنی مشتری نمی تواند خالی باشد");
                    txtFanni.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(lblAppSerial.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("کد فعالسازی را تولید نکرده اید");
                    return;
                }
                var code = SoftwareLock.GenerateActivationCodeServer.ActivationCode((int) txtTerm.Value, txtFanni.Text);
                lblActivationCode.Text = code;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}

using System;
using System.Windows.Forms;
using DepartmentDal.Classes;
using MetroFramework.Forms;
using Notification;
using Services;

namespace Department.Customer
{
    public partial class frmCustomerLogMain : MetroForm
    {
        private CustomerBussines cls;
        public frmCustomerLogMain(CustomerBussines cus)
        {
            InitializeComponent();
            cls = cus;
        }

        private void frmCustomerLogMain_Load(object sender, System.EventArgs e)
        {
            lblName.Text = cls?.Name;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmCustomerLogMain_KeyDown(object sender, KeyEventArgs e)
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
                if (string.IsNullOrWhiteSpace(txtDesc.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("توضیحات را وارد نمایید");
                    txtDesc.Focus();
                    return;
                }


                var log = new CustomerLogBussines
                {
                    Guid = Guid.NewGuid(),
                    CustomerGuid = cls.Guid,
                    Description = txtDesc.Text,
                    SideName =  "تلفن" ,
                    Status = true
                };

                var res_ = await CustomerLogBussines.SaveAsync(log);
                if (res_.HasError)
                {
                    frmNotification.PublicInfo.ShowMessage(res_.ErrorMessage);
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
    }
}

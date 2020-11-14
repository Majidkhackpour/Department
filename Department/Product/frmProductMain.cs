using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DepartmentDal.Classes;
using MetroFramework.Forms;
using Notification;
using Services;

namespace Department.Product
{
    public partial class frmProductMain : MetroForm
    {
        private ProductBussines cls;

        private async Task SetDataAsync()
        {
            try
            {
                txtName.Text = cls?.Name;
                txtCode.Text = cls?.Code;
                txtPrice.Text = cls?.Price.ToString("N0");
                txtBackUp.Text = cls?.BckUpPrice.ToString("N0");
                if (cls?.Guid == Guid.Empty)
                    txtCode.Text = await NextCodeAsync();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async Task<string> NextCodeAsync()
        {
            try
            {
                return await ProductBussines.NextCodeAsync();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return "";
            }
        }
        public frmProductMain()
        {
            InitializeComponent();
            cls = new ProductBussines();
        }
        public frmProductMain(Guid guid)
        {
            InitializeComponent();
            cls = ProductBussines.Get(guid);
            txtCode.Enabled = false;
        }

        private async void frmProductMain_Load(object sender, EventArgs e) => await SetDataAsync();


        #region TXtSetter
        private void txtCode_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtCode, true);
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtName, true);
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtPrice, true);
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtPrice);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtName);
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtCode);
        }
        private void txtBackUp_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtBackUp, true);
        }

        private void txtBackUp_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtBackUp);
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmProductMain_KeyDown(object sender, KeyEventArgs e)
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

                if (string.IsNullOrWhiteSpace(txtCode.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("کد محصول نمی تواند خالی باشد");
                    txtCode.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("عنوان نمی تواند خالی باشد");
                    txtName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("قیمت نمی تواند خالی باشد");
                    txtPrice.Focus();
                    return;
                }


                cls.Name = txtName.Text.Trim();
                cls.Code = txtCode.Text.Trim();
                cls.Price = txtPrice.Text.ParseToDecimal();
                cls.BckUpPrice = txtBackUp.Text.ParseToDecimal();
                cls.Status = true;

                var res = await ProductBussines.SaveAsync(cls);
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

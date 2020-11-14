using System;
using System.Linq;
using System.Windows.Forms;
using Department.Product;
using Department.Users;
using DepartmentDal.Classes;
using MetroFramework.Forms;
using Notification;
using Services;

namespace Department.Customer
{
    public partial class frmCustomerMain : MetroForm
    {
        private CustomerBussines cls;

        private void SetData()
        {
            try
            {
                txtName.Text = cls?.Name;
                txtDesc.Text = cls?.Description;
                txtCompanyName.Text = cls?.CompanyName;
                txtAppSerial.Text = cls?.AppSerial;

                txtTell1.Text = cls?.Tell1;
                txtTell2.Text = cls?.Tell2;
                txtTell3.Text = cls?.Tell3;
                txtTell4.Text = cls?.Tell4;

                txtNationalCode.Text = cls?.NationalCode;
                txtAddress.Text = cls?.Address;
                txtEmail.Text = cls?.Email;
                txtPostalCode.Text = cls?.PostalCode;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public frmCustomerMain()
        {
            InitializeComponent();
            cls = new CustomerBussines();
        }
        public frmCustomerMain(Guid guid, bool isShowMode)
        {
            InitializeComponent();
            cls = CustomerBussines.Get(guid);
            grp.Enabled = !isShowMode;
            btnFinish.Enabled = !isShowMode;
        }

        private void frmCustomerMain_Load(object sender, EventArgs e)
        {
            SetData();
        }

        #region TxtSetter
        private void txtName_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtName, true);
        }

        private void txtCompanyName_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtCompanyName, true);
        }

        private void txtNationalCode_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtNationalCode, true);
        }

        private void txtTell1_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtTell1, true);
        }

        private void txtTell2_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtTell2, true);
        }

        private void txtTell3_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtTell3, true);
        }

        private void txtTell4_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtTell4, true);
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtEmail, true);
        }

        private void txtPostalCode_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtPostalCode, true);
        }

        private void txtPostalCode_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtPostalCode);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtEmail);
        }

        private void txtTell3_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtTell3);
        }

        private void txtTell4_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtTell4);
        }

        private void txtTell2_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtTell2);
        }

        private void txtTell1_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtTell1);
        }

        private void txtNationalCode_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtNationalCode);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtName);
        }

        private void txtCompanyName_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtCompanyName);
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmCustomerMain_KeyDown(object sender, KeyEventArgs e)
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
                {
                    cls.Guid = Guid.NewGuid();
                    cls.CreateDate = DateTime.Now;
                    cls.UserGuid = CurentUser.CurrentUser.Guid;
                }

                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("عنوان نمی تواند خالی باشد");
                    txtName.Focus();
                    return;
                }


                cls.Name = txtName.Text.Trim();
                cls.CompanyName = txtCompanyName.Text;
                cls.NationalCode = txtNationalCode.Text;
                cls.AppSerial = txtAppSerial.Text;
                cls.Address = txtAddress.Text;
                cls.PostalCode = txtPostalCode.Text;
                cls.Tell1 = txtTell1.Text;
                cls.Tell2 = txtTell2.Text;
                cls.Tell3 = txtTell3.Text;
                cls.Tell4 = txtTell4.Text;
                cls.Email = txtEmail.Text;
                cls.Description = txtDesc.Text;
                cls.Status = true;


                var res = await CustomerBussines.SaveAsync(cls);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmSelectProduct(cls?.AppSerial);
                if (frm.ShowDialog() != DialogResult.OK) return;
                var list = frm.PrdList;
                var code = "";
                foreach (var item in list)
                    code += item.Code;
                txtAppSerial.Text = code;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}

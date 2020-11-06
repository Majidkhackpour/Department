using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using DepartmentDal.Classes;
using Notification;
using Services;

namespace Department.Users
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        if (txtPassword.Focused) btnFinish.PerformClick();
                        if (txtUserName.Focused)
                            SendKeys.Send("{Tab}");
                        break;
                    case Keys.Escape:
                        DialogResult = DialogResult.Cancel;
                        Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                var myCollection = new AutoCompleteStringCollection();
                var list = await UserBussines.GetAllAsync();
                foreach (var item in list)
                    myCollection.Add(item.UserName);
                txtUserName.AutoCompleteCustomSource = myCollection;


                
                if (!string.IsNullOrEmpty(txtUserName.Text)) txtPassword.Focus();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUserName.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("نام کاربری نمی تواند خالی باشد");
                    txtUserName.Focus();
                    txtUserName.SelectAll();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("کلمه عبور نمی تواند خالی باشد");
                    txtPassword.Focus();
                    txtPassword.SelectAll();
                    return;
                }

                var user = await UserBussines.GetAsync(txtUserName.Text.Trim());
                if (user == null)
                {
                    frmNotification.PublicInfo.ShowMessage($"کاربر با نام کاربری {txtUserName.Text} یافت نشد");
                    txtUserName.Focus();
                    txtUserName.SelectAll();
                    return;
                }

                var ue = new UTF8Encoding();
                var bytes = ue.GetBytes(txtPassword.Text.Trim());
                var md5 = new MD5CryptoServiceProvider();
                var hashBytes = md5.ComputeHash(bytes);
                var password = System.Text.RegularExpressions.Regex.Replace(BitConverter.ToString(hashBytes), "-", "")
                    .ToLower();
                if (password != user.Password)
                {
                    frmNotification.PublicInfo.ShowMessage("رمز عبور اشتباه است");
                    txtPassword.Focus();
                    txtPassword.SelectAll();
                    return;
                }

                CurentUser.CurrentUser = user;
                CurentUser.LastVorrod = DateTime.Now;


                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void lblRecoveryPassword_MouseEnter(object sender, EventArgs e)
        {
            lblRecoveryPassword.ForeColor = Color.Red;
        }

        private void lblRecoveryPassword_MouseLeave(object sender, EventArgs e)
        {
            lblRecoveryPassword.ForeColor = Color.Silver;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtPassword, true);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtPassword);
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtUserName, true);
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtUserName);
        }
    }
}

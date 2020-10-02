using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using DepartmentDal.Classes;
using MetroFramework.Forms;
using Notification;
using Services;

namespace Department.Users
{
    public partial class frmUserMain : MetroForm
    {
        private UserBussines cls;

        private void SetData()
        {
            try
            {
                FillCmb();
                txtName.Text = cls?.Name;
                txtUserName.Text = cls?.UserName;
                txtEmail.Text = cls?.Email;
                txtMobile.Text = cls?.Mobile;
                if (cls?.Guid == Guid.Empty) cmbAccessLevel.SelectedIndex = 0;
                else cmbAccessLevel.SelectedIndex = (int)cls?.Type;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void FillCmb()
        {
            try
            {
                cmbAccessLevel.Items.Add(EnUserType.Operator.GetDisplay());
                cmbAccessLevel.Items.Add(EnUserType.Visitor.GetDisplay());
                cmbAccessLevel.Items.Add(EnUserType.Manager.GetDisplay());
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public frmUserMain()
        {
            InitializeComponent();
            cls = new UserBussines();
        }
        public frmUserMain(Guid guid)
        {
            InitializeComponent();
            cls = UserBussines.Get(guid);
        }

        private void frmUserMain_Load(object sender, System.EventArgs e)
        {
            try
            {
                SetData();
                var myCollection = new AutoCompleteStringCollection();
                var list = UserBussines.GetAll();
                foreach (var item in list.ToList())
                    myCollection.Add(item.Email);
                txtEmail.AutoCompleteCustomSource = myCollection;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }

        }

        #region TxtSetter

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtName, true);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtName);
        }

        private void txtMobile_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtMobile, true);
        }

        private void txtMobile_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtMobile);
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtEmail, true);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtEmail);
        }

        private void txtPass2_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtPass2, true);
        }

        private void txtPass2_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtPass2);
        }

        private void txtPass1_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtPass1, true);
        }

        private void txtPass1_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtPass1);
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtUserName, true);
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtUserName);
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmUserMain_KeyDown(object sender, KeyEventArgs e)
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
                    frmNotification.PublicInfo.ShowMessage("نام و نام خانوادگی نمی تواند خالی باشد");
                    txtName.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtUserName.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("نام کاربری نمی تواند خالی باشد");
                    txtUserName.Focus();
                    return;
                }
                if (!await UserBussines.CheckUserNameAsync(cls.Guid, txtUserName.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("نام کاربری تکراری می باشد");
                    txtUserName.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPass1.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("کلمه عبور نمی تواند خالی باشد");
                    txtPass1.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPass2.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("تکرار کلمه عبور نمی تواند خالی باشد");
                    txtPass2.Focus();
                    return;
                }
                if (txtPass1.Text != txtPass2.Text)
                {
                    frmNotification.PublicInfo.ShowMessage("کلمه عبور با تکرار آن همخوانی ندارد");
                    txtPass1.Focus();
                    return;
                }

                if (!CheckPerssonValidation.CheckEmail(txtEmail.Text.Trim()))
                {
                    frmNotification.PublicInfo.ShowMessage("ایمیل وارد شده صحیح نمی باشد");
                    txtEmail.Focus();
                    return;
                }
                if (!CheckPerssonValidation.CheckMobile(txtMobile.Text.Trim()))
                {
                    frmNotification.PublicInfo.ShowMessage("شماره موبایل وارد شده صحیح نمی باشد");
                    txtMobile.Focus();
                    return;
                }


                cls.Name = txtName.Text.Trim();
                cls.UserName = txtUserName.Text.Trim();
                var ue = new UTF8Encoding();
                var bytes = ue.GetBytes(txtPass1.Text.Trim());
                var md5 = new MD5CryptoServiceProvider();
                var hashBytes = md5.ComputeHash(bytes);
                cls.Password = System.Text.RegularExpressions.Regex.Replace(BitConverter.ToString(hashBytes), "-", "")
                    .ToLower();
                cls.Email = txtEmail.Text.Trim();
                cls.Mobile = txtMobile.Text.Trim();
                cls.Type = (EnUserType)cmbAccessLevel.SelectedIndex;

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

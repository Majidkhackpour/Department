using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Department.Customer;
using DepartmentDal.Classes;
using MetroFramework.Forms;
using Notification;
using Services;

namespace Department.Pardakht
{
    public partial class frmPardakhtMain : MetroForm
    {
        private PardakhtBussines cls;
        private decimal fPrice;
        private List<SafeBoxBussines> safeList;
        private async Task SetDataAsync()
        {
            try
            {
                safeList = await SafeBoxBussines.GetAllAsync();
                FillBank();
                FillSandouq();
                lblDateNow.Text = cls?.DateSh;
                txtName.Text = cls?.PayerName;
                txtNaqdPrice.Text = cls?.NaqdPrice.ToString("N0");
                txtBankPrice.Text = cls?.BankPrice.ToString("N0");
                if (cls?.Guid != Guid.Empty)
                {
                    cmbBank.SelectedValue = cls?.BankSafeBoxGuid;
                    cmbNaqd.SelectedValue = cls?.NaqdSafeBoxGuid;
                }

                txtFishNo.Text = cls?.FishNo;
                txtCheckPrice.Text = cls?.Check.ToString("N0");
                txtCheckNo.Text = cls?.CheckNo;
                txtSarResid.Text = cls?.SarResid;
                txtBankName.Text = cls?.BankName;
                txtDesc.Text = cls?.Description;
                fPrice = cls?.TotalPrice ?? 0;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void FillSandouq()
        {
            try
            {
                var list = safeList.Where(q => q.Type == EnSafeBox.Sandouq).ToList();
                SandoqBindingSource.DataSource = list;
                if (list.Count <= 0) grp1.Enabled = false;
                else cmbNaqd.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void FillBank()
        {
            try
            {
                var list = safeList.Where(q => q.Type == EnSafeBox.Bank).ToList();
                BankBindingSource.DataSource = list;
                if (list.Count <= 0) grp2.Enabled = false;
                else cmbBank.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void SetTotal()
        {
            try
            {
                var total = (decimal)0;

                total += txtNaqdPrice.Text.ParseToDecimal();
                total += txtBankPrice.Text.ParseToDecimal();
                total += txtCheckPrice.Text.ParseToDecimal();

                lblTotalPrice.Text = total.ToString("N0");
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public frmPardakhtMain()
        {
            InitializeComponent();
            cls = new PardakhtBussines();
        }
        public frmPardakhtMain(Guid guid)
        {
            InitializeComponent();
            cls = PardakhtBussines.Get(guid);
        }

        private async void frmPardakhtMain_Load(object sender, EventArgs e) => await SetDataAsync();

        private void btnSearchOwner_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmSelectCustomer();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    cls.Payer = frm.Customer.Guid;
                    txtName.Text = frm.Customer.Name;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmPardakhtMain_KeyDown(object sender, KeyEventArgs e)
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
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("طرف حساب نمی تواند خالی باشد");
                    txtName.Focus();
                    return;
                }

                if (txtNaqdPrice.Text == "0" && txtBankPrice.Text == "0" && txtCheckPrice.Text == "0")
                {
                    frmNotification.PublicInfo.ShowMessage("لطفا یکی از فیلدهای مبلغ را وارد نمایید");
                    return;
                }

                if (cls.Guid == Guid.Empty) cls.Guid = Guid.NewGuid();
                cls.BankName = txtBankName.Text;
                cls.CheckNo = txtCheckNo.Text;
                cls.Description = txtDesc.Text;
                cls.FishNo = txtFishNo.Text;
                cls.SarResid = txtSarResid.Text;
                cls.NaqdPrice = txtNaqdPrice.Text.ParseToDecimal();

                if (cmbNaqd.SelectedValue != null)
                    cls.NaqdSafeBoxGuid = (Guid)cmbNaqd.SelectedValue;
                else cls.NaqdSafeBoxGuid = Guid.Empty;

                cls.BankPrice = txtBankPrice.Text.ParseToDecimal();

                if (cmbBank.SelectedValue != null)
                    cls.BankSafeBoxGuid = (Guid)cmbBank.SelectedValue;
                else cls.BankSafeBoxGuid = Guid.Empty;

                cls.Check = txtCheckPrice.Text.ParseToDecimal();

                var res = await PardakhtBussines.SaveAsync(cls);
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

        private void txtNaqdPrice_TextChanged(object sender, EventArgs e)
        {
            SetTotal();
            txtSetter.Three_Ziro(txtNaqdPrice);
        }

        private void txtBankPrice_TextChanged(object sender, EventArgs e)
        {
            SetTotal();
            txtSetter.Three_Ziro(txtBankPrice);
        }

        private void txtCheckPrice_TextChanged(object sender, EventArgs e)
        {
            SetTotal();
            txtSetter.Three_Ziro(txtCheckPrice);
        }

        private void txtNaqdPrice_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtNaqdPrice, true);
        }

        private void txtBankPrice_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtBankPrice, true);
        }

        private void txtFishNo_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtFishNo, true);
        }

        private void txtCheckPrice_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtCheckPrice, true);
        }

        private void txtCheckNo_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtCheckNo, true);
        }

        private void txtBankName_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtBankName, true);
        }

        private void txtBankName_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtBankName);
        }

        private void txtCheckNo_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtCheckNo);
        }

        private void txtCheckPrice_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtCheckPrice);
        }

        private void txtFishNo_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtFishNo);
        }

        private void txtBankPrice_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtBankPrice);
        }

        private void txtNaqdPrice_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtNaqdPrice);
        }
    }
}

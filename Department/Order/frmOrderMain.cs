using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Department.Customer;
using Department.Users;
using DepartmentDal.Classes;
using DevComponents.DotNetBar;
using MetroFramework.Forms;
using Notification;
using Services;

namespace Department.Order
{
    public partial class frmOrderMain : MetroForm
    {
        private OrderBussines _cls;
        private CustomerBussines _customer;
        private Guid _strGuid = Guid.Empty;

        private async Task SetDataAsync()
        {
            try
            {
                await SetProductsAsync();
                UpdateDets();
                SetCustomer(_cls.CustomerGuid);
                grpProduct.Enabled = false;
                lblConCode.Text = _cls?.ContractCode;
                lblDateNow.Text = _cls?.DateSh;
                lblTimeNow.Text = DateTime.Now.ToShortTimeString();
                txtClient.Value = _cls?.LearningCount ?? 0;

                if (_cls?.Guid == Guid.Empty)
                {
                    lblConCode.Text = await OrderBussines.NextCodeAsync();
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private async Task SetProductsAsync()
        {
            try
            {
                var list = await ProductBussines.GetAllAsync();
                fPanel.AutoScroll = true;
                for (var i = fPanel.Controls.Count - 1; i >= 0; i--)
                    fPanel.Controls[i].Dispose();
                foreach (var item in list)
                {
                    var btn = new ButtonX();
                    Controls.Add(btn);
                    btn.Size = new Size(190, 56);
                    btn.Name = item.Guid.ToString();
                    btn.Cursor = Cursors.Hand;
                    btn.Text = $"{item.Name} \r\n ({item.Price:N0})";
                    btn.ColorTable = eButtonColor.Flat;
                    btn.BackColor = Color.DarkSlateGray;
                    btn.TextColor = Color.White;
                    btn.Click += Btn_Click;
                    fPanel.Controls.Add(btn);
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void UpdateDets()
        {
            try
            {
                var sum = _cls?.DetList?.Sum(q => q.Total);
                lblTotalPrice.Text = (sum ?? 0).ToString("N0");
                orderBindingSource.DataSource = _cls?.DetList?.ToList();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            try
            {
                var guid = Guid.Parse(((ButtonX)sender).Name);

                if (_cls.DetList == null) _cls.DetList = new List<OrderDetailBussines>();

                var _prd = _cls.DetList.FirstOrDefault(q => q.PrdGuid == guid);
                if (_prd != null)
                {
                    frmNotification.PublicInfo.ShowMessage("این محصول در لیست محصولات موجود می باشد");
                    return;
                }

                var prd = ProductBussines.Get(guid);
                if (prd == null) return;

                var det = new OrderDetailBussines()
                {
                    Guid = Guid.NewGuid(),
                    Modified = DateTime.Now,
                    Status = true,
                    PrdGuid = prd.Guid,
                    Price = prd.Price,
                    Total = prd.Price,
                    Discount = 0
                };
                _cls.DetList.Add(det);

                UpdateDets();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        public frmOrderMain()
        {
            InitializeComponent();
            _cls = new OrderBussines();
        }
        public frmOrderMain(Guid guid)
        {
            InitializeComponent();
            _cls = OrderBussines.Get(guid);
        }
        private void SetCustomer(Guid guid)
        {
            try
            {
                _customer = CustomerBussines.Get(guid);
                txtCustName.Text = _customer?.Name;
                lblCompanyName.Text = _customer?.CompanyName;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void frmOrderMain_Load(object sender, EventArgs e) => await SetDataAsync();
        private void btnSearchCust_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmSelectCustomer();
                if (frm.ShowDialog() == DialogResult.OK) SetCustomer(frm.Customer.Guid);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void mnuEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0 || DGrid.CurrentRow == null) return;

                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;

                var prd = _cls?.DetList?.FirstOrDefault(q => q.Guid == guid);
                if (prd == null) return;

                _strGuid = prd.PrdGuid;
                txtPrdName.Text = prd.ProductName;
                txtDiscount.Text = prd.Discount.ToString("N0");
                txtSum.Text = prd.Price.ToString("N0");
                txtTotal.Text = prd.Total.ToString("N0");

                mnuEdit.Enabled = false;
                mnuDelete.Enabled = false;
                grpProduct.Enabled = true;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (_strGuid == Guid.Empty) ClearPrdBox();

                var prd = _cls?.DetList?.FirstOrDefault(q => q.PrdGuid == _strGuid);
                if (prd == null) ClearPrdBox();

                prd.Price = txtSum.Text.ParseToDecimal();
                prd.Discount = txtDiscount.Text.ParseToDecimal();
                prd.Total = txtTotal.Text.ParseToDecimal();
                UpdateDets();
                ClearPrdBox();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void ClearPrdBox()
        {
            try
            {
                mnuEdit.Enabled = true;
                mnuDelete.Enabled = true;
                grpProduct.Enabled = false;

                txtPrdName.Text = "";
                txtDiscount.Text = "";
                txtSum.Text = "";
                txtTotal.Text = "";

                _strGuid = Guid.Empty;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void btnEnseraf_Click(object sender, EventArgs e)
        {
            try
            {
                ClearPrdBox();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void txtSum_TextChanged(object sender, EventArgs e)
        {
            txtSetter.Three_Ziro(txtSum);
            SetPrice();
            UpdateDets();
        }
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            txtSetter.Three_Ziro(txtDiscount);
            SetPrice();
            UpdateDets();
        }
        private void SetPrice()
        {
            try
            {
                var total = txtTotal.Text.ParseToDecimal();
                var sum = txtSum.Text.ParseToDecimal();
                var dis = txtDiscount.Text.ParseToDecimal();

                txtTotal.Text = (sum - dis).ToString("N0");
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void DGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DGrid.Rows[e.RowIndex].Cells["dgRadif"].Value = e.RowIndex + 1;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void frmOrderMain_KeyDown(object sender, KeyEventArgs e)
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
                if (_cls.Guid == Guid.Empty)
                {
                    _cls.Guid = Guid.NewGuid();
                    _cls.UserGuid = CurentUser.CurrentUser.Guid;
                    _cls.Status = true;
                }

                if (_customer == null)
                {
                    frmNotification.PublicInfo.ShowMessage("خریدار نمی تواند خالی باشد");
                    btnSearchCust.Focus();
                    return;
                }

                if (_cls.DetList == null || _cls.DetList.Count <= 0)
                {
                    frmNotification.PublicInfo.ShowMessage("کالایی انتخاب نشده است");
                    return;
                }

                _cls.ContractCode = lblConCode.Text.Trim();
                _cls.Sum = _cls.DetList.Sum(q => q.Price);
                _cls.Discount = _cls.DetList.Sum(q => q.Discount);
                _cls.Total = lblTotalPrice.Text.ParseToDecimal();
                _cls.LearningCount = (int)txtClient.Value;
                _cls.CustomerGuid = _customer.Guid;

                foreach (var item in _cls.DetList) item.OrderGuid = _cls.Guid;

                var res = await OrderBussines.SaveAsync(_cls);
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

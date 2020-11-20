using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Department.Users;
using DepartmentDal.Classes;
using MetroFramework.Forms;
using Notification;
using Services;

namespace Department.Customer
{
    public partial class frmShowCustomers : MetroForm
    {
        private bool _st = true;
        private List<CustomerBussines> list;
        private void Search(string search, bool status)
        {
            try
            {
                var res = list;
                if (res == null) return;
                if (string.IsNullOrEmpty(search)) search = "";
                var searchItems = search.SplitString();
                if (searchItems?.Count > 0)
                    foreach (var item in searchItems)
                    {
                        if (!string.IsNullOrEmpty(item) && item.Trim() != "")
                        {
                            res = list.Where(x => x.Name.ToLower().Contains(item.ToLower()) ||
                                                  x.CompanyName.ToLower().Contains(item.ToLower()) ||
                                                  x.Tell1.ToLower().Contains(item.ToLower()) ||
                                                  x.Tell2.ToLower().Contains(item.ToLower()) ||
                                                  x.AppSerial.ToLower().Contains(item.ToLower()) ||
                                                  x.ExpireDateSh.ToLower().Contains(item.ToLower()) ||
                                                  x.UserName.ToLower().Contains(item.ToLower()))
                                ?.ToList();
                        }
                    }


                res = res?.OrderBy(o => o.Name).ToList();
                Invoke(new MethodInvoker(() =>
                {
                    if (cmbUsers.SelectedValue != null && (Guid)cmbUsers.SelectedValue != Guid.Empty)
                        res = res?.Where(q => q.UserGuid == (Guid)cmbUsers.SelectedValue).ToList();
                    cusBindingSource.DataSource =
                        res?.Where(q => q.Status == status).ToSortableBindingList();
                }));

            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private async Task LoadDataAsync(bool status, string search = "")
        {
            try
            {
                lblAccount.Text = lblAccount_.Text = "";
                if (InvokeRequired)
                    Invoke(new MethodInvoker(() =>
                    {
                        if (cmbUsers.SelectedValue == null) return;
                    }));
                else if (cmbUsers.SelectedValue == null) return;
                list = await CustomerBussines.GetAllAsync();
                Search(search, status);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private async Task FillCmbAsync()
        {
            try
            {

                var list = await UserBussines.GetAllAsync();
                list.Add(new UserBussines()
                {
                    Guid = Guid.Empty,
                    Name = "[کلیه کاربران]"
                });
                userBindingSource.DataSource = list.OrderBy(q => q.Name);
                cmbUsers.SelectedValue = CurentUser.CurrentUser.Guid;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public bool ST
        {
            get => _st;
            set
            {
                _st = value;
                if (_st)
                {
                    mnuChangeStatus.Text = "مشاهده غیرفعال ها";
                    Task.Run(() => LoadDataAsync(ST, txtSearch.Text));
                    mnuDelete.Text = "حذف مشتری جاری";
                }
                else
                {
                    mnuChangeStatus.Text = "مشاهده فعال ها";
                    Task.Run(() => LoadDataAsync(ST, txtSearch.Text));
                    mnuDelete.Text = "تغییر وضعیت به فعال";
                }
            }
        }
        public frmShowCustomers()
        {
            InitializeComponent();
            if (CurentUser.CurrentUser.Type == EnUserType.Manager)
            {
                cmbUsers.Visible = true;
                lblUsers.Visible = true;
                DGrid.Columns[dgUserName.Index].Visible = true;
            }
            else
            {
                cmbUsers.Visible = false;
                lblUsers.Visible = false;
                DGrid.Columns[dgUserName.Index].Visible = false;
            }
        }

        private async void frmShowCustomers_Load(object sender, EventArgs e)
        {
            await FillCmbAsync();
        }

        private void DGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DGrid.Rows[e.RowIndex].Cells["Radif"].Value = e.RowIndex + 1;
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                await LoadDataAsync(ST, txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void frmShowCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Insert:
                        mnuIns.PerformClick();
                        break;
                    case Keys.F7:
                        mnuEdit.PerformClick();
                        break;
                    case Keys.Delete:
                        mnuDelete.PerformClick();
                        break;
                    case Keys.F:
                        if (e.Control) txtSearch.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                await LoadDataAsync(ST, txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void mnuDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;
                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;
                if (ST)
                {
                    if (MessageBox.Show(
                            $@"آیا از حذف {DGrid[dgName.Index, DGrid.CurrentRow.Index].Value} اطمینان دارید؟", "حذف",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.No) return;
                    var prd = await CustomerBussines.GetAsync(guid);
                    prd.Status = false;
                    var res = await CustomerBussines.SaveAsync(prd);
                    if (res.HasError)
                    {
                        frmNotification.PublicInfo.ShowMessage(res.ErrorMessage);
                        return;
                    }
                }
                else
                {
                    if (MessageBox.Show(
                            $@"آیا از فعال کردن {DGrid[dgName.Index, DGrid.CurrentRow.Index].Value} اطمینان دارید؟", "حذف",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.No) return;
                    var prd = await CustomerBussines.GetAsync(guid);
                    prd.Status = true;
                    var res = await CustomerBussines.SaveAsync(prd);
                    if (res.HasError)
                    {
                        frmNotification.PublicInfo.ShowMessage(res.ErrorMessage);
                        return;
                    }
                }

                await LoadDataAsync(ST, txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void mnuIns_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmCustomerMain();
                if (frm.ShowDialog() == DialogResult.OK)
                    await LoadDataAsync(ST, txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void mnuEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;
                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;
                var frm = new frmCustomerMain(guid, false);
                if (frm.ShowDialog() == DialogResult.OK)
                    await LoadDataAsync(ST, txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void mnuView_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;
                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;
                var frm = new frmCustomerMain(guid, true);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void mnuChangeStatus_Click(object sender, EventArgs e)
        {
            ST = !ST;
        }

        private async void mnuActivationCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;
                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;
                var cus = CustomerBussines.Get(guid);
                if (cus == null) return;
                var frm = new frmActivationCode(cus);
                frm.ShowDialog();
                await LoadDataAsync(ST, txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void mnuLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;
                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;
                var frm = new frmCustomerLog(guid);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void mnuInsLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;
                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;
                var cus = CustomerBussines.Get(guid);
                if (cus == null) return;
                var frm = new frmCustomerLogMain(cus);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void DGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;
                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;
                var cus = CustomerBussines.Get(guid);
                if (cus == null) return;
                lblAccount.Text = Math.Abs(cus.Account).ToString("N0");
                if (cus.Account == 0)
                {
                    lblAccount_.Text = "بی حساب";
                    lblAccount_.ForeColor = Color.Black;
                }
                else if (cus.Account > 0)
                {
                    lblAccount_.Text = "بدهکار";
                    lblAccount_.ForeColor = Color.Red;
                }
                else if (cus.Account < 0)
                {
                    lblAccount_.Text = "بستانکار";
                    lblAccount_.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}

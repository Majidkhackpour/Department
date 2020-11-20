using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Department.Users;
using DepartmentDal.Classes;
using MetroFramework.Forms;
using Notification;
using Services;

namespace Department.Order
{
    public partial class frmShowOrders : MetroForm
    {
        private List<OrderBussines> list;
        private void Search(string search)
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
                            res = list.Where(x => x.ContractCode.ToLower().Contains(item.ToLower())||
                                                  x.CustomerName.ToLower().Contains(item.ToLower())||
                                                  x.Sum.ToString().ToLower().Contains(item.ToLower())||
                                                  x.Discount.ToString().ToLower().Contains(item.ToLower())||
                                                  x.Total.ToString().ToLower().Contains(item.ToLower()))
                                ?.ToList();
                        }
                    }

                res = res?.OrderByDescending(o => o.Modified).ToList();
                Invoke(new MethodInvoker(() =>
                {
                    if (cmbUsers.SelectedValue != null && (Guid)cmbUsers.SelectedValue != Guid.Empty)
                        res = res?.Where(q => q.UserGuid == (Guid)cmbUsers.SelectedValue).ToList();
                    orderBindingSource.DataSource =
                        res?.ToSortableBindingList();
                }));
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private async Task LoadDataAsync(string search = "")
        {
            try
            {
                if (InvokeRequired)
                    Invoke(new MethodInvoker(() =>
                    {
                        if (cmbUsers.SelectedValue == null) return;
                    }));
                else if (cmbUsers.SelectedValue == null) return;
                list = await OrderBussines.GetAllAsync();
                Search(search);
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
        public frmShowOrders()
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

        private async void frmShowOrders_Load(object sender, EventArgs e) => await FillCmbAsync();

        private void DGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DGrid.Rows[e.RowIndex].Cells["dgRadif"].Value = e.RowIndex + 1;
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                await LoadDataAsync(txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void frmShowOrders_KeyDown(object sender, KeyEventArgs e)
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

        private async void mnuIns_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmOrderMain();
                if (frm.ShowDialog() == DialogResult.OK) await LoadDataAsync();
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
                var frm = new frmOrderMain(guid);
                if (frm.ShowDialog() == DialogResult.OK)
                    await LoadDataAsync(txtSearch.Text);
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

                if (MessageBox.Show(
                        $"آیا از حذف قرارداد {DGrid[dgCode.Index, DGrid.CurrentRow.Index].Value} اطمینان دارید؟", "حذف",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                    DialogResult.Yes) return;

                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;
                var reception = await OrderBussines.GetAsync(guid);
                reception.Status = false;
                var res = await OrderBussines.RemoveAsync(reception);
                if (res.HasError)
                {
                    frmNotification.PublicInfo.ShowMessage(res.ErrorMessage);
                    return;
                }

                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void DGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;

                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;
                var reception = await OrderBussines.GetAsync(guid);

                if (reception == null) return;

                lblClient.Text = reception.LearningCount.ToString();
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
                await LoadDataAsync(txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}

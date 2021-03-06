﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Department.Users;
using DepartmentDal.Classes;
using MetroFramework.Forms;
using Services;

namespace Department.SmsPanels
{
    public partial class frmSmsLog : MetroForm
    {
        private List<SmsLogBussines> list;
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
                            res = list.Where(x => x.Sender.ToLower().Contains(item.ToLower()) ||
                                                  x.Reciver.ToLower().Contains(item.ToLower()) ||
                                                  x.Cost.ToString().ToLower().Contains(item.ToLower()) ||
                                                  x.StatusText.ToLower().Contains(item.ToLower()) ||
                                                  x.Message.ToLower().Contains(item.ToLower()))
                                ?.ToList();
                        }
                    }


                res = res?.OrderByDescending(o => o.Date).ToList();
                Invoke(new MethodInvoker(() =>
                {
                    if (cmbUsers.SelectedValue != null && (Guid)cmbUsers.SelectedValue != Guid.Empty)
                        res = res?.Where(q => q.UserGuid == (Guid)cmbUsers.SelectedValue).ToList();
                    logBindingSource.DataSource =
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
                txtMessage.Text = "";
                if (cmbUsers.SelectedValue == null) return;
                list = await SmsLogBussines.GetAllAsync();
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

        private SmsPanelBussines cls;
        public frmSmsLog(SmsPanelBussines pnl)
        {
            InitializeComponent();
            cls = pnl;
        }

        private async void frmSmsLog_Load(object sender, EventArgs e)
        {
           await FillCmbAsync();
           await LoadDataAsync();
        }

        private void DGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DGrid.Rows[e.RowIndex].Cells["Radif"].Value = e.RowIndex + 1;
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

        private void frmSmsLog_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.F:
                        if (e.Control) txtSearch.Focus();
                        break;
                    case Keys.Escape:
                        Close();
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
                await LoadDataAsync(txtSearch.Text);
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
                var log = SmsLogBussines.Get(guid);
                if (log == null) return;

                txtMessage.Text = log.Message;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void UpdateStatus(List<string> lstMessageId)
        {
            try
            {
                var api = new Sms.Api(cls.API.Trim());
                var resList = api.Status(lstMessageId);

                foreach (var item in resList)
                {
                    var log = await SmsLogBussines.GetAsync(item.Messageid);
                    if (log == null) continue;
                    log.StatusText = item.Statustext;
                    await SmsLogBussines.SaveAsync(log);
                    await LoadDataAsync();
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void mnuUpSingle_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;

                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;
                var log = SmsLogBussines.Get(guid);
                if (log == null) return;

                var list = new List<string> { log.MessageId.ToString() };

                UpdateStatus(list);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void mnuUpAll_Click(object sender, EventArgs e)
        {
            try
            {
                var list = new List<string>() ;
                var lst = await SmsLogBussines.GetAllAsync();
                list = lst.Select(q => q.MessageId.ToString()).ToList();
                UpdateStatus(list);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}

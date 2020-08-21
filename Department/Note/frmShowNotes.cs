using System;
using System.Linq;
using System.Windows.Forms;
using Department.Users;
using EntityCache.Bussines;
using MetroFramework.Forms;
using Notification;
using Services;

namespace Department.Note
{
    public partial class frmShowNotes : MetroForm
    {
        private void FillCmb()
        {
            try
            {

                var list = UsersBussines.GetAll().ToList();
                list.Add(new UsersBussines()
                {
                    Guid = Guid.Empty,
                    Name = "[کلیه کاربران]"
                });
                userBindingSource.DataSource = list.OrderBy(q => q.Name);
                cmbUsers.SelectedValue = CurentUser.CurrentUser.Guid;


                cmbPriority.Items.Add(EnNotePriority.All.GetDisplay());
                cmbPriority.Items.Add(EnNotePriority.Mamoli.GetDisplay());
                cmbPriority.Items.Add(EnNotePriority.Mohem.GetDisplay());
                cmbPriority.Items.Add(EnNotePriority.Zarori.GetDisplay());
                cmbPriority.SelectedIndex = 0;


                cmbStatus.Items.Add(EnNoteStatus.All.GetDisplay());
                cmbStatus.Items.Add(EnNoteStatus.Unread.GetDisplay());
                cmbStatus.Items.Add(EnNoteStatus.Read.GetDisplay());
                cmbStatus.Items.Add(EnNoteStatus.Deleted.GetDisplay());
                cmbStatus.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public frmShowNotes()
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

        private void LoadData(string search = "")
        {
            try
            {
                if (cmbUsers.SelectedValue == null) return;
                var list = NoteBussines.GetAll(search, (Guid)cmbUsers.SelectedValue,
                    (EnNoteStatus)cmbStatus.SelectedIndex, (EnNotePriority)cmbPriority.SelectedIndex);
                noteBindingSource.DataSource = list.ToList();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void frmShowNotes_Load(object sender, EventArgs e)
        {
            FillCmb();
            LoadData();
        }

        private void DGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DGrid.Rows[e.RowIndex].Cells["Radif"].Value = e.RowIndex + 1;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoadData(txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void frmShowNotes_KeyDown(object sender, KeyEventArgs e)
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

        private void mnuIns_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmNoteMain();
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadData();
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
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;
                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;
                var frm = new frmNoteMain(guid);
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadData(txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadData(txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadData(txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadData(txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void mnuRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;
                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;
                var note = await NoteBussines.GetAsync(guid);
                if (note == null) return;
                if (note.NoteStatus == EnNoteStatus.Read)
                {
                    frmNotification.PublicInfo.ShowMessage("یادداشت انتخاب شده درحال حاظر در وضعیت خوانده شده می باشد");
                    return;
                }

                if (MessageBox.Show(
                        $@"آیا از اعمال تغییرات اطمینان دارید؟", "حذف",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.No) return;
                note.NoteStatus = EnNoteStatus.Read;
                var res = await note.SaveAsync();
                if (res.HasError)
                {
                    frmNotification.PublicInfo.ShowMessage(res.ErrorMessage);
                    return;
                }
                LoadData(txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void mnuUnread_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;
                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;
                var note = await NoteBussines.GetAsync(guid);
                if (note == null) return;
                if (note.NoteStatus == EnNoteStatus.Unread)
                {
                    frmNotification.PublicInfo.ShowMessage("یادداشت انتخاب شده درحال حاظر در وضعیت خوانده نشده می باشد");
                    return;
                }

                if (MessageBox.Show(
                        $@"آیا از اعمال تغییرات اطمینان دارید؟", "حذف",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.No) return;
                note.NoteStatus = EnNoteStatus.Unread;
                var res = await note.SaveAsync();
                if (res.HasError)
                {
                    frmNotification.PublicInfo.ShowMessage(res.ErrorMessage);
                    return;
                }

                LoadData(txtSearch.Text);
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
                var note = await NoteBussines.GetAsync(guid);
                if (note == null) return;
                if (note.NoteStatus == EnNoteStatus.Deleted)
                {
                    frmNotification.PublicInfo.ShowMessage("یادداشت انتخاب شده درحال حاظر در وضعیت حذف شده می باشد");
                    return;
                }

                if (MessageBox.Show(
                        $@"آیا از اعمال تغییرات اطمینان دارید؟", "حذف",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.No) return;
                note.NoteStatus = EnNoteStatus.Deleted;
                var res = await note.SaveAsync();
                if (res.HasError)
                {
                    frmNotification.PublicInfo.ShowMessage(res.ErrorMessage);
                    return;
                }

                LoadData(txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}

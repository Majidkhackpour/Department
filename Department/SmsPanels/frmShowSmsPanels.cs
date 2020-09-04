using System;
using System.Linq;
using System.Windows.Forms;
using EntityCache.Bussines;
using MetroFramework.Forms;
using Notification;
using Services;

namespace Department.SmsPanels
{
    public partial class frmShowSmsPanels : MetroForm
    {
        private bool _st = true;
        private void LoadData(bool status, string search = "")
        {
            try
            {
                var list = SmsPanelBussines.GetAll(search).Where(q => q.Status == status).ToList();
                panelBindingSource.DataSource = list.ToSortableBindingList();
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
                    LoadData(ST, txtSearch.Text);
                    mnuDelete.Text = "حذف پنل جاری";
                }
                else
                {
                    mnuChangeStatus.Text = "مشاهده فعال ها";
                    LoadData(ST, txtSearch.Text);
                    mnuDelete.Text = "تغییر وضعیت به فعال";
                }
            }
        }
        public frmShowSmsPanels()
        {
            InitializeComponent();
        }

        private void frmShowSmsPanels_Load(object sender, EventArgs e)
        {
            LoadData(ST);
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;
                if (!ST)
                {
                    frmNotification.PublicInfo.ShowMessage(
                        "شما مجاز به ویرایش داده حذف شده نمی باشید \r\n برای این منظور، ابتدا فیلد موردنظر را از حالت حذف شده به فعال، تغییر وضعیت دهید");
                    return;
                }
                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;
                var frm = new frmSmsPanelsMain(guid);
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadData(ST, txtSearch.Text);
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

        private void DGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DGrid.Rows[e.RowIndex].Cells["Radif"].Value = e.RowIndex + 1;
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
                    var prd = await SmsPanelBussines.GetAsync(guid);
                    var res = await prd.ChangeStatusAsync(false);
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
                    var prd = await SmsPanelBussines.GetAsync(guid);
                    var res = await prd.ChangeStatusAsync(true);
                    if (res.HasError)
                    {
                        frmNotification.PublicInfo.ShowMessage(res.ErrorMessage);
                        return;
                    }
                }

                LoadData(ST, txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoadData(ST, txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void frmShowSmsPanels_KeyDown(object sender, KeyEventArgs e)
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
                    case Keys.S:
                        if (e.Control) ST = !ST;
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

        private void DGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                txtSearch.Focus();
                txtSearch.Text = e.KeyChar.ToString();
                txtSearch.SelectionStart = 9999;
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
                var frm = new frmSmsPanelsMain();
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadData(ST);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void mnuDefault_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;
                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;

                Setting.Classes.clsGlobalSetting.DefaultPanelGuid = guid.ToString();

                frmNotification.PublicInfo.ShowMessage("پنل پیش فرض با موفقیت تغییر کرد");
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void mnuPanelInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGrid.RowCount <= 0) return;
                if (DGrid.CurrentRow == null) return;
                var guid = (Guid)DGrid[dgGuid.Index, DGrid.CurrentRow.Index].Value;
                var panel = SmsPanelBussines.Get(guid);
                if (panel == null) return;

                var api = new Sms.Api(panel.Api.Trim());
                var res = api.AccountInfo();

                MessageBox.Show($"مانده حساب پنل {panel.Name} {res.RemainCredit} ریال می باشد");
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
                var panel = SmsPanelBussines.Get(guid);
                if (panel == null) return;

                var frm = new frmSmsLog(panel);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}

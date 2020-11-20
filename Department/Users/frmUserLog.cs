using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DepartmentDal.Classes;
using MetroFramework.Forms;
using Services;

namespace Department.Users
{
    public partial class frmUserLog : MetroForm
    {
        private Guid userGuid;
        private IEnumerable<UserLogBussines> list;
        private async Task LoadDataAsync()
        {
            try
            {
                list = await UserLogBussines.GetAllAsync(userGuid);
                logBindingSource.DataSource = list.OrderByDescending(q => q.Date).ToSortableBindingList();
                lblUserName.Text = UserBussines.Get(userGuid)?.Name ?? "";
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void frmUserLog_Load(object sender, EventArgs e) => await LoadDataAsync();

        private void frmUserLog_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape) Close();
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

        public frmUserLog(Guid _userGuid)
        {
            InitializeComponent();
            userGuid = _userGuid;
        }
    }
}

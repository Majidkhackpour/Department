using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DepartmentDal.Classes;
using MetroFramework.Forms;
using Services;

namespace Department.Customer
{
    public partial class frmCustomerLog : MetroForm
    {
        private Guid CusGuid;
        private async Task LoadDataAsync()
        {
            try
            {
                var list = await CustomerLogBussines.GetAllAsync(CusGuid);
                logBindingSource.DataSource = list.OrderByDescending(q => q.Date).ToList();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public frmCustomerLog(Guid cusGuid)
        {
            InitializeComponent();
            CusGuid = cusGuid;
        }

        private async void frmCustomerLog_Load(object sender, EventArgs e) => await LoadDataAsync();

        private void DGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DGrid.Rows[e.RowIndex].Cells["Radif"].Value = e.RowIndex + 1;
        }

        private void frmCustomerLog_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape: Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}

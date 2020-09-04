using System;
using System.Linq;
using System.Windows.Forms;
using EntityCache.Bussines;
using MetroFramework.Forms;
using Services;

namespace Department.Customer
{
    public partial class frmCustomerLog : MetroForm
    {
        private Guid CusGuid;
        private void LoadData()
        {
            try
            {
                var list = CustomerLogBussines.GetAll(CusGuid).OrderByDescending(q => q.Date);
                logBindingSource.DataSource = list.ToList();
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

        private void frmCustomerLog_Load(object sender, EventArgs e)
        {
            LoadData();
        }

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

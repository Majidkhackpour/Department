using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Department.Users;
using DepartmentDal.Classes;
using Services;

namespace Department
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }

        private async Task SetLabelsAsync()
        {
            try
            {
                var cust = await CustomerBussines.GetAllAsync();
                var order = await OrderBussines.GetAllAsync();
                var rece = await ReceptionBussines.GetAllAsync();
                var pardakht = await PardakhtBussines.GetAllAsync();

                var currentUser = CurentUser.CurrentUser;

                Invoke(new MethodInvoker(() =>
                {
                    lblAllCustomers.Text = lblMyCustomers.Text = "";
                    lblAllOrders.Text = lblMyOrders.Text = "";
                    lblAllPardakht.Text = lblMyPardakht.Text = lblSumPardakht.Text = "";
                    lblAllReceptions.Text = lblMyReceptions.Text = lblSumReception.Text = "";

                    lblAllCustomers.Text = (cust?.Count ?? 0).ToString();
                    lblMyCustomers.Text = (cust?.Where(q => q.UserGuid == currentUser.Guid)?.Count() ?? 0).ToString();

                    lblAllOrders.Text = (order?.Count ?? 0).ToString();
                    lblMyOrders.Text = (order?.Where(q => q.UserGuid == currentUser.Guid)?.Count() ?? 0).ToString();

                    lblAllPardakht.Text = (pardakht?.Count ?? 0).ToString();
                    lblMyPardakht.Text =
                        (pardakht?.Where(q => q.UserGuid == currentUser.Guid)?.Count() ?? 0).ToString();
                    lblSumPardakht.Text =
                        (pardakht?.Where(q => q.UserGuid == currentUser.Guid)?.Sum(q => q.TotalPrice) ?? 0)
                        .ToString("N0");

                    lblAllReceptions.Text = (rece?.Count ?? 0).ToString();
                    lblMyReceptions.Text = (rece?.Where(q => q.UserGuid == currentUser.Guid)?.Count() ?? 0).ToString();
                    lblSumReception.Text =
                        (rece?.Where(q => q.UserGuid == currentUser.Guid)?.Sum(q => q.TotalPrice) ?? 0).ToString("N0");
                }));
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void SetData()
        {
            try
            {
                lblUserName.Text = CurentUser.CurrentUser.Name;
                lblTypeName.Text = CurentUser.CurrentUser.TypeName;
                var date = Calendar.MiladiToShamsi(CurentUser.LastVorrod);
                var time = CurentUser.LastVorrod.Hour + ":" + CurentUser.LastVorrod.Minute;
                lblLastVorrod.Text = time + " " + date;
                Task.Run(SetLabelsAsync);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void frmDashBoard_Load(object sender, System.EventArgs e) => SetData();
    }
}

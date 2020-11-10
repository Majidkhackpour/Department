using System;
using System.Windows.Forms;
using Department.Customer;
using Department.Product;
using Department.SafeBox;
using Department.SmsPanels;
using Department.Users;
using MetroFramework.Forms;
using Services;
using TMS.Class;

namespace Department
{
    public partial class frmMain : MetroForm
    {
        private void SetClock()
        {
            try
            {
                lblHour.Text = DateTime.Now.Hour.ToString();
                if (lblHour.Text.Length == 1) lblHour.Text = "0" + DateTime.Now.Hour;
                lblMinute.Text = DateTime.Now.Minute.ToString();
                if (lblMinute.Text.Length == 1) lblMinute.Text = "0" + DateTime.Now.Minute;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void SetCalendar()
        {
            try
            {
                var prd = new MaftooxCalendar.MaftooxPersianCalendar.DateWork();
                lblDay.Text = prd.GetNumberDayInMonth().ToString();
                lblMounth.Text = prd.GetNameMonth();
                lblYear.Text = prd.GetNumberYear().ToString();
                lblDayName.Text = Calendar.GetDayNameOfWeek(DateTime.Now);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public frmMain()
        {
            InitializeComponent();
        }
        private void SetAccess()
        {
            try
            {
                if (CurentUser.CurrentUser == null)
                {
                    Application.Exit();
                    return;
                }
                if(CurentUser.CurrentUser.IsBlock) Application.Exit();
                if (CurentUser.CurrentUser.Type == EnUserType.Manager)
                {
                    pnlUsers.Visible = true;
                    pnlProducts.Visible = true;
                    pnlSafeBox.Visible = true;
                    pnlSmsPanels.Visible = true;
                    pnlLog.Visible = true;
                }
                else
                {
                    pnlUsers.Visible = false;
                    pnlProducts.Visible = false;
                    pnlSafeBox.Visible = false;
                    pnlSmsPanels.Visible = false;
                    pnlLog.Visible = false;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                lblSecond.Visible = true;
                SetClock();
                SetCalendar();
                SetAccess();

                clsLoadNewForm.LoadNewForm(new frmDashBoard(), pnlContent);


            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void timerSecond_Tick(object sender, EventArgs e)
        {
            try
            {
                SetClock();
                if (lblSecond.Visible)
                    lblSecond.Visible = false;
                else if (!lblSecond.Visible)
                    lblSecond.Visible = true;
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void pnlExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlUsers_Click(object sender, EventArgs e)
        {
            try
            {
                clsLoadNewForm.LoadNewForm(new frmShowUsers(), pnlContent);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void pnlSmsPanels_Click(object sender, EventArgs e)
        {
            try
            {
                clsLoadNewForm.LoadNewForm(new frmShowSmsPanels(), pnlContent);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void pnlSafeBox_Click(object sender, EventArgs e)
        {
            try
            {
                clsLoadNewForm.LoadNewForm(new frmShowSafeBox(), pnlContent);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void pnlProducts_Click(object sender, EventArgs e)
        {
            try
            {
                clsLoadNewForm.LoadNewForm(new frmShowProducts(), pnlContent);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void pnlDashbord_Click(object sender, EventArgs e)
        {
            try
            {
                clsLoadNewForm.LoadNewForm(new frmDashBoard(), pnlContent);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void pnlCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                clsLoadNewForm.LoadNewForm(new frmShowCustomers(), pnlContent);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}

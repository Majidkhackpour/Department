using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Department.Customer;
using Department.Note;
using Department.Product;
using Department.SafeBox;
using Department.SmsPanels;
using Department.Users;
using EntityCache.Bussines;
using MetroFramework.Forms;
using Notification;
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

        private async Task SendFinishBackUpSms()
        {
            try
            {
                var now = DateTime.Now;

                var allCus = await CustomerBussines.GetAllAsync();
                allCus = allCus.Where(q => q.Status).ToList();

                if (string.IsNullOrEmpty(Setting.Classes.clsGlobalSetting.DefaultPanelGuid)) return;
                var guid = Guid.Parse(Setting.Classes.clsGlobalSetting.DefaultPanelGuid);
                var panel = await SmsPanelBussines.GetAsync(guid);
                if (panel == null) return;

                foreach (var item in allCus)
                {
                    var dayCount = 0;
                    if (item.ExpireDate > now && item.ExpireDate < now.AddDays(1))
                        dayCount = 1;
                    else if (item.ExpireDate > now.AddDays(3) && item.ExpireDate < now.AddDays(4))
                        dayCount = 3;
                    else if (item.ExpireDate > now.AddDays(7) && item.ExpireDate < now.AddDays(8))
                        dayCount = 7;
                    else if (item.ExpireDate > now.AddDays(10) && item.ExpireDate < now.AddDays(11))
                        dayCount = 10;


                    if (dayCount == 0) continue;

                    var message = $"{item.Name} عزیز، تنها {dayCount} روز تا پایان پشتیبانی شما زمان باقی است \r\n" +
                                  $"لطفا جهت تمدید پشتیبانی خود اقدام نمایید \r\n" +
                                  $"گروه مهندسی آراد";


                    var log = new CustomerLogBussines
                    {
                        Guid = Guid.NewGuid(),
                        CustomerGuid = item.Guid,
                        Description = message,
                        SideName = "ارسال پیامک"
                    };

                    await log.SaveAsync();



                    var sApi = new Sms.Api(panel.Api.Trim());

                    var res = sApi.Send(panel.LineNumber, item.Tell1, message);

                    var smsLog = new SmsLogBussines()
                    {
                        Guid = Guid.NewGuid(),
                        UserGuid = CurentUser.CurrentUser.Guid,
                        Cost = res.Cost,
                        Message = res.Message,
                        MessageId = res.Messageid,
                        Reciver = res.Receptor,
                        Sender = res.Sender,
                        StatusText = res.StatusText
                    };
                    
                    await smsLog.SaveAsync();
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
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
        private async void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                lblSecond.Visible = true;
                SetClock();
                SetCalendar();
                SetAccess();

                clsLoadNewForm.LoadNewForm(new frmDashBoard(), pnlContent);

                await SendFinishBackUpSms();

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

        private void pnlNote_Click(object sender, EventArgs e)
        {
            try
            {
                clsLoadNewForm.LoadNewForm(new frmShowNotes(), pnlContent);
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

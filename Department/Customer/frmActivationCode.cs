using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Department.Users;
using DepartmentDal.Classes;
using MetroFramework.Forms;
using Notification;
using Services;

namespace Department.Customer
{
    public partial class frmActivationCode : MetroForm
    {
        private CustomerBussines cls;
        private string side = "";
        private void SetData()
        {
            try
            {
                lblName.Text = cls?.Name;
                lblActivationCode.Text = "";
                lblAppSerial.Text = cls?.AppSerial;
                lblExpDate.Text = cls?.ExpireDateSh;
                txtTerm.Text = "12";
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public frmActivationCode(CustomerBussines cus)
        {
            InitializeComponent();
            cls = cus;
        }

        private void frmActivationCode_Load(object sender, EventArgs e)
        {
            SetData();
            var tt = new ToolTip();
            tt.SetToolTip(picSms, "ارسال کد فعالسازی از طریق ارسال پیامک");
            tt.SetToolTip(picEmail, "ارسال کد فعالسازی از طریق ایمیل");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblActivationCode.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("کدفعالسازی تولید شده است. برای خروج از دکمه تایید استفاده نمایید");
                    return;
                }
                DialogResult = DialogResult.Cancel;
                Close();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void frmActivationCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        if (!btnFinish.Focused && !btnCancel.Focused)
                            SendKeys.Send("{Tab}");
                        break;
                    case Keys.F5:
                        btnFinish.PerformClick();
                        break;
                    case Keys.Escape:
                        btnCancel.PerformClick();
                        break;
                }
            }
            catch (Exception exception)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(exception);
            }
        }

        private async void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFanni.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("مشخصه فنی مشتری نمی تواند خالی باشد");
                    txtFanni.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(lblAppSerial.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("کد فعالسازی را تولید نکرده اید");
                    return;
                }


                cls.ExpireDate = DateTime.Now.AddMonths(txtTerm.Value.ToString().ParseToInt());

                var res = await cls.SaveAsync();
                if (res.HasError)
                {
                    frmNotification.PublicInfo.ShowMessage(res.ErrorMessage);
                    return;
                }

                var log = new CustomerLogBussines
                {
                    Guid = Guid.NewGuid(),
                    CustomerGuid = cls.Guid,
                    Description = txtDesc.Text,
                    SideName = string.IsNullOrEmpty(side) ? "تلفن" : side
                };

                var res_ = await log.SaveAsync();
                if (res_.HasError)
                {
                    frmNotification.PublicInfo.ShowMessage(res_.ErrorMessage);
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void txtFanni_Enter(object sender, EventArgs e)
        {
            txtSetter.Focus(txtFanni, true);
        }

        private void txtFanni_Leave(object sender, EventArgs e)
        {
            txtSetter.Follow(txtFanni);
        }

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFanni.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("مشخصه فنی مشتری نمی تواند خالی باشد");
                    txtFanni.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(lblAppSerial.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("کد فعالسازی را تولید نکرده اید");
                    return;
                }
                var code = SoftwareLock.GenerateActivationCodeServer.ActivationCode((int)txtTerm.Value, txtFanni.Text);
                lblActivationCode.Text = code;


                txtDesc.Text = $"سریال نرم افزار {lblAppSerial.Text} \r\n" +
                               $"تاریخ اتمام پشتیبانی {Calendar.MiladiToShamsi(DateTime.Now.AddMonths((int)txtTerm.Value))}";

            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void picEmail_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFanni.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("مشخصه فنی مشتری نمی تواند خالی باشد");
                    txtFanni.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(lblAppSerial.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("کد فعالسازی را تولید نکرده اید");
                    return;
                }
                if (string.IsNullOrEmpty(cls.Email))
                {
                    frmNotification.PublicInfo.ShowMessage("ایمیل مشتری جاری معتبر نمی باشد");
                    return;
                }

                var subject = "کد ورود به برنامه";
                var body = $"{cls.Name} عزیز \r\n" +
                           $"مدیریت مجموعه {cls.CompanyName} \r\n" +
                           $"سریال نرم افزار شما {lblAppSerial.Text} \r\n" +
                           $"کد فعالسازی نرم افزار شما {lblActivationCode.Text} \r\n" +
                           $"تاریخ اتمام پشتیبانی شما {Calendar.MiladiToShamsi(DateTime.Now.AddMonths((int)txtTerm.Value))} \r\n" +
                           $"با سپاس ار انتخاب شما \r\n " +
                           $"گروه مهندسی آراد \r\n" +
                           $"تاریخ ارسال: {Calendar.MiladiToShamsi(DateTime.Now)}  {DateTime.Now.ToShortTimeString()}";

                var send = SendEmail.Send(cls.Email, subject, body);

                frmNotification.PublicInfo.ShowMessage(send
                    ? "ایمیل کدفعالسازی با موفقیت ارسال شد"
                    : "خطا در ارسال کدفعالسازی از طریق ایمیل");

                side = "ارسال ایمیل";
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private async void picSms_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFanni.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("مشخصه فنی مشتری نمی تواند خالی باشد");
                    txtFanni.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(lblAppSerial.Text))
                {
                    frmNotification.PublicInfo.ShowMessage("کد فعالسازی را تولید نکرده اید");
                    return;
                }

                var body = $"{cls.Name} عزیز \r\n" +
                           $"مدیریت مجموعه {cls.CompanyName} \r\n" +
                           $"سریال نرم افزار شما {lblAppSerial.Text} \r\n" +
                           $"کد فعالسازی نرم افزار شما {lblActivationCode.Text} \r\n" +
                           $"تاریخ اتمام پشتیبانی شما {Calendar.MiladiToShamsi(DateTime.Now.AddMonths((int)txtTerm.Value))} \r\n" +
                           $"با سپاس ار انتخاب شما \r\n " +
                           $"گروه مهندسی آراد \r\n";


                var panel = SmsPanelBussines.GetCurrent();
                if (panel == null) return;
                var sApi = new Sms.Api(panel.Api.Trim());

                var res = sApi.Send(panel.LineNumber, cls.Tell1, body);

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

                var res1 = await smsLog.SaveAsync();
                if (res1.HasError)
                {
                    frmNotification.PublicInfo.ShowMessage(res1.ErrorMessage);
                    return;
                }

                frmNotification.PublicInfo.ShowMessage("ارسال پیامک با موفقیت انجام شد");

                side = "ارسال پیامک";
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmCustomerLog(cls.Guid);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}

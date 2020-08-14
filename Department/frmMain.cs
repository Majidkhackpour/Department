﻿using System;
using System.Windows.Forms;
using Department.Users;
using MetroFramework.Forms;
using Services;
using TMS.Class;

namespace Department
{
    public partial class frmMain : MetroForm
    {
        private void LoadNewForm(Form frm)
        {
            try
            {
                frm.TopLevel = false;
                frm.AutoScroll = true;
                frm.ControlBox = false;
                frm.Dock = DockStyle.Fill;
                pnlContent.Controls.Clear();
                pnlContent.BringToFront();
                pnlContent.Controls.Add(frm);
                frm.Dock = DockStyle.Fill;
                pnlContent.AutoScroll = true;
                frm.Show();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                lblSecond.Visible = true;
                SetClock();
                SetCalendar();
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
                LoadNewForm(new frmShowUsers());
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }


    }
}

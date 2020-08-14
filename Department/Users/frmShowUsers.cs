using System;
using System.Linq;
using System.Windows.Forms;
using EntityCache.Bussines;
using MetroFramework.Forms;
using Services;

namespace Department.Users
{
    public partial class frmShowUsers : MetroForm
    {
        private bool _st = true;
        private void LoadData(bool status, string search = "")
        {
            try
            {
                var list = UsersBussines.GetAll(search).Where(q => q.Status == status).ToList();
                userBindingSource.DataSource = list.ToSortableBindingList();
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
                    mnuDelete.Text = "حذف کاربر جاری";
                }
                else
                {
                    mnuChangeStatus.Text = "مشاهده فعال ها";
                    LoadData(ST, txtSearch.Text);
                    mnuDelete.Text = "تغییر وضعیت به فعال";
                }
            }
        }
        public frmShowUsers()
        {
            InitializeComponent();
        }

        private void frmShowUsers_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData(ST);
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
    }
}

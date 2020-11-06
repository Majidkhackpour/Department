﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DepartmentDal.Classes;
using MetroFramework.Forms;
using Services;

namespace Department.Product
{
    public partial class frmSelectProduct : MetroForm
    {
        public List<ProductBussines> PrdList { get; set; }
        private string serial;
        private async Task LoadDataAsync(string search = "")
        {
            try
            {
                var list = await ProductBussines.GetAllAsync(search);
                prdBindingSource.DataSource = list.Where(q => q.Status).ToList().ToSortableBindingList();


                if (string.IsNullOrEmpty(serial)) return;
                var serialList = new List<string>();
                var code = "";
                foreach (var item in serial.ToList())
                {
                    if (code.Length < 2)
                    {
                        code += item;
                        if (code.Length == 2)
                        {
                            serialList.Add(code);
                            code = "";
                        }
                    }
                    else
                    {
                        serialList.Add(code);
                        code = "";
                    }
                }


                foreach (var item in serialList)
                    for (var i = 0; i < DGrid.RowCount; i++)
                        if (DGrid[dgCode.Index, i].Value.ToString() == item)
                            DGrid[dgChecked.Index, i].Value = true;


            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
        public frmSelectProduct(string _serial)
        {
            InitializeComponent();
            serial = _serial;
        }

        private async void frmSelectProduct_Load(object sender, EventArgs e) => await LoadDataAsync();

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                await LoadDataAsync(txtSearch.Text);
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                PrdList = new List<ProductBussines>();
                for (var i = 0; i < DGrid.RowCount; i++)
                {
                    if (!(bool) DGrid[dgChecked.Index, i].Value) continue;
                    var guid = (Guid) DGrid[dgGuid.Index, i].Value;
                    var prd = ProductBussines.Get(guid);
                    if (prd == null) continue;
                    PrdList.Add(prd);
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
            }
        }
    }
}
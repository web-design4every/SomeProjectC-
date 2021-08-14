using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SE1421_QuanLyKho
{
    public partial class QuanLyNhapKho : Form
    {
        QuanLyNhapKhoDAO db = new QuanLyNhapKhoDAO();
        public QuanLyNhapKho()
        {
            InitializeComponent();
            Time();
            //NhaCungCap();
        }
        public void Time()
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("HH:mm dd/MM/yyyy");
        }
        //public void NhaCungCap()
        //{
        //    foreach (NhaCungCap ncc in db.listSupplier())
        //    {
        //        cbxNCC.Items.Add(ncc.Ten);
        //    }
        //}
    }
}

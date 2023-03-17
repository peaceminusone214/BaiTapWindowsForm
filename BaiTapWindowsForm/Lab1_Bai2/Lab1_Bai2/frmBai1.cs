using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Bai2
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            ThietBi hh = new ThietBi();
            hh.MaThietBi = "ASD123";
            hh.TenThietBi = "Chuột";
            hh.NuocSanXuat = "Việt Nam";
            hh.DonGia = "500000";
            hh.SoLuong = "100";
            //Hien thi ket qua su dung lblThongBao
            lblThongBao.Text = hh.HienThi();
            lblThanhTien.Text = "Thành tiền: 50000000";
        }

    }
}

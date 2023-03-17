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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSo1.Text);
            int b = int.Parse(txtSo2.Text);
            int kq = 0;

            if (rbCong.Checked)
                TinhToan.CongHaiSo(a, b, ref kq);
            else
            {
                if (rbTru.Checked)
                    TinhToan.TruHaiSo(a, b, ref kq);
                else
                {
                    if (rbNhan.Checked)
                        TinhToan.NhanHaiSo(a, b, ref kq);
                    else TinhToan.ChiaHaiSo(a, b, ref kq);
                }
            }
      
            //Hien thi ket qua
            lblKetQua.Text = kq.ToString();
        }

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

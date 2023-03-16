using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void tsbBai1_Click(object sender, EventArgs e)
        {
            //Mo form Bai 1 khi an vao nut Bai 1 tren form chinh
            var form = new frmBai1();
            form.ShowDialog();
        }

        private void tsbBai2_Click(object sender, EventArgs e)
        {
            //Mo form Bai 2 khi an vao nut Bai 2 tren form chinh
            var form = new frmBai2();
            form.ShowDialog();
        }

        private void tsbBai3_Click(object sender, EventArgs e)
        {
            //Mo form Bai 3 khi an vao nut Bai 3 tren form chinh
            var form = new frmBai3();
            form.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Bai2
{
    internal class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXuat { get; set; }
        public string DonGia { get; set; }
        public string SoLuong { get; set; }
        // Ham khoi tao khong co tham so
        public ThietBi()
        {

        }
        // Phuong thuc: HienThi (hien thi tat ca thong tin cua hang hoa)
        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", MaThietBi, TenThietBi, NuocSanXuat, DonGia, SoLuong);
        }

    }
}
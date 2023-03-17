using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Bai2
{
    internal class TinhToan
    {
        public static void CongHaiSo(int a, int b, ref int s)
        {
            s = a + b;
        }
        public static void TruHaiSo(int a, int b, ref int s)
        {
            s = a - b;
        }
        public static void NhanHaiSo(int a, int b, ref int s)
        {
            s = a * b;
        }
        public static void ChiaHaiSo(int a, int b, ref int s)
        {
            s = a / b;
        }
        public static void HoTen(string a, string b, string s)
        {
            s = a + b;
        }
    }
}

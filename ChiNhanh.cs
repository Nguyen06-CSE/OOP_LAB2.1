using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class ChiNhanh
    {
        public string MaChiNhanh;
        public string TenChiNhanh;
        public string DiaChi;

        public ChiNhanh(string maChiNhanh, string tenChiNhanh, string diaChi)
        {
            MaChiNhanh = maChiNhanh;
            TenChiNhanh = tenChiNhanh;
            DiaChi = diaChi;
        }

        public ChiNhanh() 
        {
        }
    }
}

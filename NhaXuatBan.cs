using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class NhaXuatBan
    {
        public string Ten;
        public string DiaChi;
        public string SoDienThoai;

        public NhaXuatBan(string ten, string diaChi, string soDienThoai)
        {
            Ten = ten;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
        }
        public NhaXuatBan() { }
    }
}

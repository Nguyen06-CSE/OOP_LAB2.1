using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class NguoiMuon
    {
        public string SoThe;
        public string HoTen;
        public string DiaChi;
        public string SoDienThoai;

        public NguoiMuon(string soThe, string hoTen, string diaChi, string soDienThoai)
        {
            SoThe = soThe;
            HoTen = hoTen;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
        }
        public NguoiMuon() { }
    }
}

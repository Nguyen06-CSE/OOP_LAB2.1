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


        public NguoiMuon() { }

        public NguoiMuon(string soThe, string hoTen, string diaChi, string soDienThoai)
        {
            SoThe = soThe;
            HoTen = hoTen;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
        }
    
        public override string ToString()
        {
            return $"So the : {SoThe}\n" +
                   $"Ho ten : {HoTen}\n" +
                   $"Dia chi : {DiaChi}\n" +
                   $"So dien thoai : {SoDienThoai}";
        }
    
    }
}

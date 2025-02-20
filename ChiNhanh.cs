using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class ChiNhanh
    {
        public string MaChiNhanh;
        public string TenChiNhanh;
        public string DiaChi;


        public ChiNhanh() { }
        
        
        public ChiNhanh(string maChiNhanh, string tenChiNhanh, string diaChi)
        {
            MaChiNhanh = maChiNhanh;
            TenChiNhanh = tenChiNhanh;
            DiaChi = diaChi;
        }

        public override string ToString()
        {
            return $"Ma chi nhanh : {MaChiNhanh}\n" +
                   $"Ten chi nhanh : {TenChiNhanh}\n" +
                   $"Dia chi : {DiaChi}";
        }


    }
}

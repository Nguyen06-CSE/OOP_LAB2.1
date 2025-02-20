using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class Sach
    {
        public string MaSach;
        public string TenSach;
        public NhaXuatBan NXB;
        public string TacGia;
        public Sach() { }

        public Sach(string maSach, string tenSach, NhaXuatBan nxb, string tacGia)
        {
            MaSach = maSach;
            TenSach = tenSach;
            NXB = nxb;
            TacGia = tacGia;
        }
        public override string ToString()
        {
            return $"Ma sach : {MaSach}\n" +
                   $"Ten sach : {TenSach}\n" +
                   $"Ten NXB : {NXB}" +
                   $"Ten tac gia : {TacGia}\n" ;
        }
    }
}

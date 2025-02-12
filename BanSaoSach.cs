using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class BanSaoSach
    {
        public string MaSach;
        public int SoLuongBanSao;

        public BanSaoSach(string maSach, int soLuongBanSao)
        {
            MaSach = maSach;
            SoLuongBanSao = soLuongBanSao;
        }
        public BanSaoSach() { }
    }
}

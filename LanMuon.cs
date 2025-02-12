using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class LanMuon
    {
        public string SoThe;
        public string MaSach;  
        public DateTime NgayMuon;
        public DateTime NgayTra;

        public LanMuon(string soThe, string maSach, DateTime ngayMuon, DateTime ngayTra)
        {
            SoThe = soThe;
            MaSach = maSach;
            NgayMuon = ngayMuon;
            NgayTra = ngayTra;
        }
        public LanMuon() { }
    }
}

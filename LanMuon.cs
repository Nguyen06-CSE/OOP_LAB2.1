using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class LanMuon
    {
        public NguoiMuon NguoiMuon;
        public List<Sach> DSSach;  
        public DateTime NgayMuon;
        public DateTime NgayTra;

        public LanMuon() { }

        public LanMuon(NguoiMuon nm)
        {
            NguoiMuon = nm;
            DSSach = new List<Sach>();
            NgayMuon = DateTime.Now;
            NgayTra = DateTime.Now.AddDays(7);
        }

        public void ThemSachMuon(Sach sach)
        {
            DSSach.Add(sach);
        }

        public void TraSach()
        {
            NgayTra = DateTime.Now;
        }

        public override string ToString()
        {
            string sachList = DSSach.Count > 0
                ? string.Join(", ", DSSach.Select(s => s.TenSach))
                : "khong co sach";

            return $"Nguoi Muon : {NguoiMuon.HoTen}\n" +
                   $"Danh sach sach : {sachList}\n" +
                   $"Nguay muon : {NgayMuon:dd/MM/yyyy}\n" +
                   $"Ngay tra : {NgayTra:dd/MM/yyyy}";
        }

        public void XuatThongTin()
        {
            Console.WriteLine($"Nguoi Muon : {NguoiMuon.HoTen}\n" +
                   $"Nguay muon : {NgayMuon:dd/MM/yyyy}\n" +
                   $"Ngay tra : {NgayTra:dd/MM/yyyy}");
            Console.WriteLine("Danh sach sach da muon");
            foreach (Sach sach in DSSach) { Console.WriteLine(sach); }
        }

    }
}

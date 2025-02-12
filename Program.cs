using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
design solution
i think we should create 6 class to describe the topic
 class ChiNhanh
 class Sach
 class NhaXuatBan
 class BanSaoSach
 class NguoiMuon
 class LanMuon
*/

namespace QuanLyThuVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Tao chi nhanh
                ChiNhanh cn1 = new ChiNhanh("CN01", "Thu vien Co so A", "123 Duong A, TP HCM");

                // Tao nha xuat ban
                NhaXuatBan nxb1 = new NhaXuatBan("NXB Kim Dong", "456 Duong B, Ha Noi", "0123456789");

                // Tao sach
                Sach sach1 = new Sach("S001", "De Men Phieu Luu Ky", nxb1, "To Hoai");

                // Tao ban sao sach
                BanSaoSach bs1 = new BanSaoSach("S001", 5);

                // Tao nguoi muon
                NguoiMuon nguoi1 = new NguoiMuon("T001", "Nguyen Van A", "789 Duong C, Da Nang", "0987654321");

                // Tao giao dich muon sach
                LanMuon muon1 = new LanMuon("T001", "S001", DateTime.Now, DateTime.Now.AddDays(14));

                // Hien thi thong tin
                Console.WriteLine($"Chi nhanh: {cn1.TenChiNhanh}, Dia chi: {cn1.DiaChi}");
                Console.WriteLine($"Sach: {sach1.TenSach}, Tac gia: {sach1.TacGia}, NXB: {sach1.NXB.Ten}");
                Console.WriteLine($"Nguoi muon: {nguoi1.HoTen}, So the: {nguoi1.SoThe}");
                Console.WriteLine($"Ngay muon: {muon1.NgayMuon}, Ngay tra: {muon1.NgayTra}");
            }
        }
    }
}

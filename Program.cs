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
            //    {
            //        // Tao chi nhanh
            //        ChiNhanh cn1 = new ChiNhanh("CN01", "Thu vien Co so A", "123 Duong A, TP HCM");

            //        // Tao nha xuat ban
            //        NhaXuatBan nxb1 = new NhaXuatBan("NXB Kim Dong", "456 Duong B, Ha Noi", "0123456789");

            //        // Tao sach
            //        Sach sach1 = new Sach("S001", "De Men Phieu Luu Ky", nxb1, "To Hoai");

            //        // Tao ban sao sach
            //        BanSaoSach bs1 = new BanSaoSach("S001", 5);

            //        // Tao nguoi muon
            //        NguoiMuon nguoi1 = new NguoiMuon("T001", "Nguyen Van A", "789 Duong C, Da Nang", "0987654321");

            //        // Tao giao dich muon sach
            //        LanMuon muon1 = new LanMuon("T001", "S001", DateTime.Now, DateTime.Now.AddDays(14));

            //        // Hien thi thong tin
            //        Console.WriteLine($"Chi nhanh: {cn1.TenChiNhanh}, Dia chi: {cn1.DiaChi}");
            //        Console.WriteLine($"Sach: {sach1.TenSach}, Tac gia: {sach1.TacGia}, NXB: {sach1.NXB.Ten}");
            //        Console.WriteLine($"Nguoi muon: {nguoi1.HoTen}, So the: {nguoi1.SoThe}");
            //        Console.WriteLine($"Ngay muon: {muon1.NgayMuon}, Ngay tra: {muon1.NgayTra}");
            //    }
            //}

            // Tao 5 chi nhanh
            List<ChiNhanh> chiNhanhList = new List<ChiNhanh>
            {
            new ChiNhanh("CN01", "Thu vien Co so A", "123 Duong A, TP HCM"),
            new ChiNhanh("CN02", "Thu vien Co so B", "456 Duong B, Ha Noi"),
            new ChiNhanh("CN03", "Thu vien Co so C", "789 Duong C, Da Nang"),
            new ChiNhanh("CN04", "Thu vien Co so D", "101 Duong D, Can Tho"),
            new ChiNhanh("CN05", "Thu vien Co so E", "202 Duong E, Hai Phong")
            };

            // Tao 5 nha xuat ban
            List<NhaXuatBan> nxbList = new List<NhaXuatBan>
            {
            new NhaXuatBan("NXB Kim Dong", "456 Duong B, Ha Noi", "0123456789"),
            new NhaXuatBan("NXB Tre", "123 Duong A, TP HCM", "0987654321"),
            new NhaXuatBan("NXB Giao Duc", "789 Duong C, Da Nang", "0369852147"),
            new NhaXuatBan("NXB Van Hoc", "101 Duong D, Can Tho", "0587412369"),
            new NhaXuatBan("NXB Tong Hop", "202 Duong E, Hai Phong", "0741258963")
            };

            // Tao 5 sach
            List<Sach> sachList = new List<Sach>
            {
            new Sach("S001", "De Men Phieu Luu Ky", nxbList[0], "To Hoai"),
            new Sach("S002", "Tat Den", nxbList[1], "Ngo Tat To"),
            new Sach("S003", "Chi Pheo", nxbList[2], "Nam Cao"),
            new Sach("S004", "So Do", nxbList[3], "Vu Trong Phung"),
            new Sach("S005", "Truyen Kieu", nxbList[4], "Nguyen Du")
            };

            // Tao 5 ban sao sach
            List<BanSaoSach> banSaoList = new List<BanSaoSach>
            {
            new BanSaoSach("S001", 5),
            new BanSaoSach("S002", 3),
            new BanSaoSach("S003", 7),
            new BanSaoSach("S004", 2),
            new BanSaoSach("S005", 4)
            };

            // Tao 5 nguoi muon
            List<NguoiMuon> nguoiMuonList = new List<NguoiMuon>
            {
            new NguoiMuon("T001", "Nguyen Van A", "789 Duong C, Da Nang", "0987654321"),
            new NguoiMuon("T002", "Tran Thi B", "123 Duong A, TP HCM", "0123456789"),
            new NguoiMuon("T003", "Le Van C", "456 Duong B, Ha Noi", "0369852147"),
            new NguoiMuon("T004", "Pham Thi D", "101 Duong D, Can Tho", "0587412369"),
            new NguoiMuon("T005", "Hoang Van E", "202 Duong E, Hai Phong", "0741258963")
            };

            // Tao 5 giao dich muon sach
            List<LanMuon> muonList = new List<LanMuon>
            {
            new LanMuon("T001", "S001", DateTime.Now, DateTime.Now.AddDays(14)),
            new LanMuon("T002", "S002", DateTime.Now, DateTime.Now.AddDays(10)),
            new LanMuon("T003", "S003", DateTime.Now, DateTime.Now.AddDays(7)),
            new LanMuon("T004", "S004", DateTime.Now, DateTime.Now.AddDays(21)),
            new LanMuon("T005", "S005", DateTime.Now, DateTime.Now.AddDays(30))
            };

            // Hien thi thong tin
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Chi nhanh: {chiNhanhList[i].TenChiNhanh}, Dia chi: {chiNhanhList[i].DiaChi}");
                Console.WriteLine($"Sach: {sachList[i].TenSach}, Tac gia: {sachList[i].TacGia}, NXB: {sachList[i].NXB.Ten}");
                Console.WriteLine($"Nguoi muon: {nguoiMuonList[i].HoTen}, So the: {nguoiMuonList[i].SoThe}");
                Console.WriteLine($"Ngay muon: {muonList[i].NgayMuon}, Ngay tra: {muonList[i].NgayTra}");
                Console.WriteLine();
            }
        }
    }
}

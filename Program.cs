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
                ChiNhanh cn2 = new ChiNhanh("CN02", "Thu vien Co so B", "456 Duong B, Ha Noi");
                ChiNhanh cn3 = new ChiNhanh("CN03", "Thu vien Co so C", "789 Duong C, Da Nang");
                ChiNhanh cn4 = new ChiNhanh("CN04", "Thu vien Co so D", "101 Duong D, Can Tho");
                ChiNhanh cn5 = new ChiNhanh("CN05", "Thu vien Co so E", "202 Duong E, Hai Phong");

                //Console.WriteLine(cn1.ToString() + cn2.ToString() + cn3.ToString() + cn4.ToString() + cn5.ToString());




                // Tao nha xuat ban
                NhaXuatBan nxb1 = new NhaXuatBan("NXB Kim Dong", "456 Duong B, Ha Noi", "0123456789");
                NhaXuatBan nxb2 = new NhaXuatBan("NXB Tre", "123 Duong A, TP HCM", "0987654321");
                NhaXuatBan nxb3 = new NhaXuatBan("NXB Giao Duc", "789 Duong C, Da Nang", "0369852147");
                NhaXuatBan nxb4 = new NhaXuatBan("NXB Van Hoc", "101 Duong D, Can Tho", "0587412369");
                NhaXuatBan nxb5 = new NhaXuatBan("NXB Tong Hop", "202 Duong E, Hai Phong", "0741258963");


                //Console.WriteLine(nxb1.ToString() + nxb2.ToString() + nxb3.ToString() + nxb4.ToString() + nxb5.ToString());

                // Tao sach
                Sach sach1 = new Sach("S001", "De Men Phieu Luu Ky", nxb1, "To Hoai");
                Sach sach2 = new Sach("S002", "Tat Den", nxb2, "Ngo Tat To");
                Sach sach3 = new Sach("S003", "Chi Pheo", nxb3, "Nam Cao");
                Sach sach4 = new Sach("S004", "So Do", nxb4, "Vu Trong Phung");
                Sach sach5 = new Sach("S005", "Truyen Kieu", nxb5, "Nguyen Du");

                //Console.WriteLine(sach1.ToString() + sach2.ToString() + sach3.ToString() + sach4.ToString() + sach5.ToString());

                // Tao ban sao sach
                BanSaoSach bs1 = new BanSaoSach("S001", 5);
                BanSaoSach bs2 = new BanSaoSach("S002", 3);
                BanSaoSach bs3 = new BanSaoSach("S003", 7);
                BanSaoSach bs4 = new BanSaoSach("S004", 2);
                BanSaoSach bs5 = new BanSaoSach("S005", 4);

                //Console.WriteLine(bs1.ToString() + bs2.ToString() + bs3.ToString() + bs4.ToString() + bs5.ToString());


                // Tao nguoi muon
                NguoiMuon nguoi1 = new NguoiMuon("T001", "Nguyen Van A", "789 Duong C, Da Nang", "0987654321");
                NguoiMuon nguoi2 = new NguoiMuon("T002", "Tran Thi B", "123 Duong A, TP HCM", "0123456789");
                NguoiMuon nguoi3 = new NguoiMuon("T003", "Le Van C", "456 Duong B, Ha Noi", "0369852147");
                NguoiMuon nguoi4 = new NguoiMuon("T004", "Pham Thi D", "101 Duong D, Can Tho", "0587412369");
                NguoiMuon nguoi5 = new NguoiMuon("T005", "Hoang Van E", "202 Duong E, Hai Phong", "0741258963");

                Console.WriteLine(nguoi1.ToString() + nguoi2.ToString() + nguoi3.ToString() + nguoi4.ToString() + nguoi5.ToString());


                // Tao giao dich muon sach
                LanMuon muon1 = new LanMuon(nguoi1);
                LanMuon muon2 = new LanMuon(nguoi2);
                LanMuon muon3 = new LanMuon(nguoi3);
                LanMuon muon4 = new LanMuon(nguoi4);
                LanMuon muon5 = new LanMuon(nguoi5);

                muon1.TraTruocHan(DateTime.Today);
                muon1.ThemSachVaoDSSach(sach5);
                muon1.ThemSachVaoDSSach(sach4);
                muon1.ThemSachVaoDSSach(sach3);
                muon1.ThemSachVaoDSSach(sach2);
                muon2.ThemSachVaoDSSach(sach5);
                muon3.ThemSachVaoDSSach(sach5);
                muon5.ThemSachVaoDSSach(sach5);

                Console.WriteLine(muon1.ToString() + muon2.ToString() + muon3.ToString() + muon4.ToString() + muon5.ToString());


                
            }
        }
    }
}

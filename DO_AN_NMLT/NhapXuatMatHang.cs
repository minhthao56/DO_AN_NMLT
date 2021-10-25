using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN_NMLT
{
    class NhapXuatMatHang
    {

        public static Types.MatHang NhapMatHang(Types.MatHang[] ListMatHang, ref Types.LoaiHang[] ListLoaiHang, Types.MatHang[] ListMatHangThemNhieu = null)
        {

            bool DoHangDaTonTai = false;

            bool MaLoaiKhongHangTonTai = true;

           

            Types.MatHang MotMatHang = new Types.MatHang();

            Console.WriteLine("---- Nhap cac thong tin cua don hang----");
           
            do
            {
                Console.WriteLine("Nhap ma mat hang: ");
                MotMatHang.Ma = Convert.ToString(Console.ReadLine());

                // Kiem tra do hang co ton tai trong list hien tai hay khong
                DoHangDaTonTai = Helpers.KiemDonHangDaTonTai(ListMatHang, MotMatHang.Ma);

                if(ListMatHangThemNhieu != null && !DoHangDaTonTai)
                {
                 
                    DoHangDaTonTai = Helpers.KiemDonHangDaTonTai(ListMatHangThemNhieu, MotMatHang.Ma);
                }


                if (DoHangDaTonTai)
                {
                    Console.WriteLine("Do Hang Da Ton Tai - Vui Long Nhap Ma Don Hang Khac");
                    MotMatHang.Ma = "";
                }
            }
            while (DoHangDaTonTai && MotMatHang.Ma == "");

            do
            {
                Console.WriteLine("Nhap ten mat hang: ");

                MotMatHang.TenHang = Convert.ToString(Console.ReadLine());

                if(MotMatHang.TenHang == "")
                {
                    Console.WriteLine("Khong dc de rong - TenHang: ");
                }

            } while (MotMatHang.TenHang == "");


            do
            {
                Console.WriteLine("Nhap cong ty san xuat: ");
                MotMatHang.CtySanXuat = Convert.ToString(Console.ReadLine());
                if (MotMatHang.CtySanXuat == "")
                {
                    Console.WriteLine("Khong dc de rong - CtySanXuat: ");
                }

            } while (MotMatHang.CtySanXuat == "");


            do
            {
                Console.WriteLine("Nhap han su dung: ");
                MotMatHang.HanDung = Convert.ToString(Console.ReadLine());


                if (MotMatHang.HanDung == "")
                {
                    Console.WriteLine("Khong dc de rong - HanDung: ");
                }

            } while (MotMatHang.HanDung == "");


            do
            {
                Console.WriteLine("Nhap nam san xuat: ");
                MotMatHang.NamSanXuat = Convert.ToString(Console.ReadLine());
                if (MotMatHang.NamSanXuat == "")
                {
                    Console.WriteLine("Khong dc de rong - nam san xuat: ");

                }
            } while (MotMatHang.NamSanXuat == "");


            do {

                NhapXuatLoaiHang.XuatListLoaiHang(ListLoaiHang);
                if (ListLoaiHang.Length == 0)
                {
                    Console.WriteLine("Danh sach loai hang rong - Vui long tao them loai hang vao danh sach");

                    Actions.FuncThemMotLoaiHang(ref ListLoaiHang);
                }

                Console.WriteLine("Nhap ma loai hang cho don hang hien tai - Hoac go\'Them moi' neu muon loai hang moi: ");

                MotMatHang.LoaiHang = Convert.ToString(Console.ReadLine());

                if (MotMatHang.LoaiHang.ToLower() == "them moi")
                {
                    Actions.FuncThemMotLoaiHang(ref ListLoaiHang);
                    MotMatHang.LoaiHang = "";

                }
                else
                {
                    MaLoaiKhongHangTonTai = Helpers.KiemTraLoaiTonTaiTruocKhiNhapDonHang(ListLoaiHang, MotMatHang.LoaiHang);
                    if (MaLoaiKhongHangTonTai)
                    {
                        Console.WriteLine("Ma hang khong ton tai trong danh sanh loai hang");

                        Console.WriteLine("Ban co muon them loai hang moi khong?");

                        string kq = Controllers.ChonYesNo();

                        if (kq == "1")
                        {
                            Actions.FuncThemMotLoaiHang(ref ListLoaiHang);
                        }
                        else
                        {
                            MotMatHang.LoaiHang = "";
                        }

                    }
                }

                if(MotMatHang.LoaiHang == "")
                {
                    Console.WriteLine("Khong dc de rong - LoaiHang");
                }

            }

           

            while (MaLoaiKhongHangTonTai && MotMatHang.LoaiHang == "");

            return MotMatHang;
        }



        public static Types.MatHang[] NhapNhieuMatHang(Types.MatHang[] ListMatHang, ref Types.LoaiHang[] ListLoaiHang) {

            Console.WriteLine("Nhap so luong mat hang can vao he thong: ");

            int SoLuongMatHang = Convert.ToInt32(Console.ReadLine());

            Types.MatHang[] ListMatHangMoi = new Types.MatHang[SoLuongMatHang];

            for (int i =0; i < ListMatHangMoi.Length; i++)
            {
                Console.WriteLine($"-----Nhap mat hang lan {i + 1} -----");

                Types.MatHang MotMatHang = NhapMatHang(ListMatHang, ref ListLoaiHang, ListMatHangMoi);


                ListMatHangMoi[i] = MotMatHang;
            }



            return ListMatHangMoi;


        }


        public static void XuatListMatHang(Types.MatHang[] ListMatHang)
        {

            int ChieuDaiMang = ListMatHang.Length;

            TableDraw.PrintLine();
            TableDraw.PrintRow("Ma Hang", "Ten Hang", "CTy San Xuat", "Han Dung", "Nam San Xuat", "Loai Hang" );
            TableDraw.PrintLine();
            for (int i = 0; i < ChieuDaiMang; i++)
            {
                TableDraw.PrintRow(ListMatHang[i].Ma, ListMatHang[i].TenHang, ListMatHang[i].CtySanXuat, ListMatHang[i].HanDung, ListMatHang[i].NamSanXuat, ListMatHang[i].LoaiHang);
            }
           
            TableDraw.PrintLine();

        }
    }
}

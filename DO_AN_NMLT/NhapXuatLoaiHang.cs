using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN_NMLT
{
    class NhapXuatLoaiHang
    {
        public static Types.LoaiHang NhapLoaiHang(Types.LoaiHang[] ListLoaiHang)
        {

            Types.LoaiHang MotLoaiHang = new Types.LoaiHang();

            Console.WriteLine("---- Nhap cac thong tin cua loai hang----");

            bool LoaiHangDaTonTai = false;
            do
            {
                Console.WriteLine("Nhap ma loai hang: ");
                MotLoaiHang.MaLoaiHang = Convert.ToString(Console.ReadLine());

                // Kiem tra do loai co ton tai trong list hien tai hay khong
                LoaiHangDaTonTai = Helpers.KiemLoaiHangDaTonTai(ListLoaiHang, MotLoaiHang.MaLoaiHang);

                if (LoaiHangDaTonTai)
                {
                    Console.WriteLine("Do Loai Da Ton Tai - Vui Long Nhap Ma Loai Hang Khac");

                }
            }
            while (LoaiHangDaTonTai);

            Console.WriteLine("Nhap ten loai hang: ");
            MotLoaiHang.TenLoaiHang = Convert.ToString(Console.ReadLine());

           return MotLoaiHang;
        }

        public static Types.LoaiHang[] NhapNhieuLoaiHang(Types.LoaiHang[] ListLoaiHang)
        {

            Console.WriteLine("Nhap so luong mat hang can vao he thong: ");

            int SoLuongMatHang = Convert.ToInt32(Console.ReadLine());

            Types.LoaiHang[] ListLoaiHangMoi = new Types.LoaiHang[SoLuongMatHang];


            for (int i = 0; i < ListLoaiHangMoi.Length; i++)
            {
                Types.LoaiHang MotLoaiHang = NhapLoaiHang(ListLoaiHang);

                ListLoaiHangMoi[i] = MotLoaiHang;
            }

            return ListLoaiHangMoi;


        }

        public static void XuatListLoaiHang(Types.LoaiHang[] ListLoaiHang)
        {

            int ChieuDaiMang = ListLoaiHang.Length;

            TableDraw.PrintLine();
            TableDraw.PrintRow("Ma Loai Hang", "Ten Loai Hang");
            TableDraw.PrintLine();
            for (int i = 0; i < ChieuDaiMang; i++)
            {
                TableDraw.PrintRow(ListLoaiHang[i].MaLoaiHang, ListLoaiHang[i].TenLoaiHang);
            }

            TableDraw.PrintLine();

        }

    }
}

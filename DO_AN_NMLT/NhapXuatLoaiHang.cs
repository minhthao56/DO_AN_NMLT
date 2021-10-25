using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN_NMLT
{
    class NhapXuatLoaiHang
    {
        public static Types.LoaiHang NhapLoaiHang(Types.LoaiHang[] ListLoaiHang, Types.LoaiHang[] ListLoaiHangMoi = null)
        {

            Types.LoaiHang MotLoaiHang = new Types.LoaiHang();

            Console.WriteLine("---- Nhap cac thong tin cua loai hang----");

            bool LoaiHangDaTonTai = false;
            do
            {
                Console.WriteLine("Nhap ma loai hang: ");
                MotLoaiHang.MaLoaiHang = Convert.ToString(Console.ReadLine());

                if (MotLoaiHang.MaLoaiHang == "")
                {
                    Console.WriteLine("Khong dc de rong - ma loai hang");

                }

                // Kiem tra do loai co ton tai trong list hien tai hay khong
                LoaiHangDaTonTai = Helpers.KiemLoaiHangDaTonTai(ListLoaiHang, MotLoaiHang.MaLoaiHang);

                if (LoaiHangDaTonTai)
                {
                    Console.WriteLine("Ma Loai Hang Da Ton Tai - Vui Long Nhap Ma Loai Hang Khac");
                    MotLoaiHang.MaLoaiHang = "";
                }

                // Check nhap nhieu ton tai trong list moi trong qua trinh nhap
                if (!LoaiHangDaTonTai && ListLoaiHangMoi !=null)
                {

                    LoaiHangDaTonTai = Helpers.KiemLoaiHangDaTonTai(ListLoaiHangMoi, MotLoaiHang.MaLoaiHang);

                    if (LoaiHangDaTonTai)
                    {
                        Console.WriteLine("Ma Loai Hang Da Ton Tai - Vui Long Nhap Ma Loai Hang Khac");
                        MotLoaiHang.MaLoaiHang = "";
                    }


                }




            }
            while (LoaiHangDaTonTai && MotLoaiHang.MaLoaiHang == "");

            do {

                Console.WriteLine("Nhap ten loai hang: ");
                MotLoaiHang.TenLoaiHang = Convert.ToString(Console.ReadLine());

                if (MotLoaiHang.TenLoaiHang == "")
                {
                    Console.WriteLine("Khong dc de rong - ten loai hang");
                }

            } while (MotLoaiHang.TenLoaiHang == "");

           

           return MotLoaiHang;
        }

        public static Types.LoaiHang[] NhapNhieuLoaiHang(Types.LoaiHang[] ListLoaiHang)
        {

            Console.WriteLine("Nhap so luong mat hang can vao he thong: ");

            int SoLuongMatHang = Convert.ToInt32(Console.ReadLine());

            Types.LoaiHang[] ListLoaiHangMoi = new Types.LoaiHang[SoLuongMatHang];


            for (int i = 0; i < ListLoaiHangMoi.Length; i++)
            {
                Console.WriteLine($"-----Nhap loai hang lan {i+ 1} -----");

                Types.LoaiHang MotLoaiHang = NhapLoaiHang(ListLoaiHang, ListLoaiHangMoi);

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

using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN_NMLT
{
    class NhapXuatMatHang
    {

        public static Types.MatHang NhapMatHang( Types.MatHang[] ListMatHang, ref Types.LoaiHang[] ListLoaiHang)
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

                if (DoHangDaTonTai)
                {
                    Console.WriteLine("Do Hang Da Ton Tai - Vui Long Nhap Ma Don Hang Khac");

                }
            }
            while (DoHangDaTonTai);
       
            Console.WriteLine("Nhap ten mat hang: ");
            MotMatHang.TenHang = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Nhap cong ty san xuat: ");
            MotMatHang.CtySanXuat = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Nhap han su dung: ");
            MotMatHang.HanDung = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Nhap nam san xuat: ");
            MotMatHang.NamSanXuat = Convert.ToString(Console.ReadLine());


            do {

                NhapXuatLoaiHang.XuatListLoaiHang(ListLoaiHang);
                if (ListLoaiHang.Length == 0)
                {
                    Console.WriteLine("Danh sach loai hang rong - Vui long tao them loai hang vao danh sach");

                    Actions.FuncThemMotLoaiHang(ref ListLoaiHang);
                }

                Console.WriteLine("Nhap ma loai hang cho don hang hien tai: ");
                MotMatHang.LoaiHang = Convert.ToString(Console.ReadLine());

                MaLoaiKhongHangTonTai = Helpers.KiemTraLoaiTonTaiTruocKhiNhapDonHang(ListLoaiHang, MotMatHang.LoaiHang);

                if (MaLoaiKhongHangTonTai)
                {
                    Console.WriteLine("Ma hang khong ton tai trong danh sanh loai hang");

                    Console.WriteLine("Ban co muon them loai hang moi khong?");

                    string kq = Controllers.ChonYesNo();

                    if(kq == "1")
                    {
                        Actions.FuncThemMotLoaiHang(ref ListLoaiHang);
                        MaLoaiKhongHangTonTai = false;
                    }

                }
            }

            while (MaLoaiKhongHangTonTai);



            return MotMatHang;
        }



        public static Types.MatHang[] NhapNhieuMatHang(Types.MatHang[] ListMatHang, ref Types.LoaiHang[] ListLoaiHang) {

            Console.WriteLine("Nhap so luong mat hang can vao he thong: ");

            int SoLuongMatHang = Convert.ToInt32(Console.ReadLine());

            Types.MatHang[] ListMatHangMoi = new Types.MatHang[SoLuongMatHang];


            for(int i =0; i < ListMatHangMoi.Length; i++)
            {
                Types.MatHang MotMatHang = NhapMatHang(ListMatHang, ref ListLoaiHang);

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

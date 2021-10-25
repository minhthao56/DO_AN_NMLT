using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN_NMLT
{
    class Actions
    {

        // Cac Func Mat Hang
        static void FuncThemMotMatHang(ref Types.MatHang[] ListMatHang,  ref Types.LoaiHang[] ListLoaiHang)
        {
            Types.MatHang MotMatHang = NhapXuatMatHang.NhapMatHang(ListMatHang,ref ListLoaiHang);

            CRUDMatHang.ThemMatHang(MotMatHang, ref ListMatHang);

            Console.WriteLine("---Danh sach don hang them moi---");
            NhapXuatMatHang.XuatListMatHang(ListMatHang);
        }

        static void FuncXemCacMatHangHienTai(ref Types.MatHang[] ListMatHang)
        {
            NhapXuatMatHang.XuatListMatHang(ListMatHang);
        }

        static void FucXoaMotDonHang (ref Types.MatHang[] ListMatHang)
        {
            Console.WriteLine("---Danh sach don hang hien tai---");
            NhapXuatMatHang.XuatListMatHang(ListMatHang);

            CRUDMatHang.XoaMatHang(ref ListMatHang);

            Console.WriteLine("---Danh sach don hang sau khi xoa---");
            NhapXuatMatHang.XuatListMatHang(ListMatHang);

        }

        static void FucSuaMotDonHang(ref Types.MatHang[] ListMatHang, ref Types.LoaiHang[] ListLoaiHang)
        {
            Console.WriteLine("---Danh sach don hang hien tai---");
            NhapXuatMatHang.XuatListMatHang(ListMatHang);

            CRUDMatHang.SuaMatHang(ref ListMatHang, ref ListLoaiHang);

        }

        static void FuncTimKiemDonHang(Types.MatHang[] ListMatHang)
        {

            Console.WriteLine("---Danh sach don hang hien tai---");
            NhapXuatMatHang.XuatListMatHang(ListMatHang);

            Console.WriteLine("Nhap ma hang, ten hang, cong ty san xuat, nam sang xuat, han dung cua don hang: ");

            string TuKhoa = Convert.ToString(Console.ReadLine());

            Types.MatHang[] KetQuaTimKiem = CRUDMatHang.TimKiemMatHang(ListMatHang, TuKhoa);

            Console.WriteLine("---Ket qua tim kiem---: ");
            NhapXuatMatHang.XuatListMatHang(KetQuaTimKiem);



        }

        static void FuncThemNhieuDonHang(ref Types.MatHang[] ListMatHang, ref Types.LoaiHang[] ListLoaiHang)
        {
            Types.MatHang[] ListMatHangMoi = NhapXuatMatHang.NhapNhieuMatHang(ListMatHang, ref ListLoaiHang);

            CRUDMatHang.ThemNhieuMatHang(ListMatHangMoi, ref ListMatHang);

            Console.WriteLine("---Danh sach don hang them moi---");

            NhapXuatMatHang.XuatListMatHang(ListMatHang);


        }


        // Main Func QuanLyCacMatHang
        public static void QuanLyCacMatHang( ref Types.MatHang[] ListMatHang, ref Types.LoaiHang[] ListLoaiHang)
        {
            string Num = "";

            do
            {
                Console.WriteLine("*********************");
                Console.WriteLine("QUAN LY CAC MAT HANG");
                Console.WriteLine("*********************");


                Num = Controllers.QuanLyCacMatHang();

                if (Num == "1")
                {
                    FuncXemCacMatHangHienTai(ref ListMatHang);
                }

                if (Num == "2")
                {
                    FuncThemMotMatHang(ref ListMatHang,  ref ListLoaiHang);
                }

                if(Num == "3")
                {
                    FuncThemNhieuDonHang(ref ListMatHang, ref ListLoaiHang);
                }

                if (Num == "4")
                {
                    FucSuaMotDonHang(ref ListMatHang, ref ListLoaiHang);
                }

                if (Num == "5")
                {
                    FucXoaMotDonHang(ref ListMatHang);

                }
                if(Num == "6")
                {
                    FuncTimKiemDonHang(ListMatHang);
                }

            }
            while (Num != "0");
        }



//==================================================================================================================



        // Cac Func loai hang
        public static void FuncThemMotLoaiHang(ref Types.LoaiHang[] ListLoaiHang)
        {
            Types.LoaiHang MotLoaiHang = NhapXuatLoaiHang.NhapLoaiHang(ListLoaiHang);

            CRUDLoaiHang.ThemLoaiHang(MotLoaiHang, ref ListLoaiHang);

            Console.WriteLine("---Danh sach loai hang them moi---");

            NhapXuatLoaiHang.XuatListLoaiHang(ListLoaiHang);
        }

        static void FuncXemCacLoaiHangHienTai(ref Types.LoaiHang[] ListLoaiHang)
        {
            NhapXuatLoaiHang.XuatListLoaiHang(ListLoaiHang);
        }

        static void FucXoaMotLoaiHang(ref Types.LoaiHang[] ListLoaiHang, ref Types.MatHang[] ListMatHang)
        {
            Console.WriteLine("---Danh sach loai hang hien tai---");
            NhapXuatLoaiHang.XuatListLoaiHang(ListLoaiHang);

            CRUDLoaiHang.XoaLoaiHang(ref ListLoaiHang, ref ListMatHang);

            Console.WriteLine("---Danh sach loai hang sau khi xoa---");
            NhapXuatLoaiHang.XuatListLoaiHang(ListLoaiHang);

        }

        static void FucSuaMotLoaiHang(ref Types.LoaiHang[] ListLoaiHang)
        {
            Console.WriteLine("---Danh sach loai hang hien tai---");
            NhapXuatLoaiHang.XuatListLoaiHang(ListLoaiHang);

            CRUDLoaiHang.SuaLoaiHang(ref ListLoaiHang);




        }

        static void FuncTimKiemLoaiHang(Types.LoaiHang[] ListLoaiHang)
        {

            Console.WriteLine("---Danh sach loai hang hien tai---");
            NhapXuatLoaiHang.XuatListLoaiHang(ListLoaiHang);

            Console.WriteLine("Nhap ma hang hoac ten hang cua loai hang: ");

            string TuKhoa = Convert.ToString(Console.ReadLine());

            Types.LoaiHang[] KetQuaTimKiem = CRUDLoaiHang.TimKiemLoaiHang(ListLoaiHang, TuKhoa);

            Console.WriteLine("---Ket qua tim kiem---: ");
            NhapXuatLoaiHang.XuatListLoaiHang(KetQuaTimKiem);



        }

        static void FuncThemNhieuLoaiHang(ref Types.LoaiHang[] ListLoaiHang)
        {
            Types.LoaiHang[] ListLoaiHangMoi = NhapXuatLoaiHang.NhapNhieuLoaiHang(ListLoaiHang);

            CRUDLoaiHang.ThemNhieuLoaiHang(ListLoaiHangMoi, ref ListLoaiHang);

            Console.WriteLine("---Danh sach loai hang them moi---");

            NhapXuatLoaiHang.XuatListLoaiHang(ListLoaiHang);


        }


        //Main Action Quan Ly Cac Loai Hang
        public static void QuanLyCacLoaiHang(ref Types.LoaiHang[] ListLoaiHang, ref Types.MatHang[] ListMatHang)
        {
            string Num = "";

            do
            {
                Console.WriteLine("******************");
                Console.WriteLine("QUAN LY LOAI HANG");
                Console.WriteLine("******************");

                Num = Controllers.QuanLyCacLoaiHang();

                if (Num == "1")
                {
                    FuncXemCacLoaiHangHienTai(ref ListLoaiHang);
                }

                if (Num == "2")
                {
                    FuncThemMotLoaiHang(ref ListLoaiHang);
                }

                if (Num == "3")
                {
                    FuncThemNhieuLoaiHang(ref ListLoaiHang);
                }

                if (Num == "4")
                {
                    FucSuaMotLoaiHang(ref ListLoaiHang);
                }

                if (Num == "5")
                {
                    FucXoaMotLoaiHang(ref ListLoaiHang, ref ListMatHang);

                }
                if (Num == "6")
                {
                    FuncTimKiemLoaiHang(ListLoaiHang);
                }

            }
            while (Num != "0");
        }

    }
}

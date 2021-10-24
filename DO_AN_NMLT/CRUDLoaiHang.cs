using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN_NMLT
{
    class CRUDLoaiHang
    {

        public static void XemCacLoaiHangHienTai(Types.LoaiHang[] ListLoaiHang)
        {

            NhapXuatLoaiHang.XuatListLoaiHang(ListLoaiHang);

        }


        public static void ThemLoaiHang(Types.LoaiHang MotLoaHang, ref Types.LoaiHang[] ListLoaiHang)
        {

            int ChieuDaiMang = ListLoaiHang.Length;

            Types.LoaiHang[] NewListLoaiHang = new Types.LoaiHang[ChieuDaiMang + 1];

            if (ChieuDaiMang > 0)
            {
                for (int i = 0; i < ChieuDaiMang; ++i)
                {
                    NewListLoaiHang[i] = ListLoaiHang[i];
                }
            }

            NewListLoaiHang[ChieuDaiMang] = MotLoaHang;

            ListLoaiHang = NewListLoaiHang;

        }



        public static void ThemNhieuLoaiHang(Types.LoaiHang[] ListLoaiHangMoi, ref Types.LoaiHang[] ListLoaiHangCu)
        {

            int ChieuDaiMangCu = ListLoaiHangCu.Length;

            int ChieuDaiMangMoi = ListLoaiHangMoi.Length;

            if (ChieuDaiMangMoi != 0)
            {

                Types.LoaiHang[] NewListLoaiHang = new Types.LoaiHang[ChieuDaiMangCu + ChieuDaiMangMoi];

                if (ChieuDaiMangCu != 0)
                {

                    int j = 0;

                    for (int i = 0; i < NewListLoaiHang.Length; i++)
                    {

                        if (i < ChieuDaiMangCu)
                        {
                            NewListLoaiHang[i] = ListLoaiHangCu[i];
                        }
                        else
                        {

                            NewListLoaiHang[i] = ListLoaiHangMoi[j];

                            j++;
                        }

                    }
                    ListLoaiHangCu = NewListLoaiHang;
                }
                else
                {
                    ListLoaiHangCu = ListLoaiHangMoi;
                }

            }
            else
            {
                Console.WriteLine("Khong co phan tu moi de them vao!");
            }

            Console.WriteLine("Da them mang moi thang cong =))");

        }



        public static void XoaLoaiHang(ref Types.LoaiHang[] ListLoaiHang)
        {

            Console.WriteLine("------");
            Console.WriteLine("Nhap ma loai hang can xoa: ");
            string MaHang = Convert.ToString(Console.ReadLine());

            int ChieuDaiMang = ListLoaiHang.Length;

            int ViTriCanXoa = -1;

            // Tim vi tri can xoa
            for (int i = 0; i < ChieuDaiMang; i++)
            {
                if (MaHang == ListLoaiHang[i].MaLoaiHang)
                {

                    ViTriCanXoa = i;
                    break;

                }
            }

            // Xoa phan tu trong mang
            if (ViTriCanXoa != -1)
            {
                for (int i = ViTriCanXoa; i < ChieuDaiMang - 1; i++)
                {
                    ListLoaiHang[i] = ListLoaiHang[i + 1];
                }

                Types.LoaiHang[] NewListLoaiHang = new Types.LoaiHang[ChieuDaiMang - 1];

                for (int i = 0; i < NewListLoaiHang.Length; i++)
                {

                    NewListLoaiHang[i] = ListLoaiHang[i];
                }

                ListLoaiHang = NewListLoaiHang;

                Console.WriteLine("Xoa Thanh cong");
            }
            else
            {
                Console.WriteLine("Khong tim thay - Xoa that bai");
            }

        }

        public static void SuaLoaiHang(ref Types.LoaiHang[] ListLoaiHang)
        {

            Console.WriteLine("------");
            Console.WriteLine("Nhap ma loai hang can chinh sua: ");
            string MaHang = Convert.ToString(Console.ReadLine());


            int VitriUpdate = -1;

            // Tim phan tu can update
            for (int i = 0; i < ListLoaiHang.Length; i++)
            {
                if (MaHang == ListLoaiHang[i].MaLoaiHang)
                {
                    VitriUpdate = i;
                }
            }


            // Update don hang
            if (VitriUpdate != -1)
            {
                string Num = "0";
                Console.WriteLine("Chon cot ma ban muon chinh sua: ");

                do
                {
                    Num = Controllers.QuanLyChonCotChinhSuLoaiHang();

                    if (Num == "1")
                    {
                        Console.WriteLine("Nhap Ma Loai Hang Moi: ");
                        string Moi = Convert.ToString(Console.ReadLine());
                        ListLoaiHang[VitriUpdate].MaLoaiHang = Moi;

                    }
                    if (Num == "2")
                    {
                        Console.WriteLine("Nhap Ten Loai Hang Moi: ");
                        string Moi = Convert.ToString(Console.ReadLine());
                        ListLoaiHang[VitriUpdate].TenLoaiHang = Moi;
                    }

                    if (Num == "3")
                    {

                        Types.LoaiHang MotLoaiHang = NhapXuatLoaiHang.NhapLoaiHang(ListLoaiHang);

                        ListLoaiHang[VitriUpdate] = MotLoaiHang;

                    }

                    Console.WriteLine("---Danh sach loai hang sau khi chinh sua---");
                    NhapXuatLoaiHang.XuatListLoaiHang(ListLoaiHang);
                }

                while (Num != "0");

            }
            else
            {
                Console.WriteLine("Khong the update - Khong tim thay loai hang");
            }

        }

        public static Types.LoaiHang[] TimKiemLoaiHang(Types.LoaiHang[] ListLoaiHang, string TuKhoa)
        {

            Types.LoaiHang[] ListLoaiHangDaTimThay = { };


            for (int i = 0; i < ListLoaiHang.Length; i++)
            {

                if (ListLoaiHang[i].MaLoaiHang == TuKhoa || ListLoaiHang[i].TenLoaiHang == TuKhoa)
                {
                    ThemLoaiHang(ListLoaiHang[i], ref ListLoaiHangDaTimThay);
                }

            }

            return ListLoaiHangDaTimThay;

        }

    }
}

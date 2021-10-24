using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN_NMLT
{
    class CRUDMatHang
    {


        public static void XemCacMatHangHienTai(Types.MatHang[] ListMatHang) {

            NhapXuatMatHang.XuatListMatHang(ListMatHang);
            
        }

        public static void ThemMatHang(Types.MatHang MotMatHang, ref Types.MatHang[] ListMatHang) {

            int ChieuDaiMang = ListMatHang.Length;

            Types.MatHang[] NewListMatHang = new Types.MatHang[ChieuDaiMang + 1];

            if (ChieuDaiMang > 0)
            {
                for (int i = 0; i < ChieuDaiMang; ++i)
                {
                    NewListMatHang[i] = ListMatHang[i];
                }
            }

            NewListMatHang[ChieuDaiMang] = MotMatHang;

            ListMatHang = NewListMatHang;

        }


        public static void ThemNhieuMatHang(Types.MatHang[] ListMatHangMoi, ref Types.MatHang[] ListMatHangCu)
        {

            int ChieuDaiMangCu = ListMatHangCu.Length;

            int ChieuDaiMangMoi = ListMatHangMoi.Length;

            if(ChieuDaiMangMoi != 0)
            {

                Types.MatHang[] NewListMatHang = new Types.MatHang[ChieuDaiMangCu + ChieuDaiMangMoi];

                if (ChieuDaiMangCu !=0)
                {

                    int j = 0;

                    for (int i = 0; i < NewListMatHang.Length; i++)
                    {

                        if (  i < ChieuDaiMangCu)
                        {
                            NewListMatHang[i] = ListMatHangCu[i];
                        }
                        else
                        {

                            NewListMatHang[i] = ListMatHangMoi[j];

                            j++;
                        }

                    }
                    ListMatHangCu = NewListMatHang;
                }
                else
                {
                    ListMatHangCu = ListMatHangMoi;
                }

            }
            else
            {
                Console.WriteLine("Khong co phan tu moi de them vao");
            }

            Console.WriteLine("Da them mang moi thang cong =))");

        }




        public static void XoaMatHang( ref Types.MatHang[] ListMatHang ) {

            Console.WriteLine("------");
            Console.WriteLine("Nhap ma don hang can xoa: ");
            string MaHang = Convert.ToString(Console.ReadLine());

            int ChieuDaiMang = ListMatHang.Length;

            int ViTriCanXoa = -1;

            // Tim vi tri can xoa
            for (int i = 0; i < ChieuDaiMang ; i++)
            {
                if(MaHang == ListMatHang[i].Ma)
                {

                    ViTriCanXoa = i;
                    break;

                }
            }

            // Xoa phan tu trong mang
            if(ViTriCanXoa != -1)
            {
                for (int i = ViTriCanXoa; i < ChieuDaiMang - 1; i++)
                {
                    ListMatHang[i] = ListMatHang[i + 1];
                }

                Types.MatHang[] NewListMatHang = new Types.MatHang[ChieuDaiMang - 1];

                for (int i = 0; i < NewListMatHang.Length; i++)
                {

                    NewListMatHang[i] = ListMatHang[i];
                }

                ListMatHang = NewListMatHang;

                Console.WriteLine("Xoa Thanh cong");
            }
            else
            {

                Console.WriteLine("Khong tim thay - Xoa that bai");
            }

        }


        public static void SuaMatHang(ref Types.MatHang[] ListMatHang, ref Types.LoaiHang[] ListLoaiHang) {

            Console.WriteLine("------");
            Console.WriteLine("Nhap ma don hang can chinh sua: ");
            string MaHang = Convert.ToString(Console.ReadLine());

     
            int VitriUpdate = -1;

            // Tim phan tu can update
            for (int i = 0; i < ListMatHang.Length; i++)
            {
                if(MaHang == ListMatHang[i].Ma)
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
                    Num = Controllers.QuanLyChonCotChinhSu();

                    if (Num == "1")
                    {
                        Console.WriteLine("Nhap Ma Hang Moi: ");
                        string Moi = Convert.ToString(Console.ReadLine());
                        ListMatHang[VitriUpdate].Ma = Moi;

                    }
                    if (Num == "2")
                    {
                        Console.WriteLine("Nhap Ten Don Hang Moi: ");
                        string Moi = Convert.ToString(Console.ReadLine());
                        ListMatHang[VitriUpdate].TenHang = Moi;
                    }

                    if (Num == "3")
                    {
                        Console.WriteLine("Nhap Cty San Xuat Moi: ");
                        string Moi = Convert.ToString(Console.ReadLine());
                        ListMatHang[VitriUpdate].CtySanXuat = Moi;
                    }

                    if (Num == "4")
                    {
                        Console.WriteLine("Nhap Han Dung Moi: ");
                        string Moi = Convert.ToString(Console.ReadLine());
                        ListMatHang[VitriUpdate].HanDung = Moi;
                    }

                    if (Num == "5")
                    {
                        Console.WriteLine("Nhap Nam San Xuat Moi: ");
                        string Moi = Convert.ToString(Console.ReadLine());
                        ListMatHang[VitriUpdate].NamSanXuat = Moi;
                    }
                    if (Num == "6")
                    {
                        Console.WriteLine("Nhap  Loai Hang Moi: ");
                        string Moi = Convert.ToString(Console.ReadLine());
                        ListMatHang[VitriUpdate].LoaiHang = Moi;
                    }

                    if (Num == "7") {

                        Types.MatHang MoMatHang = NhapXuatMatHang.NhapMatHang(ListMatHang, ref ListLoaiHang);

                        ListMatHang[VitriUpdate] = MoMatHang;

                    }

                    Console.WriteLine("---Danh sach don hang sau khi chinh sua---");
                    NhapXuatMatHang.XuatListMatHang(ListMatHang);
                }

                while (Num != "0");



            }
            else
            {
                Console.WriteLine("Khong the update - Khong tim thay don hang");
            }

        }


        public static Types.MatHang[] TimKiemMatHang( Types.MatHang[] ListMatHang, string TuKhoa) {

            Types.MatHang[] ListMatHangDaTimThay = { };

           
            for(int i = 0; i <ListMatHang.Length; i++)
            {

                if (ListMatHang[i].Ma == TuKhoa || ListMatHang[i].TenHang == TuKhoa || ListMatHang[i].NamSanXuat == TuKhoa || ListMatHang[i].CtySanXuat == TuKhoa)
                {
                    ThemMatHang( ListMatHang[i], ref ListMatHangDaTimThay);
                }

            }

            return ListMatHangDaTimThay;
        
        }

    }
}

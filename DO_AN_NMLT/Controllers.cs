using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN_NMLT
{
    class Controllers
    {

        static void PrintTitle(int To, int From)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Voi long chon so tu " + To + " ==> " + From);
            Console.WriteLine("-------------------------------------------");

        }


        public static string MainControl()
        {
            PrintTitle(0, 2);

            Console.WriteLine("1. Quan ly cac mat hang");
            Console.WriteLine("2. Quan ly cac loai");
            Console.WriteLine("0. Thoat");

            string Num = Convert.ToString(Console.ReadLine());

            return Num;



        }

        public static string QuanLyCacMatHang()
        {
            PrintTitle(0, 6);

            Console.WriteLine("1. Xem cac mat hang hien tai");
            Console.WriteLine("2. Them 1 don hang");
            Console.WriteLine("3. Them nhieu don hang cung 1 luc");
            Console.WriteLine("4. Chinh sua 1 don hang");
            Console.WriteLine("5. Xoa 1 don hang");
            Console.WriteLine("6. Tim cac don hang");
            Console.WriteLine("0. Tro ve man hinh chinh");

            string Num = Convert.ToString(Console.ReadLine());

            return Num;
        }


        public static string QuanLyChonCotChinhSu()
        {

            PrintTitle(0, 7);
            Console.WriteLine("1. Ma Hang");
            Console.WriteLine("2. Ten Don Hang");
            Console.WriteLine("3. Cty San Xuat");
            Console.WriteLine("4. Han dung");
            Console.WriteLine("5. Nam San Xuat");
            Console.WriteLine("6. Loai Hang");
            Console.WriteLine("7. Chinh sua toan bo thong tin don hang");
            Console.WriteLine("0. Thoat chinh sua don hang");

            string Num = Convert.ToString(Console.ReadLine());
            return Num;
        }




        public static string QuanLyCacLoaiHang()
        {
            PrintTitle(0, 6);

            Console.WriteLine("1. Xem cac loai hang hien tai");
            Console.WriteLine("2. Them 1 loai hang");
            Console.WriteLine("3. Them nhieu loai hang cung 1 luc");
            Console.WriteLine("4. Chinh sua 1 loai hang");
            Console.WriteLine("5. Xoa 1 loai hang");
            Console.WriteLine("6. Tim cac loai hang");
            Console.WriteLine("0. Tro ve man hinh chinh");

            string Num = Convert.ToString(Console.ReadLine());

            return Num;
        }


        public static string QuanLyChonCotChinhSuLoaiHang()
        {

            PrintTitle(0, 3);
            Console.WriteLine("1. Ma Loai Hang");
            Console.WriteLine("2. Ten Loai Hang");
            Console.WriteLine("3. Chinh sua toan bo thong tin loai hang");
            Console.WriteLine("0. Thoat chinh sua loai hang");

            string Num = Convert.ToString(Console.ReadLine());
            return Num;
        }


        public static string ChonYesNo()
        {
            PrintTitle(1, 2);
            Console.WriteLine("1. Dong y");
            Console.WriteLine("2. Khong dong y");

            string Num = Convert.ToString(Console.ReadLine());
            return Num;
        }


    }
}

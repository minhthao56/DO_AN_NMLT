using System;

namespace DO_AN_NMLT
{
    class Program
    {
        static void Main(string[] args)
        {

            Types.MatHang[] ListMatHang = { };
            Types.LoaiHang[] LisLoaiHang = { };


            string Num = "";

            do
            {
                Console.Clear();
                Console.WriteLine("***********************************************");
                Console.WriteLine("CHAO MUNG BAN DEN VOI PHAN MEN QUAN LI DON HANG");
                Console.WriteLine("***********************************************");


                Num = Controllers.MainControl();

                if (Num == "1")
                {
                    Actions.QuanLyCacMatHang(ref ListMatHang, ref LisLoaiHang);
                }

                if(Num == "2")
                {
                    Actions.QuanLyCacLoaiHang( ref LisLoaiHang, ref ListMatHang);
                }

            }
            while (Num != "0");

        }
    }
}

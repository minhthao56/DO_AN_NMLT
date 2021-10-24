using System;
using System.Collections.Generic;
using System.Text;

namespace DO_AN_NMLT
{
    class Helpers
    {
        public static bool KiemDonHangDaTonTai(Types.MatHang[] ListMatHangHienTai, string MaDonHang) {

            bool isTrue = false;

            for(int i = 0; i < ListMatHangHienTai.Length; i++)
            {
                if (ListMatHangHienTai[i].Ma == MaDonHang)
                {
                    isTrue = true;
                    break;
                }
            }

            return isTrue;
        
        
        }


        public static bool KiemLoaiHangDaTonTai(Types.LoaiHang[] ListLoaiHangHienTai, string MaLoaiHang)
        {

            bool isTrue = false;

            for (int i = 0; i < ListLoaiHangHienTai.Length; i++)
            {
                if (ListLoaiHangHienTai[i].MaLoaiHang == MaLoaiHang)
                {
                    isTrue = true;
                    break;
                }
            }

            return isTrue;


        }

   
    
        public static bool KiemTraLoaiTonTaiTruocKhiNhapDonHang(Types.LoaiHang[] ListLoaiHangHienTai, string MaLoaiHang)
        {
            bool MaLoaiHangKhongTonTai = true;

          
                for (int i = 0; i < ListLoaiHangHienTai.Length; i ++)
                {
                    if (ListLoaiHangHienTai[i].MaLoaiHang == MaLoaiHang)
                    {
                        MaLoaiHangKhongTonTai = false;
                        break;
                    }
                }
            

            return MaLoaiHangKhongTonTai;
           
          
        }
        
    }
}

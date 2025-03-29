using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    public class GiangVien
    {
        //thuoc tinh
        string HoTen;
        int SoNhomHD;

        public string hoten { get => HoTen; set => HoTen = value; }
        public int sonhom { get => SoNhomHD; set => SoNhomHD = value; }
        //phuong thuc khoi tao
        public GiangVien()
        {
            hoten=string.Empty;
            sonhom = 0;
        }
        public GiangVien(string HoTen,int SoNhomHD)
        {
            sonhom= SoNhomHD;
            hoten= HoTen;
        }

        //phuong thuc xu li
        public void Xuat()
        {
            Console.WriteLine("{0,20} {1,15}",HoTen,SoNhomHD);
        }


    }
}

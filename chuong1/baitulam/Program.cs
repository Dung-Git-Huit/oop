using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    internal class Program
    {
        


        static void Main(string[] args)
        {
        //    HoaDon hoadon1 = new HoaDon();
        //    hoadon1.Nhap();


        //    hoadon1.Xuat();

            KhoaHoc khoahoc1=new KhoaHoc();
            khoahoc1.Nhap();
            Console.Clear();
            
            khoahoc1.Xuat();
            Console.ReadLine();
        }
    }
}

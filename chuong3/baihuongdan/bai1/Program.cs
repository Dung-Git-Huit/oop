using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Khoa k=new Khoa();
            k.docDS();
            k.XuatDsGiangVien();
            Console.WriteLine("\nTong so nhom huong dan:{0}",k.TinhTongSoNhomHD());
            Console.WriteLine("\nsap xep giam dan so nhom");
            k.SXGiamDanSoNhom();
            k.XuatDsGiangVien();
            Console.WriteLine("\nsap xep tang dan theo ho ten:");
            k.SXTangDanHoTen();
            k.XuatDsGiangVien();

            Console.WriteLine("\nnhom lon hon 1");
            k.LocSoNhomLonHon1();
            k.XuatDsGiangVien();
            Console.ReadKey();

        }
    }
}

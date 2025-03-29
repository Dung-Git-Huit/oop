using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSach danhSach = new DanhSach();
            danhSach.docDs();
            Console.WriteLine("\n Danh sach  nhan vien:");
            danhSach.xuatDs();
            Console.Write("\nTong luong:{0:n2}",danhSach.tongLuong());
            Console.WriteLine("\nDs sau khi xoa nv so ngay lam nho hon 10:");
            danhSach.xoaNlvNhoHon10();
            danhSach.xuatDs();
            Console.WriteLine("\nloc lanh dao");
            danhSach.locLanhDao();
            danhSach.xuatDs();
            
            Console.WriteLine("\n Sap xep giam theo luong:");
            danhSach.sxGiamLuong();
            danhSach.xuatDs();
            Console.WriteLine("\n loc theo phong:");
            danhSach.loctheoPhong();
            danhSach.xuatDs();


            Console.ReadKey();
        }
    }
}

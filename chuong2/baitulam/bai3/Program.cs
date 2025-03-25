using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bai3
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Tạo đối tượng học sinh
            HocSinh hs = new HocSinh();

            Console.WriteLine("==== NHẬP THÔNG TIN HỌC SINH ====");
            hs.Nhap();

            Console.Clear(); // Xoá màn hình sau khi nhập xong

            Console.WriteLine("==== THÔNG TIN HỌC SINH VỪA NHẬP ====");
            hs.Xuat();

            Console.WriteLine("\n==== DANH SÁCH MÔN HỌC ĐẠT ====");
            hs.XuatMonHocDat();

            Console.WriteLine("\n==== KẾT THÚC CHƯƠNG TRÌNH ====");
            Console.ReadKey();
        }
    }
}

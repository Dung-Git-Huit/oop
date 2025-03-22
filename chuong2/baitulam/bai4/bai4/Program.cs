using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DSThiSinh ds=new DSThiSinh();
            ds.Nhapds();
            ds.Xuatds();
            ds.dsDau().Xuatds();
            Console.WriteLine($"\nTổng thí sinh đậu:{ds.tongDau()}");
            Console.WriteLine($"Tổng thí sinh rớt:{ds.tongRot()}");

            Console.WriteLine("Nhập mã thí sinh cần tìm:");
            string m=( Console.ReadLine() );
            ds.timTheoMa(m);
            Console.WriteLine("\n Danh sách sau sắp xếp giảm dần theo điểm tổng kết");
            ds.sxgiamDiemTong();

            Console.ReadKey();
        }
    }
}

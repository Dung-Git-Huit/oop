using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NuocGiaiKhat nuoc = new NuocGiaiKhat();
            //nuoc.Nhap();


            //Console.Clear();


            //nuoc.Xuat();


            HinhChuNhat hcn1 = new HinhChuNhat();
            hcn1.Nhap();
            Console.Clear();
            hcn1.Xuat();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Thay doi kich thuoc theo tx , ty");
            Console.WriteLine("Nhap tx:");
            int tx=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ty:");
            int ty=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap kieu thay doi (1 - tang, 0 - giam:");
            int kieu=int.Parse(Console.ReadLine());
            hcn1.changeSize(tx, ty, kieu);
            hcn1.Xuat();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Thay doi kich thuoc theo hinh chu nhat khac");
            HinhChuNhat hcn2 = new HinhChuNhat();
            Console.WriteLine("Nhap hinh chu nhat thu 2 de thay doi:");
            hcn2.Nhap();
            Console.WriteLine("Nhap kieu thay doi (1 - tang, 0 - giam:");
            kieu=int.Parse(Console.ReadLine());
            hcn1.changeSize(hcn2,kieu);
            hcn1.Xuat();
            Console.ReadKey();
        }
    }
}

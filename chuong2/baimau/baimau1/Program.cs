using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace baimau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhanSo a = new PhanSo();
            a.Tuso = 3;
            a.Mauso = 9;
            a.Toigian();
           
            a.Xuat();


            PhanSo b = new PhanSo(7,2);
          
            PhanSo c =a.Tinhtong(b);
            c.Xuat();

            Console.Clear();
            //danh sach
            DanhSachPhanSo ds = new DanhSachPhanSo();
            ds.Nhapds();
            ds.Xuatds();
            Console.WriteLine("Toi gian danh sach:");
            ds.ToiGianDs();
            ds.Xuatds();

            //tim kiem 
            Console.WriteLine("Nhap phan so can tim kiem:");
            PhanSo p = new PhanSo();
            p.Nhap();
            if (ds.SearchPS(p) == true) {
                Console.WriteLine("tim thay !");
            }
            else
            {
                Console.WriteLine("khong tim thay!");
            }


            Console.WriteLine("Danh sach sau khi sap xep:");
            DanhSachPhanSo ds1=ds.SortGiatri();
            ds1.Xuatds();

            Console.WriteLine("Danh sach phan so lon hon 1:");
            DanhSachPhanSo ds2=ds.Locdulieu();
            ds2.Xuatds();

            Console.WriteLine("phan so lon nhat trong danh sach:");
            PhanSo ps=ds.MaxPhanso();
            ps.Xuat();

            Console.WriteLine("Danh sach 3 phan so lon nhat");
            DanhSachPhanSo ds3=ds.Top3ps();
            ds3.Xuatds();
            
            Console.ReadLine();

        }
    }
}

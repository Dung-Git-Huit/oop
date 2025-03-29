using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KhuTro kt=new KhuTro();
            kt.docfile();
            kt.xuatkt();
          
            Console.WriteLine("sap xep phong tro theo so luong khach:");
            kt.sapxepGiam();
            kt.xuatkt();
            PhongTro phongTro = new PhongTro();
            Console.WriteLine("\tPhong max su dung dien:");
            phongTro=kt.timphongMaxDien();
            phongTro.xuat();
           
            Console.ReadKey();
            
        }
    }
}

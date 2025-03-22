using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baimau2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------nhan vien--------
            //NhanVien nVien = new NhanVien();
            //nVien.Nhap();
            //nVien.Xuat();

            //---------danh sach nhan vien-------
            DanhSachNhanVien danhsach = new DanhSachNhanVien();
            danhsach.Nhapds();
            Console.Clear();
            danhsach.Xuatds();

            //in tong luong cua nhan vien trong danh sach
            Console.WriteLine($"\n tong luong nhan vien trong danh sach:{danhsach.TinhTongLuong():N2}Vnd.");

            //tim nhan vien  luong cao nhat

            Console.WriteLine("Nhan vien co luong cao nhat:");
            NhanVien nvmax = new NhanVien();
            nvmax=danhsach.TimNVmaxLuong();
            nvmax.Xuat();
            //tim nhieu nhan vien co luong cao nhat

           
            DanhSachNhanVien dsmax = danhsach.TimDSNVLuongCaoNhat();
            dsmax.Xuatds();
            //sap xep nhan vien
            Console.WriteLine("Danh sach nhan vien sau khi sap xep:");
            DanhSachNhanVien dsSapxep = danhsach.sort_Giatri();
            dsSapxep.Xuatds();

            Console.ReadLine();


            
        }
    }
}

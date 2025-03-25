using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    public class HoaDon
    {
        //thuoc tinh
        string maHoaDon, tenKhachHang;
        List<ChiTietHoaDon> list;

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public List<ChiTietHoaDon> List
        {
            get => list; set => list = value;
        }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        //phuong thuc khoi tao
        public HoaDon()
        {
            MaHoaDon = maHoaDon;
            TenKhachHang = tenKhachHang;
            List = new List<ChiTietHoaDon>();
        }
        public HoaDon(string maHoaDon, string tenKhachHang, List<ChiTietHoaDon> list)
        {
            MaHoaDon = maHoaDon;
            TenKhachHang = tenKhachHang;
            List = list;

        }
        //phuong thuc xu li
        public void NhapHd()
        {
            Console.WriteLine("Nhap ma hoa don:");
            MaHoaDon = Console.ReadLine();
            Console.WriteLine("Nhap ten khach hang:");
            TenKhachHang = Console.ReadLine();
            Console.WriteLine("So chi tiet hoa don:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap danh sach chi  tiet don hang:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap chi tiet hoa don thu {0}", i + 1);
                ChiTietHoaDon ct = new ChiTietHoaDon();
                ct.Nhap();
                list.Add(ct);
            }

        }
        public double Tongtien()
        {
            return list.Sum(t => t.thanhTien());
        }
       public void xuathd()
        {
            Console.WriteLine($"Ma hoa don:{MaHoaDon}");
            Console.WriteLine($"Ten khach hang:{TenKhachHang}");
            Console.WriteLine($"Gia tri hoa don:{Tongtien()}");
            Console.WriteLine($"Chi tiet hoa don:");
            foreach (ChiTietHoaDon ct in list)
            {
                ct.Xuat();
            }

        }
        public void sapxepGiamTheoTt()
        {
           
           List.OrderByDescending(t=>t.thanhTien()).ToList();
        }
        public void maxThanhTien()
        {
            double max=List.Max(t=>t.thanhTien());
            ChiTietHoaDon ct=List.FirstOrDefault(t=>t.thanhTien()==max);
            ct.Xuat();
        }
    }
}

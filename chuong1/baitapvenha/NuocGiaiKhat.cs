using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NuocGiaiKhat
    {
        string tenHang, donViTinh;
        int soLuong;
        double donGia;
        public static double thueVat = 0.1;

        //property
        public string TenHang { get => tenHang; set => tenHang = value; }
        public string DVT
        {
            get
            {
                return donViTinh;
            }
            set
            {
                if (value == "Ket" || value == "Thung" || value == "Chai" || value == "Lon")
                {
                    donViTinh = value;
                }
                else
                {
                    value = "Ket";
                }
            }
        }

        public int SL
        {
            get
            {
                return soLuong;
            }
            set
            {
                if (value >= 0)
                {
                    soLuong = value;
                }
                else
                {
                    Console.WriteLine("So luong khong hop le");
                }
            }
        }

        public double Dg
        {
            get
            {
                return donGia;
            }
            set
            {
                if (value >= 0)
                {
                    donGia = value;
                }
                else
                {
                    Console.WriteLine("Don gia khong hop le");
                }
            }
        }

        //phuong thuc khoi tao
        public NuocGiaiKhat()
        {
            TenHang = "cocacola";
            DVT = "Chai";
            Dg = 10;
            SL = 20;

        }
        public NuocGiaiKhat(string tenHang, string donViTinh, int soLuong, double donGia)
        {
            this.TenHang = tenHang;
            this.DVT = donViTinh;
            this.SL = soLuong;
            this.Dg = donGia;

        }


        //phuong thuc xu li
        public double thanhTien()
        {
            if (DVT == "Ket" || DVT == "Thung")
            {
                return SL * Dg * (1 + thueVat);
            }
            else if (DVT == "Chai")
            {
                return SL * (Dg / 20) * (1 + thueVat);
            }
            else if (DVT == "Lon")
            {
                return SL * (Dg / 24) * (1 + thueVat);
            }
            else
            {
                return 0;
            }
        }
          public void Nhap()
        {
            Console.WriteLine("Nhap thong tin mat hang nuoc giai khat");
            Console.WriteLine("Nhap ten mat hang");
            TenHang=Console.ReadLine();
            Console.WriteLine("Nhap don vi tinh");
            DVT = Console.ReadLine();
            Console.WriteLine("Nhap so luong");
            SL=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap don gia");
            Dg = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("xuat thong tin");
            Console.WriteLine($"Ten mat hang:{TenHang}");
            Console.WriteLine($"Don vi tinh:{DVT}");
            Console.WriteLine($"So luong:{SL}");
            Console.WriteLine($"Don gia:{Dg}");
            Console.WriteLine($"Thanh tien:{thanhTien():F2}VND");
        }
    }
}
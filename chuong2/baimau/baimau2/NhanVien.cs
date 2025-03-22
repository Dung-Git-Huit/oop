using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baimau2
{
    public class NhanVien
    {
        //thuoc tinh
        string maSo, tenNV;
        float heSoLuong;
        int namVaoLam;
        public static int MucLuongToiThieu = 2340000;

        public string MaSo { get => maSo; set => maSo = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public float HeSoLuong
        {
            get { return heSoLuong; }
            set
            {
                if (value < 0)
                {
                    heSoLuong = 0;
                }
                else
                {
                    heSoLuong = value;
                }
            }
        }
        public int NamVaoLam
        {
            get => namVaoLam;
            set
            {
                if (value < 0 || value > DateTime.Today.Year)
                {
                    namVaoLam = DateTime.Today.Year;
                }
                else
                {
                    namVaoLam = value;
                }
            }
        }

        public NhanVien()
        {
            MaSo = "32";
            TenNV = "Nguyen Van A";
            HeSoLuong = 2.34f;


        }
        public NhanVien(string MaSo,string TenNV,float HeSoLuong,int NamVaoLam)
        {
            this.MaSo = MaSo;
            this.TenNV = TenNV;
            this.NamVaoLam=NamVaoLam;
        }
        //phuong thuc xu li
        public float TinhLuongCoBan()
        {
            return HeSoLuong*MucLuongToiThieu;
        }
        public float TinhHeSoPCTN()
        {
            return (DateTime.Today.Year - NamVaoLam) / 100;
        }
        
        public float TinhLuong()
        {
            return TinhLuongCoBan()*(1+TinhHeSoPCTN());
        }
        public void Nhap()
        {
            Console.Write("Nhap Ma so:");
            MaSo=Console.ReadLine();
            Console.Write("Nhap ten:");
            TenNV=Console.ReadLine();
            Console.Write("Nhap he so luong:");
            HeSoLuong=float.Parse(Console.ReadLine());
            Console.Write("Nhap nam vao lam:");
            NamVaoLam=int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Ma so nhan vien:{0}",MaSo);
            Console.WriteLine("Ten nhan vien:{0}",TenNV);
            Console.WriteLine("He so luong:{0:F2}",HeSoLuong);
            Console.WriteLine("Nam vao lam:{0}",NamVaoLam);
            Console.WriteLine($"Luong cua nhan vien:{TinhLuong():N2}vnd");

        }
    }
}

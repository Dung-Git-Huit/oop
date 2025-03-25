using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    public class ChiTietHoaDon
    {
        //thuoc tinh
        public static double Vat = 0.1;
        string maSp, tenSp;
        double giaBan;
        int soLuongBan;
        //property
        public string ma
        {
            get { return MaSp; }
            set
            {
                if (value.StartsWith("SP") || value.Length == 6)
                {
                    MaSp = value;
                }
                else
                {
                    MaSp = "SP0000";
                }
            }
        }
       
        public double GiaBan
        {
            get { return giaBan; }
            set
            {
                if (giaBan > 0)
                    giaBan = value;
                else
                    giaBan = 1;

            }
        }
        public int SoLuongBan
        {
            get { return soLuongBan; }
            set
            {
                if (value < 0)
                   soLuongBan= 1;
                else
                    soLuongBan = value;
            }
        }

        public string MaSp { get => maSp; set => maSp = value; }
        public string TenSp { get => tenSp; set => tenSp = value; }

        //phuong thuc khoi tao
        public ChiTietHoaDon() 
        {
            ma = "SP0010";
            TenSp ="May tinh dell";
            SoLuongBan = 2;
            giaBan= 15000;
        }
        public ChiTietHoaDon(ChiTietHoaDon ct)
        {
            ct.MaSp = ma;
            ct.TenSp = tenSp;
            ct.giaBan=GiaBan;
            ct.SoLuongBan = soLuongBan;
        }
        public ChiTietHoaDon(string maSp, string tenSp, double giaBan, int soLuongBan)
        {
            maSp = ma;
            tenSp = TenSp;
            giaBan = GiaBan;
            soLuongBan = SoLuongBan;
           
        }
        public double thanhTien()
        {
            return SoLuongBan * giaBan * (1 + Vat);
        }
        public void Xuat()
        {
            Console.WriteLine("\t{0,10} \t{1,20} \t{2,25} \t{3,7} \t{4,20}", "Ma","Ten Sp","Gia ban","So luong","Thanh tien");


            Console.WriteLine("\t{0,10} \t{1,20} \t{2,25} \t{3,7} \t{4,20}",ma,TenSp,GiaBan,SoLuongBan,thanhTien() );
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ten san pham:");
            TenSp=Console.ReadLine();
            Console.WriteLine("Nhap ma san pham:");
            ma = Console.ReadLine();
            Console.WriteLine("Nhap gia ban:");
            GiaBan=double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so luong:");
            SoLuongBan=int.Parse(Console.ReadLine());
        }
    }
}
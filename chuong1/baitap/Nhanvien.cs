using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace baitap
{
    public class Nhanvien
    {
        //thanh phan thuoc tinh
        string maNv, hoTen;
        int soNC;
        public static double luongngay = 200.000;
        
        
        

        //property
        public string MaNv { get => maNv; set => maNv = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int SoNC
        {
            get { return soNC; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("du lieu sai");
                    soNC = 1;
                }
                else 
                {
                    soNC = value;
                }

            }

        }

        public char xeploai
        {
            set { xeploai = value; }
            get { 
                if (soNC >= 26)
                {
                    return 'A';
                } 
                else if(soNC >=22)
                {
                    return 'B';
                }
                else  return 'C';

            }
        }

        //phuong thuc khoi tao
        public Nhanvien() 
        {
            MaNv = "12344";
            HoTen = "Nguyen van A";
            SoNC = 25;

        }
        public Nhanvien(string maNv,string hoTen,int soNC)
        {
            this.MaNv = maNv;
            this.HoTen = hoTen;
            this.SoNC = soNC;
        }
        //cac phuong thuc xu li khac
        public void Nhap()
        {
            Console.WriteLine("Nhap ma so nhan vien");
            MaNv = Console.ReadLine();
            Console.WriteLine("Nhap ho ten");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap so ngay cong");
            SoNC=int.Parse(Console.ReadLine());
        }
        public double tinhLuong()
        {
            return SoNC * luongngay;
        }
        public double tinhthuong()
        {
            if (xeploai == 'A')
            {
                return tinhLuong() * 5 / 100;
            }
            else if (xeploai == 'B')
            {
                return tinhLuong() * 2 / 100;
            }
            else
                return 0;
        }
        public void Xuat()
        {
            Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5}",MaNv,HoTen,SoNC,xeploai,tinhLuong(),tinhthuong());
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class HinhChuNhat
    {
        //thuoc tinh
        double dai, rong;
        //property
        public double d
        {
            get
            {
                return dai;
            }
            set
            {
                if (value > 0)
                {
                    dai = value;
                }
                else
                {
                    value= 1;
                }
            }
         }
        public double r
        {
            get
            {
                return rong;
            }
            set
            {
                if (value > 0) 
                {
                        rong = value;
                }
                else
                {
                    value = 1;
                }
            }
        }
        //phuong thuc khoi tao
        public HinhChuNhat() {

            d = 1;
            r = 1;
        }
        public HinhChuNhat(double dai, double rong) { 
            this.d = dai;
            this.r = rong;
        }
        public HinhChuNhat(HinhChuNhat hcn) { 
            d=hcn.dai;
            r = hcn.rong;
        }

        //phuong thuc tinh toan
        public double Chuvi()
        {
            return (dai + rong) * 2;
        }
        public double Dientich()
        {
            return dai * rong;
        }
        public double daiCheo()
        {
            return Math.Sqrt(rong*rong+dai*dai);
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap thong so hinh chu nhat:");
            Console.WriteLine("Nhap chieu dai hinh chu nhat:");
            d=double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong hinh chu nhat:");
            r=double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Thong so hinh chu nhat");
            Console.WriteLine($"Chieu dai hinh chu nhat:{d} cm");
            Console.WriteLine($"Chieu rong hinh chu nhat:{r} cm");
            Console.WriteLine($"Chu vi hinh chu nhat:{Chuvi():F2} cm");
            Console.WriteLine($"Dien tich hinh chu nhat:{Dientich():F2} cm");
            Console.WriteLine($"Do dai duong cheo hinh chu nhat:{daiCheo():F2} cm");
        }

        public void changeSize(int tx,int ty,int kieu)
        {
            if(kieu == 0)
            {
                dai -= tx;
                rong -= ty;
            }
            else if(kieu == 1)
            {
                dai += tx;
                rong += ty;

            }
        }

        public void changeSize(HinhChuNhat a, int kieu) {
            if (kieu == 1)
            {
                dai += a.dai;
                rong += a.rong;
            }
            else if(kieu == 0)
            {
                dai -= a.dai;
                rong -= a.rong;
            }
                    
        }



    }
}

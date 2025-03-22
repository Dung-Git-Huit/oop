using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baimau
{
    public class PhanSo
    {
        //thuoc tinh
        int tuso, mauso;

        public int Mauso { get => mauso; set => mauso = value != 0 ? value : 1; }
        public int Tuso { get => tuso; set => tuso = value; }

        public float Giatrithuc
        {
            get
            {
                return (float)Tuso / Mauso;
            }
        }
        //phuong thuc khoi tao
        public PhanSo() 
        {
            this.Tuso = 0;
            this.mauso = 1;
        }
        public PhanSo(int Tuso,int Mauso)
        {
            this.Tuso = Tuso;
            this.Mauso = Mauso;
        }
        public PhanSo(PhanSo phanso)
        {
            this.Tuso = phanso.Tuso;
            this.Mauso= phanso.Mauso;

        }

        //phuong thuc xu li
        public void Toigian()
        {
            int uocChung = TienIch.TimUCLN(Tuso, Mauso);
            Tuso/= uocChung;
            Mauso/= uocChung;
        }
        public PhanSo Tinhtong(PhanSo p) 
        {
            PhanSo pstong = new PhanSo();
            pstong.Tuso = this.Tuso * p.Mauso + p.Tuso * this.Mauso;
            pstong.Mauso = this.Mauso * p.Mauso;
            pstong.Toigian();
            return pstong;
        }
        public PhanSo Tinhtong(int x)
        {
            PhanSo pstong=new PhanSo();
            pstong.Tuso=this.Tuso+x*this.Mauso;
            pstong.Mauso = this.Mauso;
            pstong.Toigian();
            return pstong;

        }
        public void Nhap()
        {
            Console.Write("Nhap tu so:");
            Tuso=int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so:");
            Mauso=int.Parse(Console.ReadLine());

        }
        public void Xuat()
        {
            Console.WriteLine("{0}/{1}",Tuso,Mauso);
        }

    }
}

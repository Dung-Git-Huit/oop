using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    public class SinhVien
    {
        //thuoc tinh 
        string maSv, hoTen;
        double dTB;
        string xeploai;

        //property
        public string MaSv { get => maSv; set => maSv = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public double DTB { get => dTB; set => dTB = value; }
        public string Xeploai
        {
            get
            {
                if (dTB >= 8)
                {
                    return "Gioi";
                }
                else if (dTB >= 6.5)
                {
                    return  "Kha";
                }
                else if (dTB >= 5)
                {
                    return "Trung binh";
                }
                else
                {
                    return "Yeu kem";

                }

            }
        }
        //phuong thuc khoi tao
        public SinhVien() 
        {
            maSv = "sv00001";
            hoTen = "Nguyen Xuan Dung";
            dTB = 8;
            xeploai = "Gioi";
        }
        public SinhVien(string maSv,string hoTen,double dTB,string xeploai)
        {
            this.maSv = maSv;
            this.hoTen = hoTen;
            this.dTB = dTB;
            this.xeploai = xeploai;
        }

        //phuong thuc
        public void Xuat()
        {
            Console.WriteLine("Xuat thong tin sinh vien \n");
            Console.WriteLine("Ho ten:{0} - Ma so sinh vien:{1} - Diem trung binh:{2:0.00} - Xep loai:{3}",hoTen,maSv,dTB,xeploai);
        }

       

    }
}

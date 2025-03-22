using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    public class KhoaHoc
    {   //thuoc tinh 
        string tenKh, gioHoc, giaoVien,maKh;
        int soBuoi, soHocVien;
        public static double gia = 100;
        public static double thulao1 = 500;



        //property
        public string MaKh
        {
            get
            {
                return maKh;
            }
            set
            {
                if (value.StartsWith("KH")&&value.Length==5 && value[2] == 1 || value[2] == 2 || value[2] ==3)
                {
                    maKh= value;
                }
                else
                {
                    maKh = "KH0000";
                }

                     
            }
        }
        public string TenKh { get => tenKh; set => tenKh = value; }
        public string GioHoc
        {
            get { return gioHoc; }
            set
            {
                if (value == "2,4,6" || value == "3,5,7" || value == "7,CN")
                {
                    gioHoc = value;
                }
                else
                {
                    value = "2,4,6";
                }
            }
        }

        public string GiaoVien { get => giaoVien; set => giaoVien = value; }
        public int SoBuoi
        {
            get
            {
                return soBuoi;
            }
            set
            {
                {
                    if (value > 0)
                    {
                        soBuoi = value;
                    }
                    else
                    {
                        soBuoi = 0;
                    }
                }
            }
        }

        public int SoHocVien
        {
            get
            {
                return soHocVien;
            }
            set
            {
                if (value >= 10 && value <= 20)
                {
                    soHocVien = value;
                }
                else
                {
                    soHocVien = 10;
                }
            }
        }

        //phuong thuc khoi tao

        public KhoaHoc()
        {
            TenKh = "Anh van";
            SoBuoi = 1;
            GioHoc = "2,4,6";
            SoHocVien = 10;
            GiaoVien = "Thay A";
        }
        public KhoaHoc(string tenKh, string gioHoc, string giaoVien, int soBuoi, int soHocVien)
        {
            this.TenKh = tenKh;
            this.GiaoVien = giaoVien;
            this.SoBuoi = soBuoi;
            this.SoHocVien = soHocVien;
            this.GioHoc = gioHoc;
        }
        public KhoaHoc(KhoaHoc kh)
        {
            this.TenKh = kh.tenKh;
            this.GiaoVien = kh.giaoVien;
            this.SoBuoi = kh.soBuoi;
            this.SoHocVien = kh.soHocVien;
            this.GioHoc = kh.gioHoc;
        }
        //phuong thuc tinh toan
         public double TinhHocPhi()
        {
            if (GioHoc == "2,4,6"||GioHoc=="3,5,7")
            {
                return SoBuoi * gia;
            }
            else
            {
                return SoBuoi*gia*1.2;
            }
        }

        public double ThuLao()
        {
            if (SoHocVien >= 15)
            {
                return SoBuoi * thulao1+10;
            }
            else
            {
                return SoBuoi * thulao1;
            }
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap thong tin khoa hoc");
            Console.WriteLine("Nhap ma khoa hoc");
            MaKh = Console.ReadLine();
            Console.WriteLine("Nhap ten khoa hoc");
            
            TenKh = Console.ReadLine();
            Console.WriteLine("Nhap so buoi");
            SoBuoi=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so hoc vien");
            SoHocVien=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten giao vien");
            GiaoVien=Console.ReadLine();


        }
        public void Xuat()
        {
            Console.WriteLine("thong tin khoa hoc");
            Console.WriteLine("ma khoa hoc:{0}",MaKh);
            Console.WriteLine("ten khoa hoc:{0}",TenKh);
            Console.WriteLine("giao vien giang day:{0}", GiaoVien);
            Console.WriteLine("so hoc vien:{0}",SoHocVien);
            Console.WriteLine("so buoi hoc:{0}",SoBuoi);
            Console.WriteLine("Hoc phi mot buoi:{0}",gia);
            Console.WriteLine("Hoc phi khoa hoc:{0}",TinhHocPhi());
            Console.WriteLine("Thu lao 1 buoi:{0}",thulao1);
            Console.WriteLine("Thu lao giao vien ca khoa hoc:{0}",ThuLao());
           

        }
    }
}

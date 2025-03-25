using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    public class MonHoc
    {
        //phuong thuc 
        string maMh, tenMh;
        float diemKtr, diemGiuaki, diemCuoiKi;

        public string MaMh { get => maMh; set => maMh = value; }
        public string TenMh { get => tenMh; set => tenMh = value; }
        public float DiemKtr { get => diemKtr; set => diemKtr = value; }
        public float DiemGiuaki { get => diemGiuaki; set => diemGiuaki = value; }
        public float DiemCuoiKi { get => diemCuoiKi; set => diemCuoiKi = value; }
        //phuong thuc khoi tao
        public MonHoc() {
            maMh = "";
            tenMh = "";
            diemKtr = 0;
            diemGiuaki = 0;
            diemCuoiKi = 0;
        }

        public MonHoc(string ma,string ten)
        {
            maMh= ma;
            tenMh= ten;
        }
        public MonHoc(string ma,string ten,float dkt,float dgk,float dck)
        {
            MaMh=ma;
            TenMh= ten;
            DiemKtr=dkt;
            DiemGiuaki=dgk;
            DiemCuoiKi=dck;
        }

        //phuong thuc xu li
        public float TinhDiemTongKet()
        {
            float tong = (DiemKtr ) + (DiemGiuaki * 2) + (DiemCuoiKi * 3);
            return tong/6;
        }
        public string ketQua()
        {
            if (TinhDiemTongKet() >= 5)
                return "Đạt";
            else
                return "Không Đạt";
        }

        public void Nhap()
        {
            Console.WriteLine("Nhập mã môn học");
            MaMh=Console.ReadLine();
            Console.WriteLine("Nhập tên môn học");
            TenMh=Console.ReadLine();
            Console.WriteLine("Nhập điểm kiểm tra thường xuyên");
            DiemKtr=float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm kiểm tra giữa kì");
            DiemGiuaki= float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm kiểm tra cuối kì");
            DiemCuoiKi=float.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine($"Mã môn học:{MaMh}");
            Console.WriteLine($"Tên môn học:{TenMh}");
            Console.WriteLine($"Điểm kiểm tra thường xuyên:{DiemKtr}");
            Console.WriteLine($"Điểm giữa kì:{DiemGiuaki}");
            Console.WriteLine($"Điểm cuối kì:{DiemCuoiKi}");
            Console.WriteLine($"Điểm tổng kêt:{TinhDiemTongKet()}");
            Console.WriteLine($"Kết quả:{ketQua()}");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    public class ThiSinh
    {
        //thuoc tinh
        string maThiSinh, hoTen, gioiTinh;
        float diemLyThuyet, diemThucHanh;

        public string MaThiSinh { get => maThiSinh; set => maThiSinh = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public float DiemLyThuyet { get => diemLyThuyet; set => diemLyThuyet = value; }
        public float DiemThucHanh { get => diemThucHanh; set => diemThucHanh = value; }
        //phuong thuc khoi tao
        public ThiSinh()
        {
            HoTen = "";
            GioiTinh = "";
            MaThiSinh = "";
            DiemLyThuyet = 0;
            DiemThucHanh = 0;
        }
        public ThiSinh(ThiSinh ths)
        {
            ths.HoTen = HoTen;
            ths.GioiTinh = GioiTinh;
            ths.MaThiSinh= MaThiSinh;
            ths.DiemLyThuyet= DiemLyThuyet;
            ths.DiemThucHanh= DiemThucHanh;
        }
        public ThiSinh(string maThiSinh, string hoTen, string gioiTinh, float diemLyThuyet, float diemThucHanh)
        {
            MaThiSinh = maThiSinh;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            DiemLyThuyet = diemLyThuyet;
            DiemThucHanh = diemThucHanh;
           
        }

        //phuong thuc xu li
        public float diemTongKet()
        {
            return (diemLyThuyet * diemThucHanh)/2;
        }
        public string xetTuyen()
        {
            if (diemTongKet() >= 5)
            {
                return "Đậu";
            }
            else
                return "Rớt";


        }
        public void Nhap()
        {
            Console.WriteLine($"Nhập tên thí sinh:");
            HoTen=Console.ReadLine();
            Console.WriteLine($"Nhập mã thí sinh:");
            MaThiSinh=Console.ReadLine();
            Console.WriteLine($"Nhập giới tính thí sinh");
            GioiTinh=Console.ReadLine();
            Console.WriteLine($"Nhập điểm lý thuyết:");
            DiemLyThuyet=float.Parse( Console.ReadLine() );
            Console.WriteLine($"Nhập điểm thưc hành");
            DiemThucHanh=float.Parse( Console.ReadLine() );

        }

        public void Xuat()
        {
            Console.Write($"\tTên thí sinh:{HoTen}");
            Console.Write($"\tMã thí sinh:{MaThiSinh}");
            Console.Write($"\tGiới tính thí sinh:{GioiTinh}");
            Console.Write($"\tKết quả xét tuyển:{xetTuyen()}");
        }
    }
}

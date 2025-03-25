using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    public class NhanVien
    {
        //thuoc tinh
        string maNv, tenNv, phongBan, chucVu;
        int thamNien, soNgayLam;
        float heSoLuong;
        public static double luongCoBan = 2340000;

        public string MaNv { get => maNv; set => maNv = value; }
        public string TenNv { get => tenNv; set => tenNv = value; }
        public string PhongBan { get => phongBan; set => phongBan = value; }
        public int ThamNien { get => thamNien; set => thamNien = value; }
        public int SoNgayLam { get => soNgayLam; set => soNgayLam = value; }
        public float HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public string ChucVu
        {
            get { return chucVu; }
            set
            {
                if (value == "Nhan vien" || value == "Lanh dao")
                {
                    chucVu = value;
                }
                else
                {
                    chucVu = "Nhan vien";
                }
            }
        }

       

        //phuong thuc khoi tao
        public NhanVien()
        {
            MaNv= string.Empty;
            TenNv= string.Empty;
            PhongBan= string.Empty;
            ChucVu= string.Empty;
            HeSoLuong = 0;
            ThamNien= 0;
            SoNgayLam= 0;
            }

       public NhanVien(string maNv, string tenNv, string phongBan, string chucVu, int thamNien, int soNgayLam, float heSoLuong)
        {
            MaNv = maNv;
            TenNv = tenNv;
            PhongBan = phongBan;
            ChucVu = chucVu;
            ThamNien = thamNien;
            SoNgayLam = soNgayLam;
            HeSoLuong = heSoLuong;
            
        }
        public NhanVien(NhanVien nv)
        {
            MaNv=nv.MaNv;
            TenNv=nv.TenNv;
            PhongBan=nv.PhongBan;
            ChucVu = nv.ChucVu;
            ThamNien=nv.ThamNien;
            HeSoLuong=nv.HeSoLuong;
            SoNgayLam=nv.SoNgayLam;
            
        }

        //phuong thuc xu li
        public double heSoThiDua()
        {
            if (ChucVu == "Truong phong")
            {
                return 1.0;
            }
            else if (ChucVu == "Nhan vien" && SoNgayLam > 22)
            {
                return 1.0;
            }
            else if (ChucVu == "Nhan vien" && SoNgayLam > 20)
            {
                return 0.8;
            }
            else
                return 1.6;
         }
        public double phuCap
        {
            get
            {
                if (ChucVu == "Lanh dao")
                    return 135000;
                else
                    return 0;
            }
        }

        public double tinhLuong()
        {
            return HeSoLuong * luongCoBan * heSoThiDua() + 1100000 + phuCap;
        }

        public void Nhap()
        {
            Console.Write("Nhap ma nhan vien:");
            MaNv=Console.ReadLine();
            Console.Write("Nhap ten nhan vien:");
            TenNv = Console.ReadLine();
            Console.Write("Nhap phong ban lam viec:");
            PhongBan=Console.ReadLine();
            Console.Write("Nhap chuc vu:");
            ChucVu = Console.ReadLine();
            Console.Write("Nhap he so luong:");
            HeSoLuong=float.Parse(Console.ReadLine());
            Console.Write("Nhap tham nien:");
            ThamNien=int.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay lam viec:");
            SoNgayLam=int.Parse(Console.ReadLine());
        }
        public void Xuat() 
        {
            Console.WriteLine("\t{0,20} \t{1,10} \t{2,10} \t{3,15} \t{4,15} \t{5,20}","Ten","Ma","Phong","Chuc vu","So ngay lam","Luong");
            Console.WriteLine("\t{0,20} \t{1,10} \t{2,10} \t{3,15} \t{4,15} \t{5,20:n2}", TenNv, MaNv, PhongBan, ChucVu, SoNgayLam,tinhLuong() );
        }
    }
}

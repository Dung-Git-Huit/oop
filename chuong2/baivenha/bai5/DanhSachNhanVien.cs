using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    public class DanhSachNhanVien
    {
        //thuoc tinh
        List<NhanVien> danhSachNv;

        public List<NhanVien> DanhSachNv { get => danhSachNv; set => danhSachNv = value; }
        //phuong thuc khoi tao
        public DanhSachNhanVien()
        {
            DanhSachNv = new List<NhanVien>();
        }
        public DanhSachNhanVien(List<NhanVien> danhSach)
        {
            DanhSachNv = danhSach;

        }
        //phuong thuc xu li
          public void Nhapds()
        {
            Console.WriteLine("Nhap so luong nhan vien:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin nhan vien thu {0}:", i + 1);
                NhanVien nv = new NhanVien();
                nv.Nhap();
                DanhSachNv.Add(nv);
            }
        }
        public void xuatDs()
        {
            
            foreach (NhanVien nv in DanhSachNv)
            {
                nv.Xuat();
            }
        }
        public DanhSachNhanVien dsTruongphong()
        {
            DanhSachNhanVien ds=new DanhSachNhanVien();
            ds.DanhSachNv=DanhSachNv.Where(t=>t.ChucVu=="Truong phong").ToList();
            return ds;
        }

        public double tongLuong()
        {
            return DanhSachNv.Sum(t => t.tinhLuong());
        }
        public void xoa()
        {
            Console.WriteLine("Danh sach nhan vien sau xoa nhan vien co so ngay lam < 10:");
            
            DanhSachNv.RemoveAll(t => t.SoNgayLam < 10);
            xuatDs();
            
        }
        public void xuatkhacLanhDao()
        {
            Console.WriteLine("Xuat danh sach cac truong phong");
            DanhSachNhanVien ds = new DanhSachNhanVien();
            ds.DanhSachNv= DanhSachNv.Where(t => t.ChucVu != "Truong phong"&&t.SoNgayLam>22).ToList();
            ds.xuatDs();
        }

        public void xuatTheoheso()
        {
            Console.WriteLine("Danh sach nhan vien co he so > 4,33 va thuoc phong tai vu:");
            DanhSachNhanVien ds = new DanhSachNhanVien();
            ds.DanhSachNv = DanhSachNv.Where(t => t.PhongBan == "Tai vu" && t.HeSoLuong > 4.33).ToList();
            ds.xuatDs();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baimau2
{
    public class DanhSachNhanVien
    {
        List<NhanVien> lstNhanVien;
        public List<NhanVien> LstNhanVien { get; set; }
        //phuong thuc khoi tao
        public DanhSachNhanVien()
        {
            LstNhanVien =new List<NhanVien>();

        }
        public DanhSachNhanVien(List<NhanVien> lstNhanVien)
        {
            LstNhanVien =lstNhanVien;
          
        }
        //phuong thuc xu li
        public void Nhapds()
        {
            
            Console.Write("\nNhap so luong nhan vien:");
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("Nhap thong tin nhan vien thu {0}:",i+1);
                NhanVien nv= new NhanVien();
                nv.Nhap();
                LstNhanVien.Add(nv);
            }
        }
        public void Xuatds()
        {
            Console.WriteLine("\n Danh sach nhan vien:");
            foreach (NhanVien nv in LstNhanVien) 
            {
                nv.Xuat();
            }
        }
        //tinh tong luong cua tat ca nhan vien
        public float TinhTongLuong()
        {
            return LstNhanVien.Sum(t => t.TinhLuong());
        }
        //tim gia tri luong cao nhat
        public float TimLuongcaoNhat()
        {
            return LstNhanVien.Max(t => t.TinhLuong());
        }
        public  DanhSachNhanVien TimDSNVLuongCaoNhat()
        {
            float maxLuong = TimLuongcaoNhat();
            DanhSachNhanVien ds1=new DanhSachNhanVien();
            ds1.LstNhanVien=LstNhanVien.Where(t=>t.TinhLuong()==maxLuong).ToList();
            return ds1;
        }
        public NhanVien TimNVmaxLuong()
        {
            float maxLuong=TimLuongcaoNhat();
            NhanVien nv=LstNhanVien.FirstOrDefault(t=>t.TinhLuong()== maxLuong);
            return nv;
        }
        //sap xep danh saxh nhan vien tang dan theo nam  vao lam
        public DanhSachNhanVien sort_Giatri()
        {
            DanhSachNhanVien ds1=new DanhSachNhanVien();
            ds1.LstNhanVien=LstNhanVien.OrderBy(t=>t.NamVaoLam).ToList();
            return ds1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    public class DSThiSinh
    {
        //thuoc tinh
        List<ThiSinh> dsthiSinh;

        public List<ThiSinh> DanhsachThiSinh { get => dsthiSinh; set => dsthiSinh = value; }
        //khoi tao
        public DSThiSinh()
        {
            DanhsachThiSinh = new List<ThiSinh>();
        }
        public DSThiSinh(List<ThiSinh> dsthiSinh)
        {
            DanhsachThiSinh = dsthiSinh;

        }
        //phuong thuc xu li
        public void Nhapds()
        {
            Console.WriteLine("Nhập số thí sinh trong danh sách");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thí sinh thứ {i + 1}:");
                ThiSinh thiSinh = new ThiSinh();
                thiSinh.Nhap();
                DanhsachThiSinh.Add(thiSinh);
            }
        }
        public void Xuatds()
        {
            foreach (ThiSinh thiSinh in DanhsachThiSinh)
            {
                Console.WriteLine("\nDanh  sach thi sinh");
                thiSinh.Xuat();
            }
        }
        public DSThiSinh dsDau()
        {
            Console.WriteLine("\nDanh sách thí sinh đậu:");
            DSThiSinh listdau = new DSThiSinh();
            listdau.DanhsachThiSinh = DanhsachThiSinh.Where(t => t.xetTuyen() == "Đậu").ToList();
            return listdau;

        }
        public int tongDau()
        {
            return DanhsachThiSinh.Count(t => t.xetTuyen() == "Đậu");
        }
        public int tongRot()
        {
            return DanhsachThiSinh.Count(t => t.xetTuyen() == "Rớt");
        }

        public void timTheoMa(string ma)
        {
            ThiSinh ts = DanhsachThiSinh.FirstOrDefault(t => t.MaThiSinh == ma);
            if (ts != null)
            {
                Console.WriteLine("Thông tin thí sinh tìm thấy:");
                ts.Xuat();
            }
            else
                Console.WriteLine("không tìm thấy");
        }
        public DSThiSinh sxgiamDiemTong()
        {
            DSThiSinh dsapXep=new DSThiSinh();
            dsapXep.DanhsachThiSinh=DanhsachThiSinh.OrderByDescending(t=>t.diemTongKet()).ToList();
            return dsapXep;
        }

    }
}

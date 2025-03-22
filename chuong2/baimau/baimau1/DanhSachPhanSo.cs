using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace baimau
{
    public class DanhSachPhanSo
    {
        //thuoc tinh
        List<PhanSo> lstPhanSo;
        public List<PhanSo> LstPhanSo
        {
            get; set;
        }
        //phuong thuc khoi tao
        public DanhSachPhanSo()
        {
            LstPhanSo = new List<PhanSo>();

        }
        public DanhSachPhanSo(List<PhanSo> lstPhanSo)
        {
            LstPhanSo = lstPhanSo;

        }
        //phuong thuc xu li
        //a. Nhap danh sach tu ban phim
        public void Nhapds()
        {
            Console.Write("Nhap vao so phan tu cua danh dach:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan so thu {0}:", i + 1);
                PhanSo x = new PhanSo();
                x.Nhap();
                LstPhanSo.Add(x);

            }

        }
        //b.xuat danh sach
        public void Xuatds()
        {
            foreach (PhanSo x in LstPhanSo)
            {
                x.Xuat();
            }
        }

        //c. toi gian danh sach phan so
        public void ToiGianDs()
        {
            foreach (PhanSo x in LstPhanSo)
            {
                x.Toigian();
            }
        }
        //d tim phan so p co trong danh sach hay khong
        public bool SearchPS(PhanSo p)
        {
            PhanSo k = LstPhanSo.Find(t => t.Giatrithuc == p.Giatrithuc);
            if (k == null)
            {
                return false;
            }
            return true;
        }
        //e. sap xep danh sach theo gia tri thuc tang dan
        public DanhSachPhanSo SortGiatri()
        {
            DanhSachPhanSo ds1 = new DanhSachPhanSo();
            ds1.LstPhanSo = LstPhanSo.OrderBy(t => t.Giatrithuc).ToList();
            return ds1;
        }
        //f. tim danh sach con thoa man dieu kien gia tri thuc>1
        public DanhSachPhanSo Locdulieu()
        {
            DanhSachPhanSo ds1 = new DanhSachPhanSo();
            ds1.LstPhanSo = LstPhanSo.Where(t => t.Tuso > t.Mauso).ToList();
            return ds1;
        }
        //g. tim phan so lon nhat
        public PhanSo MaxPhanso()
        {
            float max=LstPhanSo.Max(t=>t.Giatrithuc);
            return LstPhanSo.FirstOrDefault(t=>t.Giatrithuc==max);
        }
        public DanhSachPhanSo Top3ps()
        {
            DanhSachPhanSo ds1=new DanhSachPhanSo();
            ds1.LstPhanSo.OrderByDescending(t=>t.Giatrithuc).Take(3).ToList();
            return ds1;
        }
    
    }
}

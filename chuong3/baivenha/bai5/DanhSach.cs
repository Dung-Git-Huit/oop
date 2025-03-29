using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace bai5
{
    public class DanhSach
    {
        List<NhanVien> listNv;

        public List<NhanVien> ListNv { get => listNv; set => listNv = value; }
        public DanhSach() 
        {
            ListNv = new List<NhanVien>();
            
        }

        //phuong thuc xu li
        public void docDs()
        {
            string filename = "danhsach.xml";
            XmlDocument read = new XmlDocument();
            read.Load(filename);
            XmlNodeList nodes = read.SelectNodes("/DanhSach/NhanVien");
            foreach (XmlNode node in nodes)
            {
               NhanVien nVien = new NhanVien();
                nVien.TenNv = node["TenNv"].InnerText;
                nVien.MaNv = node["MaNv"].InnerText;
                nVien.ChucVu = node["ChucVu"].InnerText;
                nVien.HeSoLuong = double.Parse(node["HeSoLuong"].InnerText);
                nVien.ThamNien = int.Parse(node["ThamNien"].InnerText);
                nVien.NgayLamViec = int.Parse(node["NgayLamViec"].InnerText);
                nVien.PhongBan = node["PhongBan"].InnerText;
                listNv.Add(nVien);

                
            }

        }
        public void xuatDs()
            {
            Console.WriteLine("{0,7} {1,7} {2,15} {3,15} {4,15} {5,15} {6,15} {7,15}", "Ten", "Ma", "Chuc vu", "Phong ban", "He so luong", "Tham nien", "so ngay lam", "luong");
            foreach (NhanVien v in listNv)
            {
                v.xuat();
            }
        }
        public double tongLuong()
        {
            return ListNv.Sum(t=>t.tinhLuong());
        }
        public DanhSach locLanhDao()
        {
            DanhSach ds = new DanhSach();
            ds.ListNv = ListNv.Where(t => t.ChucVu == "Lanh dao").ToList();
            return ds;
        }
        public DanhSach loctheoPhong()
        {
            DanhSach ds1 = new DanhSach();
            Console.WriteLine("Nhap phong");
          string  phong=Console.ReadLine();
            ds1.ListNv=ListNv.Where(t=>t.PhongBan==phong).ToList();
            return ds1;
        }
        public void xoaNlvNhoHon10()
        {
             ListNv.RemoveAll(t => t.NgayLamViec < 10);
            
        }
        public DanhSach lockhaclanhdao()
        {
            DanhSach ds3= new DanhSach();
            ds3.ListNv = ListNv.Where(t=>t.ChucVu=="Nhan vien"&&t.NgayLamViec>22).ToList();
            return ds3;
        }
        public DanhSach sxGiamLuong()
        {
            DanhSach ds4 = new DanhSach();
            ds4.ListNv = ListNv.OrderByDescending(t => t.tinhLuong()).ToList();
            return ds4;
        }

        public DanhSach sxgiamluongTrung()
        {
            DanhSach ds5 = new DanhSach();
            ds5.listNv=ListNv.OrderByDescending(t=>t.tinhLuong()).ThenBy(T=>T.TenNv).ToList();
            return ds5;
        }

    }
}

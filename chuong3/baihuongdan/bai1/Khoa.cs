using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace bai1
{
    public class Khoa
    {
        List<GiangVien> lstGV;
        public List<GiangVien> LSTGV{
            get { return lstGV; }
            set { lstGV = value; }

        }
        public Khoa() 
        {
            LSTGV = new List<GiangVien>();
        }

        //phuong thuc xu li
        public void docDS()
        {
            string tenfile = "khoa.xml"; // Đường dẫn file
            XmlDocument doc = new XmlDocument();
            doc.Load(tenfile); // Sửa LoadXml() thành Load()

            XmlNodeList nodes = doc.SelectNodes("/Khoa/GiangVien");

            foreach (XmlNode node in nodes)
            {
                GiangVien gVien = new GiangVien();

                gVien.hoten = node["HoTen"].InnerText;  // Đọc tên giảng viên
                gVien.sonhom = int.Parse(node["SoNhom"].InnerText);// Đọc số nhóm hướng dẫn
                
                lstGV.Add(gVien); // Thêm vào danh sách
            }
        }



        public void XuatDsGiangVien()
        {
            Console.WriteLine("\nHo Ten \t\t\tSo nhom huong dan");
            foreach(GiangVien gv in lstGV)
            {
                gv.Xuat();
            }
        }
        public int TinhTongSoNhomHD()
        {
            return LSTGV.Sum(gv=> gv.sonhom);
        }
        public void SXTangDanHoTen()
        {
            LSTGV=LSTGV.OrderBy(gv=>gv.hoten).ToList();

        }
        public void SXGiamDanSoNhom()
        {
            LSTGV=LSTGV.OrderByDescending(gv=>gv.sonhom).ToList();
        }
        public List<GiangVien> LocSoNhomLonHon1()
        {
           return LSTGV.Where(gv=>gv.sonhom>1).ToList();
            
        }
    }
}
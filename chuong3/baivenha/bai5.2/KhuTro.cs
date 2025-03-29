using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace bai5._2
{
    public class KhuTro
    {
        string _tenKhu,_diaChi;
       List<PhongTro> listPhongTro;

        public List<PhongTro> ListPhongTro { get => listPhongTro; set => listPhongTro = value; }
        public string TenKhu { get => _tenKhu; set => _tenKhu = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public KhuTro() 
        {
            listPhongTro=new List<PhongTro>();
        }

        public KhuTro(string tenkhu,string diachi,List<PhongTro> dsach)
        {
            TenKhu = tenkhu;
            DiaChi = diachi;
            listPhongTro = dsach;
        }
        
        //phuong thuc xu li
        public void docfile()
        {
            string fiename = "khutro.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(fiename);
            //doc thong tin cua khu tro
            this.TenKhu = doc.SelectSingleNode("/KhuTro/TenKhu").InnerText;
            this.DiaChi = doc.SelectSingleNode("/KhuTro/DiaChi").InnerText;

            //doc danh sach phong tro
            XmlNodeList nodes = doc.SelectNodes("/KhuTro/ListPhongTro/PhongTro");
            foreach (XmlNode node in nodes) 
            {
                PhongTro pt=new PhongTro();
                pt.maphong = node["maphong"].InnerText;
                pt.slkhach =int.Parse( node["slkhach"].InnerText);
                pt.sodien = int.Parse(node["sodien"].InnerText) ;
                pt.giaThue = double.Parse(node["giaThue"].InnerText);
                listPhongTro.Add(pt);
            }
            
        }

       public void xuatkt()
        {
            Console.WriteLine("Ten khu tro:{0}",TenKhu);
            Console.WriteLine("Dia chi:{0}",DiaChi);
            Console.WriteLine("Tong tien:{0}",TongTien());
            Console.WriteLine("\nDanh sach phong tro:");
            xuatdsPhong();
            
        }
        public void xuatdsPhong()
        {
            Console.WriteLine("{0,7} {1,8} {2,10} {3,15} {4,15} \t\t{5,15}", "Ma", "\tSo Khach", "Gia", "\tSo Dien", "May lanh", "Tien phong");
            foreach (PhongTro ph in listPhongTro) 
            {
                ph.xuat();
            }

        }
        

        public double TongTien()
        {
            return ListPhongTro.Sum(t => t.TinhTienPhong());
        }
        public void sapxepGiam()
        {
            
            listPhongTro.OrderByDescending(t=>t.slkhach).ThenByDescending(t=>t.TinhTienPhong()).ToList();
        }
        public double dungDienMax()
        {
            return ListPhongTro.Max(t => t.dungDien());
        }
        public PhongTro timphongMaxDien()
        {
            PhongTro pt = new PhongTro();
            double maxDien=dungDienMax();
            return pt=ListPhongTro.FirstOrDefault(t=>t.dungDien()==maxDien);
        }

    }
}

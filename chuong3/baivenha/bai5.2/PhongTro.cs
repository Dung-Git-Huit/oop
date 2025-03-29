using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5._2
{
    public class PhongTro
    {
        //thuoc tinh
        string _maPhong, _mayLanh;
        int _soKhach, _soDien;
        double _giaThue;
        public static double _giadien = 3500;

        //property
      
        public string maphong
        {
            get { return _maPhong; }
            set
            {
                if (value.StartsWith("PT") || value.Length == 4)
                    _maPhong = value;
                else
                    _maPhong = "PT00";
            }
        }
        public string ComayLanh
        {
            get { return _mayLanh; }
            set
            {
                if (value == "co may lanh" && value == "khong co may lanh")
                {
                    _mayLanh = value;
                }
                else
                    _mayLanh = "khong co may lanh";
            }

        }
        public int slkhach
        {
            get { return _soKhach; }
            set
            {
                if (value >= 0)
                    _soKhach = value;
                else _soKhach = 0;
            }
        }
        public double giaThue
        {
            get { return _giaThue; }
            set
            {
                if(value >= 0)
                    _giaThue = value;
                else _giaThue = 0;
            }
        }
        public int sodien
        {
            get
            {
                return _soDien;
            }
            set
            {
                if(value >=0)
                    _soDien = value;
                else
                    _soDien=0;
            }
        }

        //phuong thuc khoi tao
        public PhongTro()
        {
            maphong = "PT01";
            sodien= 0;
            ComayLanh = "co may lanh";
            slkhach = 3;
            giaThue = 1500000;
        }
        public PhongTro(string maPhong, string mayLanh, int soKhach, int soDien, double giaThue)
        {
            _maPhong = maPhong;
            _mayLanh = mayLanh;
            _soKhach = soKhach;
            _soDien = soDien;
            _giaThue= giaThue;
            
        }
        public  PhongTro(PhongTro pt)
        {
            pt.giaThue=_giaThue;
            pt.ComayLanh= _mayLanh;
            pt.maphong = _maPhong;
            pt.slkhach = _soKhach;
            pt.sodien= _soDien;
        }
        //phuong thuc xu li
        public double phiMayLanh
        {
            get
            {
                if (ComayLanh == "co may lanh")
                    return 50000 * slkhach;
                else
                    return 0;
            }
        }
        public double TinhTienPhong()
        {
            return giaThue+sodien*_giadien+phiMayLanh;
        }
        public void xuat()
        {
            
            Console.WriteLine("{0,7} {1,10} \t{2,15} {3,10} \t\t{4,15} \t{5,15:n2}",maphong,slkhach,giaThue,sodien,ComayLanh,TinhTienPhong());
        }
        public double dungDien()
        {
            return _giadien * sodien+phiMayLanh;
        }
    }
}
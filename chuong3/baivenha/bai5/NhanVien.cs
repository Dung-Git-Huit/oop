using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    public class NhanVien
    {
        //thuoc tinh
        string _maNv, _tenNv, _phongBan, _chucVu;
        double _heSoLuong;
        int _thamNien, _ngayLamViec;
        static double Luongcb = 2340000;
        //property
        public string MaNv { get => _maNv; set => _maNv = value; }
        public string TenNv { get => _tenNv; set => _tenNv = value; }
        public string PhongBan { get => _phongBan; set => _phongBan = value; }
      
        public double HeSoLuong { get => _heSoLuong; set => _heSoLuong = value; }
        public int ThamNien { get => _thamNien; set => _thamNien = value; }
        public int NgayLamViec { get => _ngayLamViec; set => _ngayLamViec = value; }
        //phuong thuc khoi tao
        public NhanVien()
        {

        }
        //phuong thuc xu li
        public double heSoThiDua()
        {
            if (ChucVu == "Lanh dao")
            {
                return 1.0;
            }
            else if (ChucVu == "Nhan vien")
            {
                if (NgayLamViec > 22)
                {
                    return 1.0;
                }
                else if (NgayLamViec > 20)
                {
                    return 0.8;
                }
                else
                    return 0.6;
            }
            else
                return 0.6;
        }

        public double phucap
        {
            get 
            {
                if (ChucVu == "Lanh dao")
                    return 1350000;
                else
                    return 0;
            }

            }

        public string ChucVu { get => _chucVu; set => _chucVu = value; }

        public double tinhLuong()
        {
            return heSoThiDua()*HeSoLuong*Luongcb+1100000+phucap;
        }

        public void xuat()
        {
           
            Console.WriteLine("{0,7} {1,7} {2,15} {3,15} {4,10} {5,15} {6,15} \t\t{7,15:n2}",TenNv,MaNv,ChucVu,PhongBan,HeSoLuong,ThamNien,NgayLamViec,tinhLuong());
        }
        
    }
}

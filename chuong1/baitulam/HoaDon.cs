using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    public class HoaDon
    {

        string soSR, hangSX, tenSP, loaiSP;
        double giaBan;
        public static double ThueVat = 0.1;

        public string TenSP { get => tenSP; set => tenSP = value; }
        public string HangSX { get => hangSX; set => hangSX = value; }

        public string SoSR
        {
            get { return soSR; }
            set
            {
                if (value.StartsWith("S"))
                {
                    soSR = value;
                }
                else
                {
                    soSR = "S000";
                }
            }
        }

        public double GiaBan
        {
            get { return giaBan; }
            set
            {
                if (value >= 4.00)
                {
                    giaBan = value;
                }
                else
                {
                    Console.WriteLine("Du lieu khong hop le. Gia ban mac dinh la 4.00");
                    giaBan = 4.00;
                }
            }
        }

        public string LoaiSP
        {
            get { return loaiSP; }
            set
            {
                if (value == "May tinh de ban" || value == "May tinh xach tay" || value == "Dien thoai di dong")
                {
                    loaiSP = value;
                }
                else
                {
                    loaiSP = "Dien thoai di dong";
                }
            }
        }

        public HoaDon()
        {
            SoSR = "S000";
            HangSX = "samsung";
            TenSP = "Dien thoai di dong";
            GiaBan = 4.00;
            LoaiSP = "Dien thoai di dong";
        }

        public HoaDon(string SoSR, string TenSP, string LoaiSP, string HangSX, double GiaBan)
        {
            this.SoSR = SoSR;
            this.TenSP = TenSP;
            this.GiaBan = GiaBan;
            this.LoaiSP = LoaiSP;
            this.HangSX = HangSX;
        }

        public double phiBaoHanh()
        {
            if (LoaiSP == "May tinh de ban")
                return GiaBan * 0.08;
            else if (LoaiSP == "May tinh xach tay")
                return GiaBan * 0.05;
            else if (LoaiSP == "Dien thoai di dong")
                return GiaBan * 0.1;
            else
                return 0;
        }

        public double uuDai()
        {
            if (HangSX == "samsung")
                return 0.5;
            else
                return 0;
        }

        public double Thue()
        {
            return GiaBan * ThueVat;
        }

        public double ThanhTien()
        {
            return GiaBan + phiBaoHanh() - uuDai() + Thue();
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap thong tin san pham");
            Console.Write("Nhap so SR: ");
            SoSR = Console.ReadLine();

            Console.Write("Nhap ten san pham: ");
            TenSP = Console.ReadLine();

            Console.Write("Nhap loai san pham: ");
            LoaiSP = Console.ReadLine();

            Console.Write("Nhap ten hang: ");
            HangSX = Console.ReadLine();

            Console.Write("Nhap gia ban: ");
            GiaBan = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Thong tin cua san pham:");
            Console.WriteLine($"So SR: {SoSR}");
            Console.WriteLine($"Ten san pham: {TenSP}");
            Console.WriteLine($"Loai san pham: {LoaiSP}");
            Console.WriteLine($"Hang san xuat: {HangSX}");
            Console.WriteLine($"Gia ban: {GiaBan}");
            Console.WriteLine($"Phi bao hanh: {phiBaoHanh()}");
            Console.WriteLine($"Uu dai: {uuDai()}");
            Console.WriteLine($"Thue VAT: {Thue()}");
            Console.WriteLine($"Thanh tien: {ThanhTien()}");
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.NhapHd();
            hoaDon.xuathd();
            
            Console.WriteLine("Sau khi sap xep cac chi tiet hoa don:");
            hoaDon.sapxepGiamTheoTt();
            hoaDon.xuathd();
            Console.WriteLine("Thong tin chi tiet co thanh tien lon nhat:");
            hoaDon.maxThanhTien();

            Console.ReadKey();
        }
    }
}

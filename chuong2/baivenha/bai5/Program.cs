using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSachNhanVien ds=new DanhSachNhanVien();
            ds.Nhapds();
            ds.xuatDs();
            Console.WriteLine($"Tong luong tat ca nhan vien{ds.tongLuong():n2}vnd");
            ds.xoa();
            ds.xuatkhacLanhDao();
            ds.xuatTheoheso();
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    public class HocSinh
    {
        //thuoc tinh
        string maHs, tenHs;
        List<MonHoc> danhSachMonHoc;

        public string MaHs { get => maHs; set => maHs = value; }
        public string TenHs { get => tenHs; set => tenHs = value; }
        public List<MonHoc> DanhSachMonHoc { get => danhSachMonHoc; set => danhSachMonHoc = value; }
        //phuong thuc khoi tao
        public HocSinh()
        {
            MaHs = "";
            TenHs = "";
            DanhSachMonHoc = new List<MonHoc>();
        }
        public HocSinh(string mahs, string tenhs, List<MonHoc> dsMonHoc)
        {
            MaHs = mahs;
            TenHs = tenhs;
            DanhSachMonHoc= dsMonHoc;

        }

        //phuong thuc xu li
        public void Nhap()
        {
            Console.WriteLine("Nhập mã học sinh:");
            MaHs = Console.ReadLine();
            Console.WriteLine("Nhập tên học sinh:");
            TenHs = Console.ReadLine();
            Console.WriteLine("Nhập số môn học:");
            int soMon = int.Parse(Console.ReadLine());
            danhSachMonHoc=new List<MonHoc>();
            for (int i = 0; i < soMon; i++)
            {
                Console.WriteLine($"\nNhập thong tin môn thứ {i+1}");
                MonHoc mon=new MonHoc();
                mon.Nhap();
                danhSachMonHoc.Add(mon);

            }
           }
        public float TinhDiemTrungBinh()
        {
            if (DanhSachMonHoc.Count == 0)
                return 0;

            return DanhSachMonHoc.Average(mon => mon.TinhDiemTongKet());
        }
        public string XepLoai()
        {
            float diemTrungBinh = TinhDiemTrungBinh();

            // Lấy danh sách điểm tổng kết các môn học
            List<float> diemTongKetMon = DanhSachMonHoc.Select(mon => mon.TinhDiemTongKet()).ToList();

            // Kiểm tra từng điều kiện xếp loại theo yêu cầu
            if (diemTrungBinh >= 8.0f && diemTongKetMon.All(diem => diem >= 6.5f))
            {
                return "Giỏi";
            }
            else if (diemTrungBinh >= 6.5f && diemTongKetMon.All(diem => diem >= 5.0f))
            {
                return "Khá";
            }
            else if (diemTrungBinh >= 5.0f && diemTongKetMon.All(diem => diem >= 3.5f))
            {
                return "Trung bình";
            }
            else if (diemTrungBinh >= 3.5f && diemTongKetMon.All(diem => diem >= 2.0f))
            {
                return "Yếu";
            }
            else
            {
                return "Kém";
            }
        }

        public void Xuat()
        {
            Console.WriteLine($"\nMã học sinh: {MaHs}");
            Console.WriteLine($"Tên học sinh: {tenHs}");

            Console.WriteLine("\n--- Danh sách môn học ---");
            foreach (var mon in DanhSachMonHoc)
            {
                mon.Xuat();
                Console.WriteLine("------------------------");
            }

            Console.WriteLine($"Điểm trung bình môn : {TinhDiemTrungBinh():0.00}");
            Console.WriteLine($"Xếp loại học lực: {XepLoai()}");
            Console.WriteLine($"Kết quả học tập: {KetQuaHocTap()}");
        }
        public string KetQuaHocTap()
        {
            string loai = XepLoai();

            if (loai == "Giỏi" || loai == "Khá" || loai == "Trung bình")
                return "Được lên lớp";
            if (loai == "Yếu")
                return "Thi lại";
            return "Ở lại lớp";
        }
        public void XuatMonHocDat()
        {
            Console.WriteLine("\nDanh sách các môn học Đạt:");

            var monHocDat = DanhSachMonHoc.Where(mon => mon.ketQua() == "Đạt");

            if (!monHocDat.Any())
            {
                Console.WriteLine("Không có môn học nào đạt.");
            }
            else
            {
                foreach (var mon in monHocDat)
                {
                    Console.WriteLine($"Mã môn: {mon.MaMh} - Tên môn: {mon.TenMh} - Điểm tổng kết: {mon.TinhDiemTongKet():0.00}");
                }
            }
        }
    }


}


using System;
using System.Collections.Generic;

namespace OnTap
{
    public class TrungTamNgoaiNgu
    {
        private string tenTrungTam;
        List<NguoiLaoDong> listNLD = new List<NguoiLaoDong>();
        public TrungTamNgoaiNgu()
        {
            tenTrungTam = "Trung tâm ngoại ngữ ABC";
        }
        public void DuLieu()
        {
            listNLD.Add(new NhanVien("NV01", "Nguyễn Văn A", "Nam", 1990, 2.5f));
            listNLD.Add(new NhanVien("NV02", "Nguyễn Thị B", "Nữ", 1991, 3.0f));
            listNLD.Add(new GiaoVien("GV01", "Trần Văn C", "Nam", 1980, 40));
            listNLD.Add(new GiaoVien("GV02", "Trần Thị D", "Nữ", 1981, 35));
        }
        public bool KiemTraMaso(string maso)
        {

            foreach (NguoiLaoDong nld in listNLD)
            {
                if (nld.Maso == maso)
                {
                    Console.WriteLine("Mã số {0} đã tồn tại!", maso);
                    return false;
                }
            }
            return true;
        }

        public void Nhap()
        {
            //Nhập thông tin người lao động và thêm vào danh sách listNLD
            string choice;
            do
            {
                Console.WriteLine("Chọn loại người lao động (1-Nhân viên, 2-Giáo viên): ");
                int chon;
                while (!int.TryParse(Console.ReadLine(), out chon) || (chon != 1 && chon != 2))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại!");
                    Console.WriteLine("Chọn loại người lao động (1-Nhân viên, 2-Giáo viên): ");
                }
                NguoiLaoDong nld;
                if (chon == 1)
                {
                    nld = new NhanVien();
                    nld.Nhap();
                    if (KiemTraMaso(nld.Maso))
                    {
                        listNLD.Add(nld);
                    }
                }
                else if (chon == 2)
                {
                    nld = new GiaoVien();
                    nld.Nhap();
                    if (KiemTraMaso(nld.Maso))
                    {
                        listNLD.Add(nld);
                    }
                }
                Console.Write("Bạn có muốn nhập tiếp không? (y/n): ");
                choice = Console.ReadLine();
            } while (choice.ToUpper() == "Y");
        }
        public void Xuat()
        {
            //Xuất thông tin người lao động trong danh sách listNLD
            Console.WriteLine("=========" + tenTrungTam + "=========");
            Console.WriteLine("{0,-15} {1,-20} {2,15} {3,15} {4,20}"
                , "Mã số", "Họ tên", "Giới tính", "Năm sinh", "Lương");

            foreach (NguoiLaoDong nld in listNLD)
            {
                string formatGioiTinh = nld.Gioitinh.ToUpper();
                if (formatGioiTinh == "NAM")
                {
                    formatGioiTinh = "Nam";
                }
                else if (formatGioiTinh == "NỮ")
                {
                    formatGioiTinh = "Nữ";
                }
                else if(formatGioiTinh=="KHÁC")
                {
                    formatGioiTinh = "Khác";
                }


                Console.WriteLine("{0,-15} {1,-20} {2,15} {3,15} {4,20}"
                    , nld.Maso, nld.Hoten, formatGioiTinh, nld.Namsinh, nld.TinhLuong().ToString("N0") + "VND");
            }
        }
        public int TinhTongLuong()
        {
            double tongluong = 0;
            foreach (NguoiLaoDong nld in listNLD)
            {
                tongluong += nld.TinhLuong();
            }
            return (int)tongluong;
        }
        public float TinhLuongTB()
        {
            float sum = 0;
            foreach (NguoiLaoDong nguoilaodong in listNLD)
            {
                sum += nguoilaodong.TinhLuong();
            }
            if (listNLD.Count == 0)
            {
                return 0; // Tránh chia cho 0
            }
            float avg = sum / listNLD.Count;
            return avg;
        }
    }
}


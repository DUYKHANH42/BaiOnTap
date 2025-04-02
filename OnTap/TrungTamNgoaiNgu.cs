using System;
using System.Collections.Generic;

namespace OnTap
{
    public class TrungTamNgoaiNgu
    {
        private string tentrungtam;
        List<NguoiLaoDong> ListNLD = new List<NguoiLaoDong>();
        public TrungTamNgoaiNgu()
        {
            ListNLD = new List<NguoiLaoDong>();
            tentrungtam = "Trung tâm ngoại ngữ ABC";
        }
        public void DuLieu()
        {
            ListNLD.Add(new NhanVien("NV01", "Nguyễn Văn A", "Nam", 1990, 2.5f));
            ListNLD.Add(new NhanVien("NV02", "Nguyễn Thị B", "Nữ", 1991, 3.0f));
            ListNLD.Add(new GiaoVien("GV01", "Trần Văn C", "Nam", 1980, 40));
            ListNLD.Add(new GiaoVien("GV02", "Trần Thị D", "Nữ", 1981, 35));
        }
        public bool KiemTraMaso(string maso)
        {

            foreach (NguoiLaoDong nld in ListNLD)
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
            //Nhập thông tin người lao động và thêm vào danh sách ListNLD
            string choice;
            do
            {
                Console.WriteLine("Chọn loại người lao động (1-Nhân viên, 2-Giáo viên): ");
                int chon = int.Parse(Console.ReadLine());
                NguoiLaoDong nld;
                if (chon == 1)
                {
                    nld = new NhanVien();
                    nld.Nhap();
                   if (KiemTraMaso(nld.Maso))
                    {
                        ListNLD.Add(nld);
                    }
                }
                else if (chon == 2)
                {
                    nld = new GiaoVien();
                    nld.Nhap();
                    if (KiemTraMaso(nld.Maso))
                    {
                        ListNLD.Add(nld);
                    }
                }
                Console.Write("Bạn có muốn nhập tiếp không? (y/n): ");
                choice = Console.ReadLine();
            } while (choice.ToUpper() == "Y");
        }
        public void Xuat()
        {
            //Xuất thông tin người lao động trong danh sách ListNLD
            Console.WriteLine("========="+tentrungtam+"=========");
            Console.WriteLine("{0,-15} {1,-20} {2,15} {3,15} {4,20}"
                , "Mã số", "Họ tên", "Giới tính", "Năm sinh", "Lương");
            foreach (NguoiLaoDong nld in ListNLD)
            {
                Console.WriteLine("{0,-15} {1,-20} {2,15} {3,15} {4,20}"
                    , nld.Maso, nld.Hoten, nld.Gioitinh, nld.Namsinh, nld.TinhLuong().ToString("#,00 VND"));
            }
        }
        public int TinhTongLuong()
        {
            double tongluong = 0;
            foreach (NguoiLaoDong nld in ListNLD)
            {
                tongluong += nld.TinhLuong();
            }
            return (int)tongluong;
        }
        public float TinhLuongTB()
        {
            float sum = 0;
            foreach (NguoiLaoDong nguoilaodong in ListNLD)
            {
                sum +=nguoilaodong.TinhLuong() ;
            }
            float avg = sum / ListNLD.Count;
            return avg;
        }
    }
}


using System;

namespace OnTap
{
    abstract public class NguoiLaoDong
    {
        string maso;
        string hoten;
        string gioitinh;
        int namsinh;
        public NguoiLaoDong()
        {
            maso = "";
            hoten = "";
            gioitinh = "";
            namsinh = 0;
        }
        public NguoiLaoDong(string maso, string hoten, string gioitinh, int namsinh)
        {
            this.maso = maso;
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.namsinh = namsinh;
        }
        public string Maso
        {
            get { return maso; }
            set { maso = value; }
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        public int Namsinh
        {
            get { return namsinh; }
            set { namsinh = value; }
        }
        protected bool kiemTraGioiTinh()
        {
            Console.WriteLine("Nhập giới tính (NAM/NỮ/KHÁC): ");
            Gioitinh = Console.ReadLine().Trim().ToUpper();
            if (Gioitinh.ToUpper() == "NAM" || Gioitinh.ToUpper() == "NỮ" || Gioitinh.ToUpper() == "KHÁC")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Giới tính không hợp lệ. Vui lòng nhập lại!");
                while (Gioitinh.ToUpper() != "NAM" && Gioitinh.ToUpper() != "NỮ" && Gioitinh.ToUpper() != "KHÁC")
                {
                    Console.WriteLine("Nhập giới tính (NAM/NỮ/KHÁC): ");
                    Gioitinh = Console.ReadLine().Trim().ToUpper();
                }
                return false;
            }
        }
        public virtual void Nhap()
        {
            Console.Write("Nhập mã số: ");
            Maso = Console.ReadLine();
            Console.Write("Nhập họ tên: ");
            Hoten = Console.ReadLine();
            kiemTraGioiTinh();
            Console.Write("Nhập năm sinh: ");
            if (!int.TryParse(Console.ReadLine(), out namsinh))
            {
                Console.WriteLine("Năm sinh không hợp lệ. Vui lòng nhập lại!");
            }
        }
        public abstract int TinhLuong();

    }
}

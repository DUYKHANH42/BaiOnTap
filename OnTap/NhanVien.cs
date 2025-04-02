using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    public class NhanVien : NguoiLaoDong
    {
        float hesoluong;
        public NhanVien() : base()
        {
            hesoluong = 0;
        }
        public NhanVien(string maso, string hoten, string gioitinh, int namsinh, float hesoluong) : base(maso, hoten, gioitinh, namsinh)
        {
            this.hesoluong = hesoluong;
        }
        public float Hesoluong
        {
            get { return hesoluong; }
            set { hesoluong = value; }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập hệ số lương: ");
            hesoluong = float.Parse(Console.ReadLine());
        }
        public override int TinhLuong()
        {
            int TinhLuongNV = 0;
            TinhLuongNV = (int)(Hesoluong * 2340000);
            return TinhLuongNV;
        }
    }
}

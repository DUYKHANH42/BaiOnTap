using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
    public class GiaoVien:NguoiLaoDong
    {
        int sotietday;
        public GiaoVien() : base()
        {
            sotietday = 0;
        }
        public GiaoVien(string maso, string hoten, string gioitinh, int namsinh, int sotietday) : base(maso, hoten, gioitinh, namsinh)
        {
            this.sotietday = sotietday;
        }
        public int Sotietday
        {
            get { return sotietday; }
            set { sotietday = value; }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập số tiết dạy: ");
            if (!int.TryParse(Console.ReadLine(), out sotietday))
            {
                Console.WriteLine("Số tiết dạy không hợp lệ. Vui lòng nhập lại!");
            }
        }
        public override int TinhLuong()
        {
            int TinhLuongGV = 0;
            TinhLuongGV = Sotietday * 320000;
            return TinhLuongGV;
        }
    }
}

using System;

namespace OnTap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrungTamNgoaiNgu tt = new TrungTamNgoaiNgu();
            tt.DuLieu();
            int chon;
            do
            {
                Console.WriteLine("========Trung tâm ngoại ngữ ABC========");
                Console.WriteLine("1. Nhập thông tin người lao động");
                Console.WriteLine("2. Xuất thông tin người lao động");
                Console.WriteLine("3. Tính tổng lương");
                Console.WriteLine("4. Tính lương trung bình của trung tâm");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        tt.Nhap();
                        break;
                    case 2:
                        tt.Xuat();
                        break;
                    case 3:
                        Console.WriteLine("Tổng lương: " + tt.TinhTongLuong().ToString("#,00 VND"));
                        break;
                    case 4:
                        Console.WriteLine("Lương trung bình: " + tt.TinhLuongTB().ToString("#,00 VND"));
                        break;
                    case 5:
                        Console.WriteLine("Hẹn Gặp Lại");
                        break;
                    default:
                        Console.WriteLine("Chức năng không hợp lệ");
                        break;
                }
            } while (chon != 5);
            Console.ReadLine();
        }
    }
}

using Ho_Minh_Hung.Session4;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ho_Minh_Hung.Session3
{
    internal class _15_cau_BTVN
    {
        static void bai1()
        {
            Console.Write("Nhap chi so dien cu: ");
            int chiSoCu = int.Parse(Console.ReadLine());
            Console.Write("Nhap chi so dien moi: ");
            int chiSoMoi = int.Parse(Console.ReadLine());
            while (chiSoCu > chiSoMoi)
            {
                Console.WriteLine("Nhap sai roi, nhap lai cho dung");
                Console.Write("Nhap chi so dien cu: ");
                chiSoCu = int.Parse(Console.ReadLine());
                Console.Write("Nhap chi so dien moi: ");
                chiSoMoi = int.Parse(Console.ReadLine());
            }
            int soDienTieuThu = chiSoMoi - chiSoCu;
            decimal giaChuaThue = (decimal)(soDienTieuThu) * 3000m;
            decimal Thue = giaChuaThue * 0.08m;
            decimal giaSauThue = giaChuaThue + Thue;
            Console.WriteLine($"So dien tieu thu: {soDienTieuThu}kWh");
            Console.WriteLine($"Tien dien chua thue: {giaChuaThue:#,##0}VND");
            Console.WriteLine($"Thue VAT (8%): {Thue:#,##0}VND");
            Console.WriteLine($"Tien dien sau thue: {giaSauThue:#,##0}VND");
        }
        public static void Main(string[] args)
        {
            bai1();
            Console.ReadKey();
        }

    }
}

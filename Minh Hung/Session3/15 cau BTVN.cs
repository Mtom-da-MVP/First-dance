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
        static void bai2()
        {
            Console.Write("Nhap chieu cao (met): ");
            double chieuCao = double.Parse(Console.ReadLine());
            Console.Write("Nhap can nang (kg): ");
            double canNang = double.Parse(Console.ReadLine());
            double BMI = canNang / Math.Pow(chieuCao,2);
            Console.WriteLine($"Chi so BMI cua ban: {BMI:F2}");
            if (BMI < 18.5)
            {
                Console.WriteLine("Phan loai suc khoe: Thieu can");
            }
            if (BMI >= 18.5 && BMI < 23)
            {
                Console.WriteLine("Phan loai suc khoe: Binh thuong");
            }
            if (BMI >= 23 && BMI <25)
            {
                Console.WriteLine("Phan loai suc khoe: Tien beo phi");
            }
            if (BMI >= 25)
            {
                Console.WriteLine("Phan loai suc khoe: Beo phi");
            }
            double canNangToiThieu = 18.5 * Math.Pow(chieuCao, 2);
            double canNangToiDa = 22.9 * Math.Pow(chieuCao, 2);
            Console.WriteLine($"Khuyen dung: Can nang ly tuong cua ban nen tu" +
                $" {canNangToiThieu:F2}kg den {canNangToiDa:F2}kg");
        }
        public static void Main(string[] args)
        {
            bai1();
            bai2();
            Console.ReadKey();
        }

    }
}

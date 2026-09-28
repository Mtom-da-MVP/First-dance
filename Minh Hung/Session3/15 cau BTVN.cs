using Ho_Minh_Hung.Session4;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            switch(BMI)
            {
                case double n when n < 18.5:
                Console.WriteLine("Phan loai suc khoe: Thieu can");
                    break;
                case double n when n >= 18.5 && n < 23:
                Console.WriteLine("Phan loai suc khoe: Binh thuong");
                    break;
                case double n when n >= 23 && n < 25:
                Console.WriteLine("Phan loai suc khoe: Tien beo phi");
                    break;
                default:
                Console.WriteLine("Phan loai suc khoe: Beo phi");
                    break;
            }
            double canNangToiThieu = 18.5 * Math.Pow(chieuCao, 2);
            double canNangToiDa = 22.9 * Math.Pow(chieuCao, 2);
            Console.WriteLine($"Khuyen dung: Can nang ly tuong cua ban nen tu" +
                $" {canNangToiThieu:F2}kg den {canNangToiDa:F2}kg");
        }

        
            enum CurrencyType
            {
                USD = 1,
                EUR = 2,
                JPY = 3,
                GBP = 4
            }
        static decimal doiTien(decimal vnd, CurrencyType type)
        {
            decimal netvnd = vnd * (1 - 0.005m);
            decimal rate = type switch
            {
                CurrencyType.USD => 25400m,
                CurrencyType.EUR => 27200m,
                CurrencyType.JPY => 165m,
                CurrencyType.GBP => 32000m,
            };
            return Math.Round(netvnd / rate, 2);
                
        }
        static void DemNgaySinhNhat(string dobstr)
        {
            if (!DateTime.TryParseExact(dobstr, "dd/mm/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dob)) return;
            DateTime today = DateTime.Now.Date;
            int age = today.Year - dob.Year;
            if (today < dob.AddYears(age)) age--;
            DateTime nextbirthday = dob.AddYears(age + (today > dob.AddYears(age) ? 1 : 0));
            Console.WriteLine($"Tuoi: {age}");
        }
        
        
        public static void Main1(string[] args)
        {

            decimal soTienVnd = 10000000m;
            decimal usd = doiTien(soTienVnd, CurrencyType.USD);
            Console.WriteLine($"10 trieu vnd doi ra duoc {usd}USD");

            Console.ReadKey();
        }

    }
}

using Ho_Minh_Hung.Session4;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ho_Minh_Hung.Session6
{
    internal class BTVN
    {
        public static void Main(string[] args)
        {
            //Bai 1
            int c = 5;
            int d = 6;
            Console.WriteLine($"Tong la: {TinhTong(c, d)}");
            //Bai 2
            Console.Write("Nhap so muon kiem tra chan le: ");
            int a = int.Parse(Console.ReadLine());
            if (KiemTraChan(a)) Console.WriteLine($"{a} la so chan");
            else Console.WriteLine($"{a} la so le");
            //Bai 3
            int x = 3; int y = 6; int z = 9;
            Console.WriteLine($"So lon nhat trong 3 so la: {timSoLonNhat(x, y, z)}");
            //Bai 4
            Console.Write("Nhap so muon tim giai thua: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Giai thua cua {b} la: {TinhGiaiThua(b)}");
            //Bai 5
            Console.Write("Nhap chuoi muon dao: ");
            string chuoiCanDao = Console.ReadLine();
            Console.WriteLine($"Chuoi da dao nguoc la: {DaoNguocChuoi(chuoiCanDao)}");
            //Bai 6
            Console.Write("Nhap so can kiem tra nguyen to: ");
            int soCanKiemTra = int.Parse(Console.ReadLine());
            Console.WriteLine($"{KiemTraNguyenTo(soCanKiemTra)}");
            //Bai 7
            //Bai 8
            //Bai 9
            //Bai 10
            //Bai 11
            //Bai 12
            Console.Write("Nhap do C: ");
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine($"Do F tuong ung la: {CelsiusToFahrenheit(celsius)}");
            //Bai 13
            //Bai 14
            int e = 738;
            Console.WriteLine($"Tong cac chu so cua e = 738 la: {tongCacChuSo(e)}");
            //Bai 15
            //Bai 16
            //Bai 17
            int f = 24;
            int g = 36;
            Console.WriteLine($"Uoc chung lon nhat cua 24 va 36 la: {UCLN(f, g)}");
            //Bai 18
            //Bai 19
            int i = 2026;
            if (KTNN(i)) Console.WriteLine("Nam 2026 la nam nhuan");
            else Console.WriteLine("Nam 2026 ko phai nam nhuan");
            //Bai 20
        }

        static int TinhTong(int a, int b)
        {
            return a + b;
        }

        static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }

        static int timSoLonNhat(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        static long TinhGiaiThua(int n)
        {
            long giaiThua = 1;
            for(int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }
            return giaiThua;
        }

        static string DaoNguocChuoi(string input)
        {
            char[] chuyenThanhMang = input.ToCharArray();
            Array.Reverse(chuyenThanhMang);
            string chuoiDaDao = new string(chuyenThanhMang);
            return chuoiDaDao;
        }

        static bool KiemTraNguyenTo(int n)
        {
            if (n <= 2) return false;
            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static double CelsiusToFahrenheit(double c)
        {
            return (c * 1.8 + 32);
        }

        static int tongCacChuSo(int n)
        {
            int sum = 0;
            n = Math.Abs(n);
            while (n>0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (b == 0)
                return a;
            return UCLN(b, a % b);
        }

        static bool KTNN(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }
    }
}

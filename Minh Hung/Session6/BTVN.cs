using Ho_Minh_Hung.Session4;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ho_Minh_Hung.Session6
{
    internal class BTVN
    {
        public static void Main1(string[] args)
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
            Console.WriteLine("Nhap do dai day fibonacci: ");
            int doDai = int.Parse(Console.ReadLine());
            fibonacci(doDai);
            //Bai 8
            Console.WriteLine("Nhap chuoi can dem nguyen am");
            string chuoi = Console.ReadLine();
            Console.WriteLine($"So nguyen am trong chuoi la: {demNguyenAm(chuoi)}");
            //Bai 9
            Console.WriteLine("Nhap so can duoc luy thua: ");
            int soLuyThua = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap bac luy thua: ");
            int bacLuyThua = int.Parse(Console.ReadLine());
            Console.WriteLine($"Luy thua bac {bacLuyThua} cua {soLuyThua} la: {tinhLuyThua(soLuyThua, bacLuyThua)}");
            //Bai 10
            int[] arr = new int[4] { 4, 5, 6, 7 };
            Console.WriteLine($"Trung binh cua mang '4, 5, 6, 7' la : {tinhTrungBinhMang(arr)}");
            //Bai 11
            Console.WriteLine("Nhap tu ban muon kiem tra: ");
            string s = Console.ReadLine();
            Console.WriteLine($"{kiemTraDoiXung(s)}");
            //Bai 12
            Console.Write("Nhap do C: ");
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine($"Do F tuong ung la: {CelsiusToFahrenheit(celsius)}");
            //Bai 13
            int[] arr1 = new int[5] { 10, 5, 8, 2, 9 };
            Console.WriteLine($"Gia tri nho nhat trong mang tren la: {timMinMang(arr1)}");
            //Bai 14
            int so = 1234;
            Console.WriteLine($"Tong cac chu so cua 1234 la: {tongCacChuSo(so)}");
            //Bai 15
            int[] arr2 = new int[4] { 3, 1, 4, 2 };
            sapXepMang(arr2);
            Console.Write("Mang sau khi sap xep la: ");
            foreach (int giaTri in arr2)
                Console.Write($"{giaTri} ");
            //Bai 16
            string tuThu = "programming";
            Console.WriteLine($"programming sau khi xoa trung lap la: {xoaTrungLap(tuThu)}");
            //Bai 17
            int f = 24;
            int g = 36;
            Console.WriteLine($"Uoc chung lon nhat cua 24 va 36 la: {UCLN(f, g)}");
            //Bai 18
            int soCanChuyen = 10;
            Console.WriteLine($"10 chuyen sang dang nhi phan la: {decimalToBinary(soCanChuyen)}");
            //Bai 19
            int i = 2026;
            if (KTNN(i)) Console.WriteLine("Nam 2026 la nam nhuan");
            else Console.WriteLine("Nam 2026 ko phai nam nhuan");
            //Bai 20
            string sentence = "Học lập trình C# rất thú vị";
            Console.WriteLine($"So tu trong cau Hoc lap trinh C# rat thu vi la: {demSoTu(sentence)}");
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

        static void fibonacci(int n)
        {
            long a = 0;
            long b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                long next = a + b;
                a = b;
                b = next;
            }
        }

        static int demNguyenAm(string s)
        {
            int count = 0;
            foreach (char c in s)
                if ("aieouAIEOU".Contains(c))
                    count++;
            return count;
        }

        static double tinhLuyThua(int x, int y)
        {
            double ketQua = 1;
            for (int i = 0; i < y; i++)
            {
                ketQua *= x;
            }
            return ketQua;
        }

        static double tinhTrungBinhMang(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }

        static bool kiemTraDoiXung(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }

        static double CelsiusToFahrenheit(double c)
        {
            return (c * 1.8 + 32);
        }

        static int timMinMang(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }

        static int tongCacChuSo(int n)
        {
            n = Math.Abs(n);
            int sum = 0;
            while (n > 0)
            {
                sum += n%10;
                n /= 10;
            }
            return sum;
        }

        static void sapXepMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static string xoaTrungLap(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                if (!result.Contains(c))
                    result += c;
            }
            return result;
        }

        static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (b == 0)
                return a;
            return UCLN(b, a % b);
        }

        static string decimalToBinary(int n)
        {
            string result = "";
            if (n == 0)
                return "0";
            while (n > 0)
            {
                int remain = n % 2;
                result = remain + result;
                n = n / 2;
            }
            return result;
        }

        static bool KTNN(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }

        static int demSoTu(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;
            int count = 0;
            bool inWord = false;
            for (int i = 0; i < s.Length; i ++)
            {
                if (s[i] != ' ' && s[i] != '\t')
                {
                    if (!inWord)
                    {
                        count++;
                        inWord = true;
                    }
                }
                else
                {
                    inWord = false;
                }
            }
            return count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ho_Minh_Hung.Session5
{
    internal class BT_tren_lop
    {
        public static void Main(string[] args)
        {
            bai2();
            Console.ReadKey();
        }
        static void bai2()
        {
            double n = 10;
            double a = 0;
            Console.WriteLine("Nhap 10 so muon tinh");
            for (int i = 1; i <= n; i++)
            {
                a += double.Parse(Console.ReadLine());
            }
            double sum = a;
            double avg = (double)(a / n);
            Console.WriteLine($"Tong 10 so tren la: {sum}");
            Console.WriteLine($"Trung binh 10 so tren la: {avg}");
        }
    }
}

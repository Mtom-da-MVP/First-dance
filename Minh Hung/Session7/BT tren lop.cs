using System;
using System.Collections.Generic;
using System.Text;

namespace Ho_Minh_Hung.Session7
{
    internal class BT_tren_lop
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap do dai mang mong muon: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = Random.Shared.Next(10, 100);
            }
            Console.WriteLine($"{a}");
            Console.Write($"Trung binh cong cua cac phan tu mang tren la: {calcAvg}");
        }

        static float calcAvg(int[]a, int n)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum / a.Length;
        }
    }
}

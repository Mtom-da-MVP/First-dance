using System;
using System.Collections.Generic;
using System.Text;

namespace Ho_Minh_Hung.Session7
{
    internal class BTVN_Array_3
    {
        public static void Main11(string[] args)
        {
            //Thanh lap mang 2 chieu
            int n;
            int m;
            Console.Write("Nhap so hang mong muon: ");
            while (!int.TryParse(Console.ReadLine(), out n))
                Console.WriteLine("Gia tri nhap vao khong hop le!");
            Console.Write("Nhap so cot mong muon: ");
            while (!int.TryParse(Console.ReadLine(), out m))
                Console.WriteLine("Gia tri nhap vao khong hop le!");
            int[,] arr = thanhLapMang(n, m);
            //In mang 2 chieu vua thanh lap
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{arr[i, j]}  ");
                }
                Console.WriteLine();
            }
            //In dong/cot cu the
            string choice;
            while (true)
            {
                Console.Write("Ban muon in dong hay cot: Nhap so 1 neu muon in dong, Nhap so 2 neu muon in cot: ");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2")
                    break;
                else
                    Console.WriteLine("Nhap sai roi, chi duoc nhap 1 hoac 2 thoi");
            }
            if (choice == "1")
            {
                int dongSoI;
                while (true)
                {
                    Console.Write("Nhap dong ban muon in: ");
                    while (!int.TryParse(Console.ReadLine(), out dongSoI))
                        Console.WriteLine($"Gia tri nhap vao phai la 1 so tu 0 den {n - 1}");
                    if (dongSoI >= 0 && dongSoI <= n - 1)
                        break;
                    else
                        Console.WriteLine($"Gia tri nhap vao phai la 1 so tu 0 den {n - 1}");
                }
                inDong(arr, dongSoI, m);
            }
            if (choice == "2")
            {
                int cotSoI;
                while (true)
                {
                    Console.Write("Nhap cot ban muon in: ");
                    while (!int.TryParse(Console.ReadLine(), out cotSoI))
                        Console.WriteLine($"Gia tri nhap vao phai la 1 so tu 0 den {m - 1}");
                    if (cotSoI >= 0 && cotSoI <= m - 1)
                        break;
                    else
                        Console.WriteLine($"Gia tri nhap vao phai la 1 so tu 0 den {n - 1}");
                }
                inCot(arr, n, cotSoI);
            }
            //Chuyen vi ma tran
            Console.WriteLine("Ma Tran sau chuyen vi: ");
            int[,] maTranDaChuyenVi = chuyenViMaTran(arr, n, m);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{maTranDaChuyenVi[i, j]}  ");
                }
                Console.WriteLine();
            }

        }

        static int[,] thanhLapMang(int n, int m)
        {
            int[,] arr = new int[n,m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(0, 9 + 1);
                }
            }
            return arr;
        }

        static void inDong(int[,] arr, int n, int m)
        {
            for (int i = 0; i < m; i++)
                Console.Write($"{arr[n,i]}  ");
            Console.WriteLine();
        }

        static void inCot(int[,] arr, int n, int m)
        {
            for (int i = 0; i < n; i ++)
                Console.WriteLine($"{arr[i,m]}");
        }

        static int[,] chuyenViMaTran(int[,] arr, int n, int m)
        {
            int[,] transposedArr = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    transposedArr[i, j] = arr[j, i];
            }
            return transposedArr;
        }
    }
}

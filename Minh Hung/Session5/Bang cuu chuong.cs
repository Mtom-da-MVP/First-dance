using System;
using System.Collections.Generic;
using System.Text;

namespace Ho_Minh_Hung.Session5
{
    internal class Bang_cuu_chuong
    {
        public static void Main1(string[] args)
        {
            BangCuuChuong();
            Console.ReadKey();
        }
        
        static void BangCuuChuong()
        {
            int n = 15;
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Ho_Minh_Hung
{
    internal class Bai_tap_tren_lop
    {
        static void bai_1()
        {
            int a = 6;
            int b = 7;
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} % {b} = {a % b}");
            Console.ReadKey();
        }
        static void bai_2()
        {
            Console.Write("Nhap y = ");
            int y = int.Parse( Console.ReadLine() );

            int x = y*y + 2*y + 1;
            Console.WriteLine($"y^2 + 2y + 1 = {x}");
            
        }
        public static void Main1(string [] args)
        {
            bai_1();
            bai_2();
            Console.ReadKey();
        }
    }    
}

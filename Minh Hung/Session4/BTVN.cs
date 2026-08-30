using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Ho_Minh_Hung.Session4
{
    internal class BTVN
    {
        static void bai1()
        {
            Console.Write("Nhap so can kiem tra vao day: ");
            int a = int.Parse(Console.ReadLine());
            int b = a % 2;
            if (b == 0)
            {
                Console.WriteLine($"{a} la so chan");
            }
            else
            {
                Console.WriteLine($"{a} la so le");
            }

        }
        static void bai2()
        {
            Console.Write("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu ba: ");
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine($"{a} la so lon nhat trong ba so");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"{b} la so lon nhat trong ba so");
            }
            else if (c > b && a < c)
            {
                Console.WriteLine($"{c} la so lon nhat trong ba so");
            }
            else
            {
                Console.WriteLine("Khong co so lon nhat trong ba so");
            }
        }
        static void bai3()
        {
            Console.Write("Nhap do dai canh thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap do dai canh thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap do dai canh thu ba: ");
            int c = int.Parse(Console.ReadLine());
            if (a == b && b == c)
            {
                Console.WriteLine("Day la tam giac deu");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Day la tam giac can");
            }
            else if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
            {
                Console.WriteLine("Day la tam giac vuong");
            }
            else
            {
                Console.WriteLine("Day la tam giac khong co gi dac biet");
            }
        }
        static void bai4()
        {
            Console.Write("Nhap hoanh do: ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Nhap tung do: ");
            float y = float.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Diem nam trong goc phan tu thu nhat");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Diem nam trong goc phan tu thu hai");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Diem nam trong goc phan tu thu ba");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Diem nam trong goc phan tu thu tu");
            }
            else
            {
                Console.WriteLine("Diem nam tren truc");
            }
        }
        public static void Main(string[] args)
        {
            bai1();
            bai2();
            bai3();
            bai4();
            Console.ReadKey();
        }
        
    }
}

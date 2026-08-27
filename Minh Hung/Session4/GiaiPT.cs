using System;
using System.Collections.Generic;
using System.Text;

namespace Ho_Minh_Hung.Session4
{
    internal class GiaiPT
    {
        static void GiaiPTrinh(double a, double b, double c)
        {
          
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phuong trinh co vo so nghiem");
                    }
                    else // c#0
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                }
                else // b # 0
                {
                    double x = -c / b;
                    Console.WriteLine($"x = {x}");
                }
            }
            else // a # 0
            {
                double delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else
                {
                    if (delta == 0)
                    {
                        double x = -b / (2 * a);
                        Console.WriteLine($"Phuong trinh co nghiem kep x = {x}");
                    }
                    else // delta > 0
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) /(2 * a);
                        Console.WriteLine($"Phuong trinh co 2 nghiem phan biet x1 = {x1} va x2 = {x2}");
                    }
                }
            }
        }
        public static void Main3(string [] args)
        {
            Console.Write("Nhap a ="); double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b ="); double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c ="); double c = double.Parse(Console.ReadLine());
            GiaiPTrinh(a, b, c);
            Console.ReadKey();
        }
        
    }
}

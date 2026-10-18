using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Ho_Minh_Hung.Session7
{
    internal class BTVN_array
    {
        public static void Main1(string[] args)
        {
            
            Console.Write("Nhap do dai mang mong muon: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Nhap sai dinh dang, phai nhap mot so nguyen");
            }
            int[] arr = taoMangNgauNhien(n);
            Console.WriteLine("Mang duoc tao ra la: ");
            //1.to calculate the average value of array elements.
            foreach (int a in arr)
                Console.Write($"{a}, ");
            Console.WriteLine($"\nTrung binh cong cua cac phan tu mang tren la: {calcAvg(arr)}");
            //2.to test if an array contains a specific value.
            Console.WriteLine("Nhap ki tu can kiem tra co trong mang hay khong: ");
            if (int.TryParse(Console.ReadLine(), out int target))
            {
                if (kiemTraKiTu(arr, target))
                    Console.WriteLine($"Co gia tri {target} trong mang nay");
                else
                    Console.WriteLine($"Khong co gia tri {target} trong mang nay");
            }
            else Console.WriteLine("Gia tri khong hop le!");
            //3.to find the index of an array element.
            Console.WriteLine("Nhap gia tri muon tim vi tri: ");
            if (int.TryParse(Console.ReadLine(), out int target1))
            {
                if (viTriTrongMang(arr, target1) != -1)
                {
                    Console.WriteLine($"Gia tri {target1} dau tien nam o vi tri {viTriTrongMang(arr, target1)} trong mang");
                }
                else
                    Console.WriteLine($"Khong co gia tri {target1} trong mang");
            }
            else
                Console.WriteLine("Gia tri nhap vao khong hop le");

            //4.to remove a specific element from an array.
            //5.to find the maximum and minimum value of an array.
            //6.to reverse an array of integer values.
            //7.to find duplicate values in an array of values.
            //8.to remove duplicate elements from an array.

        }

        static int[] taoMangNgauNhien(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Random.Shared.Next(1, 9 + 1);
            }
            return arr;
        }

        static float calcAvg(int[] a)
        {
            float sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return (sum / a.Length);
        }

        static bool kiemTraKiTu(int[] arr, int target)
        {
            foreach (int item in arr)
            {
                if (item == target)
                    return true;
            }
            return false;
        }

        static int viTriTrongMang(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }
            return -1;
        }
         
    }
}

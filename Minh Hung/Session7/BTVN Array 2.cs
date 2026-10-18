using System;
using System.Collections.Generic;
using System.Text;

namespace Ho_Minh_Hung.Session7
{
    internal class BTVN_Array_2
    {
        public static void Main(string[] args)
        {
            //Bubble Sort
            Console.WriteLine("Hay nhap 10 so nguyen vao mang: ");
            int[] arr = thanhLapMang();
            Console.WriteLine("Mang duoc thanh lap la: ");
            foreach (int a in arr)
            {
                Console.Write($"{a}, ");
            }
            Console.WriteLine("\nMang sau khi Bubble Sort: ");
            arr = bubbleSort(arr);
            foreach (int a in arr)
                Console.Write($"{a}, ");
            //Linear search
            Console.WriteLine("Hay nhap mot cau van: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Nhap tu can kiem tra: ");
            string target = Console.ReadLine();
            if (timTuTrongCau(words, target))
                Console.WriteLine($"Co tu '{target}' trong cau");
            else
                Console.WriteLine($"Khong co tu '{target}' trong cau");
        }

        static int[] thanhLapMang()
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                int a;
                Console.Write($"Vi tri thu {i}: ");
                while(!int.TryParse(Console.ReadLine(), out a)) 
                {
                    Console.WriteLine("Gia tri nhap vao khong hop le!");
                }
                arr[i] = a;
            }
            return arr;
        }
        
        static int[] bubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

        static bool timTuTrongCau(string[] arr, string target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (string.Equals(arr[i], target, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}

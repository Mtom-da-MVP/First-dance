using System;
using System.Collections.Generic;
using System.Text;

namespace Ho_Minh_Hung.Session8
{
    internal class BTVN_string
    {
        public static void Main(string[] args)
        {
            string s = "hello world";
            Console.WriteLine(s);
            Console.WriteLine($"Do dai cua chuoi tren la: {doDaiChuoi(s)}");
            Console.WriteLine($"Chuoi tren sau khi tach roi cac ki tu don le la: {tachKiTu(s)}");
            Console.WriteLine($"Chuoi tren dao nguoc lai la: {inDaoNguoc(s)}");
            Console.WriteLine($"So tu trong chuoi tren la: {demSoTu(s)}");
            string s1 = "hello wo";
            Console.WriteLine($"chuoi 1 la: {s} \nChuoi 2 la: {s1}");
            Console.WriteLine($"Hai chuoi nay co giong nhau khong: {soSanhChuoi(s, s1)}");
        }

        static int doDaiChuoi(string s)
        {
            if (s == null)
                return 0;
            int count = 0;
            foreach (char a in s)
                count++;
            return count;
        }

        static string tachKiTu(string s)
        {
            string ketQua = "";
            foreach (char c in s)
            {
                ketQua += c + " ";
            }
            return ketQua;
        }

        static string inDaoNguoc(string s)
        {
            string ketQua = "";
            for (int i = 0; i < s.Length; i++)
            {
                ketQua += s[s.Length - i - 1];
            }
            return ketQua;
        }

        static int demSoTu(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }
            bool InWord = false;
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    InWord = false;
                }
                else
                {
                    if (InWord == false)
                    {
                        InWord = true;
                        count++;
                    }
                }
            }
            return count;
        }

        static bool soSanhChuoi(string s, string s1)
        {
            bool ketQua;
            int lenS = doDaiChuoi(s);
            int lenS1 = doDaiChuoi(s1);
            if (lenS != lenS1)
                return ketQua = false;
            for (int i = 0; i < lenS; i++)
            {
                if (s[i] != s1[i])
                    return false;
            }
            return true;
        }
    }
}

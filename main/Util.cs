using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace main
{
    public class Util
    {
        public static bool Less(String s1, String s2)
        {
            char[] ca1 = s1.ToCharArray();
            char[] ca2 = s2.ToCharArray();
            int cycles = ca1.Length > ca2.Length ? ca2.Length : ca1.Length;
            for (int i = 0; i < cycles; i++)
            {
                if (ca1[i] != ca2[i])
                {
                    return ca1[i] - 97 < ca2[i] - 97;
                }
            }
            return s2.Length > s1.Length;
        }
        
        public static String[] GetText(String path)
        {
            String pattern = "[a-z][a-z']*";
            List<String> list = new List<string>();
            using (StreamReader sr = new StreamReader(new BufferedStream(File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))))
            {
                string line;  
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.ToLower();
                    MatchCollection matches = Regex.Matches(line, pattern);
                    foreach (Match match in matches)
                        list.Add(match.Value);
                } 
            }
            return list.ToArray();
        }

        public static void Show(String[] arr)
        {
            foreach (string s in arr)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }

        public static Boolean IsSorted(String[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (Less(arr[i], arr[i - 1])) return false;
            }

            return true;
        }

        public static String[] Switch(String[] a, int i, int j)
        {
            String tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
            return a;
        }
    }
}
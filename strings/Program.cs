using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str_res;
            string str1 = "Hello world from Abu Dhabi";
            string str2 = "This is a small letter string";
            string str3 = "THIS IS A CAPITAL LETTER STRING";
            string[] strs = {"one", "two", "three"};

            Console.WriteLine("Length of str1 is: {0} characters", str1.Length);
            Console.WriteLine(str1[0]);
            foreach (char c in str1) {
                if (c == ' ') {
                    Console.Write("_");
                }
                else if (Char.IsUpper(c)) {
                    Console.Write(Char.ToLower(c));
                }
                else {
                    Console.Write(c);
                }
            }
            Console.WriteLine(";");

            Console.WriteLine(String.Concat(strs));
            Console.WriteLine(String.Join("_", strs));
            Console.WriteLine(String.Join("", strs));
            Console.WriteLine(String.Join("----", strs));

            Console.WriteLine("String.Compare(str1, str2) -> {0}", String.Compare(str1, str2));
            Console.WriteLine("String.Compare(str1, str1) -> {0}", String.Compare(str1, str1));
            Console.WriteLine("String.Compare(str2, str1) -> {0}", String.Compare(str2, str1));

            Console.WriteLine("str2.Equals(str3) -> {0}", str2.Equals(str3));
            Console.WriteLine("str2.Equals(str3) -> {0}", str2.Equals(str2));

            Console.WriteLine("str1.IndexOf('o') -> {0}", str1.IndexOf('o'));
            Console.WriteLine("str1.IndexOf(\"from\") -> {0}", str1.IndexOf("Abu Dhabi"));

            Console.WriteLine("str1.LastIndexOf('o') -> {0}", str1.LastIndexOf('o'));
            Console.WriteLine("str1.LastIndexOf(\"from\") -> {0}", str1.LastIndexOf("from"));


            str_res = str1.Replace("Abu Dhabi", "Dubai");
            Console.WriteLine("str_res = str1.Replace(\"Abu Dhabi\", \"Dubai\") -> {0}", str_res);
            Console.WriteLine("str_res.IndexOf(\"Abu Dhabi\") -> {0}", str_res.IndexOf("Abu Dhabi"));

        }
    }
}
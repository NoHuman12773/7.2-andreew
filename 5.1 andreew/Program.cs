using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1_andreew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое предложение:");
            string str = Console.ReadLine();
            string s1 = str.Substring(0, str.IndexOf(' '));
            string s2 = str.Substring(str.LastIndexOf(' ') + 1, str.Length - str.LastIndexOf(' ') - 1);
            str = str.Remove(0, str.IndexOf(' '));
            str = str.Remove(str.LastIndexOf(' ') + 1, str.Length - str.LastIndexOf(' ') - 1);
            str = s2 + str + s1;
            Console.WriteLine(str);



            Console.ReadKey();
        }
    }
}

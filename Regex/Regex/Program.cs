using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Regextut
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello jhasd";
            Regex reg = new Regex("[^A-Z]+");
            Console.Write((reg.Replace(input.ToUpper(), "").Distinct() ) );
            //string  unique = reg.Replace(input.ToUpper(), "");
            //Console.Write(input[1]);
            //HashSet<char> distinct = new HashSet<char>();
            //foreach(char x in reg.Replace(input.ToUpper(),""))
            //{
            //    distinct.Add(x);
            //}
            //foreach(char x in distinct)
            //{
            //    Console.Write(x);
            //}

            //HashSet<Char[]> unique = new HashSet<char[]>();
            //foreach(char x in input)
            //{
            //    reg.Replace(x, "");
            //}
            //foreach(char[] j in unique) => Console.Write(j);
            Console.ReadLine();
        }
    }
}

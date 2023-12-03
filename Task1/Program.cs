using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyString myString = new MyString();

            var str = "aaaafffssssaaaabbccdeeee"; // Для компрессии


            var res1 = myString.StringCompression(str);
            Console.WriteLine(res1);


            var res2 = myString.StringDeCompression(res1);
            Console.WriteLine(res2);









        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            var rnd = new Random();

            int i = 0;
            int j = 0;

            int imax = rnd.Next(3,6);
            int jmax = rnd.Next(3,6);
            int[,] array = new int[imax,jmax];

            matrix.SetArray(array);
            matrix.VyvodArray(array);

           
            
            var newArray = matrix.GetArray(array);


            Console.WriteLine();
            foreach(var item in newArray)
            {
                Console.Write($"{item} ");
            }

           
            

            

           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            var rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                new Thread(() => Server.GetCount()).Start();
            }

            
            for (int i = 0; i < 2; i++)
            {
                new Thread(() => Server.AddToCount(rnd.Next(1,10))).Start();
            }
        }
    }
}

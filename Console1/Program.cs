using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    internal class Program
    {
      

        static void Main(string[] args)
        {
            MyStack<int> stak = new MyStack<int>(8);

            stak.Add(5);
            stak.Add(5);
            stak.Add(5);
            stak.Add(5);

            stak.GetAll();



        }

       
    }
}


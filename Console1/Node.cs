using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    internal class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
}

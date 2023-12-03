using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    internal class MyStack<T>
    {
        private Node<T> NodeHead { get; set; }

        public MyStack(T item)
        {
            NodeHead = new Node<T>();
            NodeHead.Data = item;
            NodeHead.Next = null;
        }

        public void Add(T item)
        {
            var node = NodeHead;
            while(node.Next != null) 
            {
                node = node.Next;
            }
            var newnode = new Node<T>();
                
            node.Next = newnode;
            newnode.Data = item;
            newnode.Next = null;
            
        }

        public void GetAll()
        {
            var node = NodeHead;

            while(node.Next != null)
            {
                Console.Write($"{node.Data} ");
                node = node.Next;
            }
            Console.Write($"{node.Data} ");
        }
    }
}

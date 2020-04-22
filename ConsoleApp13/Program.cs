using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Node
    {
        int number;
        Node next;
        public Node(int value)
        {
            number = value;
            next = null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(15);
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}

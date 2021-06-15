using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked list program");
            LinkedLi list = new LinkedLi();
            list.Insert(56);
            list.Insert(30);
            list.Insert(70);
            Console.WriteLine("List elements");
            list.Show(); ;
        }
    }
}

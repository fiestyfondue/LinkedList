using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked list program");
            LinkedLi list = new LinkedLi();
            list.Insert(67);
            list.Insert(23);
            list.Insert(43);
            Console.WriteLine("List elements");
            list.Show(); ;
        }
    }
}

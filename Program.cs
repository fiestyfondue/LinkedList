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
            list.Insert(70);
            list.InsertAt(1, 30);
            Console.WriteLine("List elements");
            list.Show();
            list.DeleteAt(0);
            Console.WriteLine("List elements after popLast()");
            list.Show();



        }
    }
}

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
            
            Console.WriteLine("List elements");
            list.Show();
            list.InsertAt(1, 30);
            Console.WriteLine("List elements after inserting 30");
            list.Show();
            list.InsertAt(2, 70);
            Console.WriteLine("List of elements after inserting 70");
            list.Show();



        }
    }
}

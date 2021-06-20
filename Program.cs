using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Linked list program");
            LinkedLi list = new LinkedLi();
           
            
            Console.WriteLine("List elements");
            list.Insert(56);
            list.Insert(70);
            list.Show();
            Console.WriteLine("List elements after inserting 30 between 56 and 70");
            list.InsertAt(1, 30);
            list.Show();
           


        }
    }
}

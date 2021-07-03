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
            list.Insert(30);
            list.Show();

            Console.WriteLine("Element to be searched here is 30");
            list.Search(30);
            Console.WriteLine("Show Ordered List");
            list.Show();

            
           


        }
    }
}

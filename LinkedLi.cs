using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedLi
    {
        Node head;

        /// indert data at the end

        public void Insert(int data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    n = n.next;
                }
                n.next = node;
            }
        }
        
    
  
        public void InsertAtStart(int data)        // Insert node at start.
        {
            Node node = new Node();
            node.data = data;
            node.next = null;

            node.next = head;
            head = node;
        }
      
       // Insert elements at particular index
       
        public void InsertAt(int index, int data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;

            Node n = head;
            for (int i = 0; i < index - 1; i++)
            {
                n = n.next;
            }
            node.next = n.next;
            n.next = node;
        }
      
        // print the list of elements
     
        public void Show()
        {
            Node node = head;
            while (node.next != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
            Console.WriteLine(node.data);
        }
     
        /// delete the first element only
    
        public void DeleteFirst()
        {
            head = head.next;
        }

        /// delete function at particular index
       
        public void DeleteAt(int index)
        {
            if (index == 0)
            {
                head = head.next;
            }
            else
            {
                Node n = head;
                // Node n1 = null;
                for (int i = 0; i < index - 1; i++)
                {
                    n = n.next;
                }
                // n1 = n.next;
                //n.next = n1.next;
                n.next = n.next.next;
            }
        }
        internal void PopLast()
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("No elements to delete");
            }
            if (head.next == null)
            {
                head = null;
            }
            else
            {
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
            }
        }
    }
}

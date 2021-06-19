using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{


    /// <summary>
    /// Stack node Object.
    /// </summary>
    class StNode
    {
        public int data;
        public StNode next;
    }
    /// <summary>
    /// implementing stack operations using linked list.
    /// </summary>
    class LinkedListStack
    {
        
        internal void push(int data)
        {
            StNode stnode = new StNode();
            stnode.data = data;
            stnode.next = null;

        }
    }  
}

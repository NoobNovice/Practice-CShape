using System;
using System.Collections.Generic;
using System.Text;

namespace Hw2
{
    class Node
    {
        public char data;
        public Node next, prev;

        public Node(char data, Node next, Node prev)
        {
            this.data = data;
            this.next = next;
            this.prev = prev;
        }
    }
}

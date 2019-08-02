using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4
{
    public class Node
    {
        public object data;
        public Node next, prev;

        public Node(object data, Node next, Node prev)
        {
            this.data = data;
            this.next = next;
            this.prev = prev;
        }
    }
}

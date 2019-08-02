using System;
using System.Collections.Generic;
using System.Text;

namespace Hw2
{
    class List
    {
        public Node head;
        public Node tail;
        private int lenght;

        public List()
        {
            this.head = null;
            this.tail = null;
            this.lenght = 0;
        }

        public void PushTohead(char i)
        {
            Node node = new Node(i, null, null);
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.next = head;
                head.prev = node;
                head = node;
            }
            lenght++;
        }

        public void PushTotail(char i)
        {
            Node node = new Node(i, null, null);
            if(tail == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                node.prev = tail;
                tail = node;
            }
            lenght++;
        }

        public char PopToHead()
        {
            if(head != null)
            {
                var sender = head.data;
                head = head.next;
                if(head != null)
                {
                    head.prev = null;
                }
                else
                {
                    tail = null;
                }
                lenght--;
                return sender;
            }
            return ' ';
        }

        public char PopToTail()
        {
            if(tail != null)
            {
                var sender = tail.data;
                tail = tail.prev;
                if (tail != null)
                { 
                    tail.next = null;
                }
                else
                {
                    head = null;
                }
                lenght--;
                return sender;
            }
            return ' ';
        }

        public bool Search(char i)
        {
            var point = head;
            while (point != null)
            {
                if(point.data == i)
                {
                    return true;
                }
                point = point.next;
            }
            return false;
        }

        public bool emtry()
        {
            return head == null ? true : false;
        }

        public string PrintForward()
        {
            var point = head;
            string str = "";
            while (point != null)
            {
                str += point.data.ToString() + " ";
                point = point.next;
            }
            return str;
        }

        public string PrintBackward()
        {
            var point = tail;
            string str = "";
            while (point != null)
            {
                str += point.data.ToString() + " ";
                point = point.prev;
            }
            return str;
        }
        
        public int getLenght()
        {
            return this.lenght;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4
{
    public class List
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

        public void PushTohead(object i)
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

        public void PushTotail(object i)
        {
            Node node = new Node(i, null, null);
            if (tail == null)
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

        public object PopToHead()
        {
            if (head != null)
            {
                var sender = head.data;
                head = head.next;
                if (head != null)
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

        public object PopToTail()
        {
            if (tail != null)
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

        public bool Search(object i)
        {
            var point = head;
            while (point != null)
            {
                if (point.data == i)
                {
                    return true;
                }
                point = point.next;
            }
            return false;
        }

        public bool Emtry()
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

        public int GetLenght()
        {
            return this.lenght;
        }

        public object ElementAt(int index)
        {
            Node point = head;
            int count = 0;
            while(point != null)
            {
                if(count == index)
                {
                    return point.data;
                }
                point = point.next;
                count++;
            }
            return null;
        }

        public bool Remove(object obj)
        {
            Node point = head;
            Node prev = null;

            while(point != null)
            {
                if (point.data.Equals(obj))
                {
                    if(lenght == 1)
                    {
                        head = null;
                        tail = null;
                    }
                    else
                    {
                        Node next = null;
                        try
                        {
                            next = point.next;
                        }
                        catch (NullReferenceException)
                        {

                        }

                        try
                        {
                            prev.next = next;
                            next.prev = prev;
                        }
                        catch (NullReferenceException)
                        {

                        }

                        point = null;
                    }
                    return true;
                }
                prev = point;
                point = point.next;
            }
            return false;
        }

        public bool Found(object obj)
        {
            Node point = head;

            while(point != null)
            {
                if (point.data.Equals(obj))
                {
                    return true;
                }
                point = point.next;
            }
            return false;
        }
    }
}

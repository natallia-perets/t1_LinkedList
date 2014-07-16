using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    internal class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int size;

        public LinkedList()
        {
            this.head = null;
            this.tail = null;
            size = 0;
        }

        public int GetSize()
        {
            return size;
        }

        public void Add(T data)
        {
            if (this.head == null)
            {
                this.head = new Node<T>(data);
                this.tail = this.head;
            }
            else
            {
                Node<T> newItem = new Node<T>(data);
                newItem.Data = data;
                newItem.Previous = tail;
                tail.Next = newItem;
                tail = newItem;
            }
            size++;
        }

        public void DeleteElement(int index)
        {
            int count = 0;
            Node<T> thisNode = head;
            Node<T> prevItem = null;
            while (count < index)
            {
                prevItem = thisNode;
                thisNode = thisNode.Next;
                count++;
            }
            if (size == 0)
            {
                head = null;
            }
            else if (prevItem == null)
            {
                head = thisNode.Next;
                head.Previous = null;
            }
            else if (index == size - 1)
            {
                prevItem.Next = thisNode.Next;
                tail = prevItem;
            }
            else
            {
                prevItem.Next = thisNode.Next;
                thisNode.Next.Previous = prevItem;
            }
            size --;

    }
        public T GetElement(int number)
           //how to process exception??
        {
            if (number < 0 || number > size)
               {
                    throw new IndexOutOfRangeException();
               }
            else
               {
                    int count = 1;
                    Node<T> thisnode = this.head;
                    while (count < number)
                    {
                        thisnode = thisnode.Next;
                        count++;
                    }
                    return thisnode.Data;
                }
           
      
        }

    }
}

using System;
using System.Collections.Generic;

namespace MyLinkedList
{
    internal class LinkedList<T>
    {
        private Node<T> head;
        private int size;
        private Node<T> tail;

        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public T this[int index]
        {
            get { return GetElementByIndex(index); }
            set
            {
                if (index >= size || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Out of range!");
                }
                Node<T> currentNode = head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Data = value;
            }
        }

        public int GetSize()
        {
            return size;
        }

        public void Add(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
                tail = head;
            }
            else
            {
                var newItem = new Node<T>(data);
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
            size--;
        }

        public T GetElement(int number)
        {
            if (number < 0 || number > size)
            {
                throw new IndexOutOfRangeException();
                //return default.T;
            }
            int count = 1;
            Node<T> thisnode = head;
            while (count < number)
            {
                thisnode = thisnode.Next;
                count++;
            }
            return thisnode.Data;
        }

        private T GetElementByIndex(int index)
        {
            if (index >= size || index < 0)
            {
                throw new ArgumentOutOfRangeException("Out of range!");
            }

            Node<T> currentNode = head;

            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }

            return currentNode.Data;
        }

        public void Sort(IComparer<T> comparer)
        {
            T temp;
            int j;

            for (int i = 0; i < GetSize(); i++)
            {
                temp = this[i];

                for (j = i - 1; j >= 0 && ((comparer.Compare(this[j], temp) == 1)); j--)
                {
                    this[j + 1] = this[j];
                }

                this[j + 1] = temp;
            }
        }
    }
}
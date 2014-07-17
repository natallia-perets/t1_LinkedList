using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    internal class Node<T>
    {
        private T data;
        private Node<T> next;
        private Node<T> prev;

        public Node(T data)
        {
            this.data = data;
            next = null;
            prev = null;
        }
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        public Node<T> Previous
        {
            get { return prev; }
            set { prev = value; }
        }


    }


}

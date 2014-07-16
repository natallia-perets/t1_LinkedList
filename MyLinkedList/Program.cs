using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(3);
            list.Add(8);
            list.Add(9);
            list.Add(15);
            //System.Console.WriteLine(list.GetSize());
            for (int i = 1; i <= list.GetSize(); i++)
            {
              System.Console.WriteLine(list.GetElement(i));
            } 
            System.Console.WriteLine(list.GetSize());
            
            list.DeleteElement(2);
            list.DeleteElement(3);
            System.Console.WriteLine();
            for (int i = 1; i <= list.GetSize(); i++)
            {
                System.Console.WriteLine(list.GetElement(i));
            }
            System.Console.WriteLine(list.GetSize());
            System.Console.ReadLine();
        }
    }
}

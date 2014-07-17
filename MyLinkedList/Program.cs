using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class Program
    {
        private static void Main(string[] args)
        {
            LinkedList<Person> plist = new LinkedList<Person>();
            plist.Add(new Person("Enn", "B", 19));
            plist.Add(new Person("Ann", "B", 18));
            plist.Add(new Person("Re", "E", 18));
            for (int i = 0; i < plist.GetSize(); i++)
            {
                Console.WriteLine(plist[i].FirstName);
            }
            LinkedList<Person>.FirstNameSort(plist);
            for (int i = 0; i < plist.GetSize(); i++)
            {
                Console.WriteLine(plist[i].FirstName);
            }
            System.Console.ReadLine();
        }
    }
}

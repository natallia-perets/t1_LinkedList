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
            plist.Add(new Person("Enn", "B", 20));
            plist.Add(new Person("Ann", "B", 32));
            plist.Add(new Person("Re", "E", 15));
            for (int i = 0; i < plist.GetSize(); i++)
            {
                Console.WriteLine(plist[i].ToString());
            }

            Console.WriteLine(Environment.NewLine);
            
            plist.Sort(new AgeSortComparer());

            for (int i = 0; i < plist.GetSize(); i++)
            {
                Console.WriteLine(plist[i].ToString());
            }
            System.Console.ReadLine();
        }
    }
}

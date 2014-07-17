using System.Collections.Generic;

namespace MyLinkedList
{
    public class DescFirstNamePersonComparer : IComparer<Person>
    {
        public int Compare(Person p1, Person p2)
        {
            return p2.FirstName.CompareTo(p1.FirstName);
        }

    }
}
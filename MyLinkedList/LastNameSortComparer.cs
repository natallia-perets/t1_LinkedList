using System.Collections.Generic;

namespace MyLinkedList
{
    public class LastNamePersonComparer : IComparer<Person>
    {
        public int Compare(Person p1, Person p2)
        {

            return p1.LastName.CompareTo(p2.LastName);
        }

    }
}
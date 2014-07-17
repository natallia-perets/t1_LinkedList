using System.Collections.Generic;

namespace MyLinkedList
{
    public class FirstNamePersonComparer : IComparer<Person>
    {
        public int Compare(Person p1, Person p2)
        {

            return p1.FirstName.CompareTo(p2.FirstName);
        }

    }
}
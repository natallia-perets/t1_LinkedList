using System.Collections.Generic;

namespace MyLinkedList
{
    public class AgeSortComparer : IComparer<Person>
    {
        public int Compare(Person p1, Person p2)
        {
            if (p1.Age > p2.Age) return 1;
            if (p1.Age < p2.Age) return -1;
            return 0;
        }

    }
}
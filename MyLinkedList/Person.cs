﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age
        {
            get { return Age; }
            set { age = value; }
        }
        public Person(string fn, string ln, int age)
        {
            FirstName = fn;
            LastName = ln;
            Age = age;
        }

        public class FirstNameSortHelper:IComparer<Person>

        {
            public int Compare(Person p1, Person p2)
            {
      
                return p1.FirstName.CompareTo(p2.FirstName);
            }
         
        }

        private class LastNameSortHelper : IComparer<Person>
        {
            public int Compare(Person p1, Person p2)
            {

                return p1.LastName.CompareTo(p2.LastName);
            }

        }

        private class ageSortHelper : IComparer<Person>
        {
            public int Compare(Person p1, Person p2)
            {
                if (p1.Age > p2.Age) return 1;
                if (p1.Age < p2.Age) return -1;
                return 0;
            }

        }

    }
}

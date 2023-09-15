using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
    public class Person
    {
        public string Name { get; set; }
        public Person ChildOne { get; set; }
        public Person ChildTwo { get; set; }

        ~Person()
        {
            Console.WriteLine($"   Collecting {Name}.");
        }
    }
}

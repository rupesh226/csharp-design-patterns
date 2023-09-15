using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
    public class MyGarbageCollection
    {

        static void ShortLives(Person parent)
        {
            Person fred = new Person
            {
                Name = "Fred",
                ChildOne = new Person { Name = "Bamm-Bamm" }
            };

            parent.ChildTwo = fred.ChildOne;
        }

        public static void Run()
        {
            Person wilma = new Person
            {
                Name = "Wilma",
                ChildOne = new Person { Name = "Pebbles" }
            };

            ShortLives(wilma);

            Console.WriteLine("Leaving 'ShortLives'...");

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}

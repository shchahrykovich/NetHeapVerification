using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace App
{
    public class Person
    {
        public String Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder b = new StringBuilder();
            List<Person> people = new List<Person>();
            for (int i = 0; i < 100000; i ++)
            {
                people.Add(new Person
                {
                    Name =  i.ToString()
                });

                b.AppendFormat("{0}: {1}", Process.GetCurrentProcess().Id, i);
            }

            Console.WriteLine("GC count 0: {0}", GC.CollectionCount(0));
            Console.WriteLine("GC count 1: {0}", GC.CollectionCount(1));
            Console.WriteLine("GC count 2: {0}", GC.CollectionCount(2));
        }
    }
}

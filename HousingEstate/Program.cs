using System;
using System.Collections.Generic;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Martin", "Stano", 16);

            Console.WriteLine(person.ToString());

            Console.WriteLine("***********************************");

            Flat flat = new Flat(1, 250, 4, new List<Person>() { person }) ;

            Console.WriteLine(flat.ToString());
        }
    }
}

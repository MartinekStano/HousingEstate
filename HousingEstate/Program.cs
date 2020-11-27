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
            int answer = 0;
            do
            {
                Console.WriteLine("1. Pridanie obyvatela");
                Console.WriteLine("2. Vypis obyvatelov bytu");
                

                answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1: flat.Addhabitant(); break;
                    case 2: flat.DiscribePeopleInFlat(); break;
                }    
                Console.WriteLine("4. Koniec");
                
            } while (!(answer == 4));
            Console.WriteLine("KONIEC");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Flat
    {
        public int NumberOfFlat { get; set; }
        public double AreaOfFlat { get; set; }
        public int CountOfRoom { get; set; }
        public static List<Person> PersonsInFlat { get; set; }
        public int Floor { get; set; }

        public Flat(int numberOfFlat, double areaOfFlat, int countOfRoom, List<Person> personsInFlat,int floor)
        {
            NumberOfFlat = numberOfFlat;
            AreaOfFlat = areaOfFlat;
            CountOfRoom = countOfRoom;
            PersonsInFlat = personsInFlat;
            Floor = floor;
        }

        public override string ToString()
        {
            return ($"Cislo bytu: {NumberOfFlat}\nRozloha bytu: {AreaOfFlat}\nPocet izieb: {CountOfRoom}");
        }

        public static void Addhabitant(string name, string surname, int age)
        {
            Person person = new Person(name, surname, age);
            PersonsInFlat.Add(person);
        }
        public static void GetInfoAboutAllHabitants()
        {
            foreach(Person person in PersonsInFlat)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
            
            




       

 


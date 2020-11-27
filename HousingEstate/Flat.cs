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
        public List<Person> PersonsInFlat { get; set; }

        public Flat(int numberOfFlat, double areaOfFlat, int countOfRoom, List<Person> personsInFlat)
        {
            NumberOfFlat = numberOfFlat;
            AreaOfFlat = areaOfFlat;
            CountOfRoom = countOfRoom;
            PersonsInFlat = personsInFlat;
        }

        public override string ToString()
        {
            return ($"Cislo bytu: {NumberOfFlat}\nRozloha bytu: {AreaOfFlat}\nPocet izieb: {CountOfRoom}");
        }
       
    }
}
            

 


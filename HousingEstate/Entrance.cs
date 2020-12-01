using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Entrance
    {
        public int NumberOfEntrance { get; set; }
        public BlockOfFlats BlockOfFlats { get; set; }
        public static List<int> Floor = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
        public static List<Flat> Flats = new List<Flat>();
        public Entrance(int numberOfEntrance,  BlockOfFlats blockOfFlats, List<Flat> flats)
        {
            NumberOfEntrance = numberOfEntrance;
            BlockOfFlats = blockOfFlats;
            Flats = flats;
        }
        
        public static void AddNewFlat(int numberOfFlat, double areaOfFlat, int countOfRoom, List<Person> personsInFlat, int floor)
        {
            Flat flat = new Flat(numberOfFlat, areaOfFlat, countOfRoom, personsInFlat,floor);

            Flats.Add(flat);
        }
        
        public static void GetInfoAboutAllFlats()
        {
            foreach(Flat flat in Flats)
            {
                Console.WriteLine(flat.ToString());
            }
        }

        public override string ToString()
        {
            return $"{NumberOfEntrance}\n{BlockOfFlats.ToString()}\n{Floor}\n{Flats.ToString()}";
        }

        public void CheckHabitan()
        {

        }
        public static int ChooseFloor()
        {
            foreach(int floor in Floor)
            {
                Console.WriteLine(floor);
                    
            }
            Console.WriteLine("Vas vyber: ");
            return Floor[int.Parse(Console.ReadLine()) - 1];
        }

    }
}
       

       
            
            
       



            


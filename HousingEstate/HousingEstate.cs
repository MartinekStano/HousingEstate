using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class HousingEstate
    {
        public List<BlockOfFlats> BlockOfFlats { get; set; }
        

        public HousingEstate(List<BlockOfFlats> blockOfFlats)
        {
            BlockOfFlats = blockOfFlats;
        }

        public void AddPerson()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
        }
    }
}
            


        
          

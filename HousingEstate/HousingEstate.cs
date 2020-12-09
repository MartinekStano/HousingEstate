using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class HousingEstate
    {
        public static List<BlockOfFlats> BlockOfFlats { get; set; }
        public string Name { get; set; }

        public HousingEstate(string name)
        {
            BlockOfFlats = new List<BlockOfFlats>();
            Name = name;
        }
        public static void AddNewBlockOfFlats(int numberOfBlockOfFlats, string nameStreet)
        {
            BlockOfFlats blockOfFlats = new BlockOfFlats(numberOfBlockOfFlats, nameStreet);
            BlockOfFlats.Add(blockOfFlats);
            MoveInfAboutBlockOfFlats(blockOfFlats);
        }
        public static BlockOfFlats MoveInfAboutBlockOfFlats(BlockOfFlats blockOfFlats)
        {
            return blockOfFlats;
        }
        


    }
}
            


        
          

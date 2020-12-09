using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class BlockOfFlats
    {
        public int NumberOfBlockOfFlats { get; set; }
        public static List<Entrance> Entrance { get; set; }
        public string NameStreet { get; set; }
        public BlockOfFlats(int numberOfBlockOfFlats, string nameStreet)
        {
            NumberOfBlockOfFlats = numberOfBlockOfFlats;
            NameStreet = nameStreet;
        }
        public static void AddEntrance(int numberOfEntrance, BlockOfFlats blockOfFlats)
        {
            Entrance entrance = new Entrance(numberOfEntrance, blockOfFlats);
            Entrance.Add(entrance);
        }
        public override string ToString()
        {
            return $"Cislo panelaku:{NumberOfBlockOfFlats}\nUlica:{NameStreet}";
        }

       


    }
    


}

using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate
{
    class Entrance
    {
        public int NumberOfEntrance { get; set; }
        public BlockOfFlats BlockOfFlats { get; set; }
        public List<Flat> Flats { get; set; }
        public Entrance(int numberOfEntrance,  BlockOfFlats blockOfFlats, List<Flat> flats)
        {
            NumberOfEntrance = numberOfEntrance;
            BlockOfFlats = blockOfFlats;
            Flats = flats;
        }
    }
}
       

       
            
            
       



            


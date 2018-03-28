using System;
using System.Numerics;

namespace NationalParkGeeks.Models
{
    public class Park
    {
        public string ParkCode { get; set; }
        public string ParkName { get; set; }
        public string State { get; set; }
        public double Acreage { get; set; }
        public double ElevationInFeet { get; set; }
        public double MilesOfTrail { get; set; }
        public int NumberOfCampsites { get; set; }
        public string Climate { get; set; }
        public string YearFounded { get; set; }
        public long AnnualVisitorCount {get; set;}
        public string InspirationalQuoute { get; set; }
        public string InspirationalQuoteSource { get; set; }
        public string ParkDescription { get; set; }
        public string EntryFee { get; set; }
        public int NumberOfAnimalSpecies { get; set; }
        

        public Park()
        {
        }
    }
}

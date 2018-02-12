using System;
using System.Numerics;

namespace NationalParkGeeks.Models
{
    public class Park
    {
        private string ParkCode { get; set; }
        private string ParkName { get; set; }
        private string State { get; set; }
        private float Acreage { get; set; }
        private float ElevationInFeet { get; set; }
        private float MilesOfTrail { get; set; }
        private int NumberOfCampsites { get; set; }
        private string Climate { get; set; }
        private string YearFounded { get; set; }
        private BigInteger AnnualVisitorCount {get; set;}
        private string InspirationalQuoute { get; set; }
        private string InspirationalQuoteSource { get; set; }
        private string ParkDescription { get; set; }
        private string EntryFee { get; set; }
        private int NumberOfAnimalSpecies { get; set; }

        public Park()
        {
        }
    }
}

using System;
using NationalParkGeeks.Models;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Diagnostics.Contracts;


namespace NationalParkGeeks.DAL
{
    public class ParkDAL
    {
        public List<Park> GetParks()
        {
            List<Park> ParkList = new List<Park>();

            try
            {
                using(SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS;Database=NationalParkGeeks;Trusted_Connection=True;"))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM park", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        ParkList.Add(MapRowToPark(reader));
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }

            return ParkList;
        }

        public Park GetParkByParkCode(string ParkCode)
        {
            Park SelectedPark = null;

            try
            {
                using (SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS;Database=NationalParkGeeks;Trusted_Connection=True;"))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM park WHERE parkcode=(@bar)", conn);
                    cmd.Parameters.AddWithValue("@bar", ParkCode);
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    while(reader.Read())
                    {
                        SelectedPark = MapRowToPark(reader);
                    }
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }

            return SelectedPark;
        }

        public ParkDAL()
        {
        }

        private Park MapRowToPark(SqlDataReader reader)
        {
            Park NewPark = new Park();
            NewPark.ParkCode = Convert.ToString(reader["parkCode"]);
            NewPark.ParkName = Convert.ToString(reader["parkName"]);
            NewPark.State = Convert.ToString(reader["state"]);
            NewPark.Acreage = Convert.ToDouble(reader["Acreage"]);
            NewPark.ElevationInFeet = Convert.ToDouble(reader["elevationInFeet"]);
            NewPark.MilesOfTrail = Convert.ToDouble(reader["milesOfTrail"]);
            NewPark.NumberOfCampsites = Convert.ToInt16(reader["numberOfCampsites"]);
            NewPark.Climate = Convert.ToString(reader["climate"]);
            NewPark.YearFounded = Convert.ToString(reader["yearFounded"]);
            NewPark.AnnualVisitorCount = Convert.ToInt64(reader["annualVisitorCount"]);
            NewPark.InspirationalQuoute = Convert.ToString(reader["inspirationalQuote"]);
            NewPark.InspirationalQuoteSource = Convert.ToString(reader["inspirationalQuoteSource"]);
            NewPark.ParkDescription = Convert.ToString(reader["parkDescription"]);
            NewPark.EntryFee = Convert.ToString(reader["entryFee"]);
            NewPark.NumberOfAnimalSpecies = Convert.ToInt16(reader["numberOfAnimalSpecies"]);

            return NewPark;
        }
    }
}

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
                using(SqlConnection conn = new SqlConnection("Server=127.0.0.1; Port=5432; Database=natParkGeeks; User Id=postgres; Password=postgres1"))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM park", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        
                    }
                }
            }
            catch(SqlException ex)
            {
                throw;
            }

            return ParkList;
        }

        public ParkDAL()
        {
        }

        private Park MapRowToPark(SqlDataReader reader)
        {
            Park NewPark = new Park;
            NewPark.ParkCode = Convert.ToSingle(reader["parkCode"]);
            
            return NewPark;
        }
    }
}

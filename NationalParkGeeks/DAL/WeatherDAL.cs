using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NationalParkGeeks.Models;
using System.Data.SqlClient;

namespace NationalParkGeeks.DAL
{
    public class WeatherDAL
    {
        public List<Weather> GetWeatherByParkCode(string ParkCode)
        {
            List<Weather> ParkWeather = new List<Weather>();

            try
            {
                using (SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS;Database=NationalParkGeeks;Trusted_Connection=True;"))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM weather WHERE parkcode=(@bar)", conn);
                    cmd.Parameters.AddWithValue("@bar", ParkCode);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ParkWeather.Add(MapRowToWeather(reader));
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return ParkWeather;
        }

        private Weather MapRowToWeather(SqlDataReader reader)
        {
            Weather NewWeather = new Weather();
            NewWeather.FiveDayForecastValue = Convert.ToInt16(reader["fiveDayForecastValue"]);
            NewWeather.Forecast = Convert.ToString(reader["forecast"]);
            NewWeather.High = Convert.ToInt16(reader["high"]);
            NewWeather.Low = Convert.ToInt16(reader["low"]);
            return NewWeather;
        }
    }
}

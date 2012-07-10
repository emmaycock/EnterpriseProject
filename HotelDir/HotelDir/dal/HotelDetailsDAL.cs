using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotelDir.Models;
using System.Configuration;

//Class for handling Data Access Layer
namespace HotelDir.dal
{
    public class HotelDetailsDAL
    {
        //Access the DB
        protected HotelDetailsDb db = new HotelDetailsDb();

        public HotelDetailsDAL()
        {
            ConnectionStringSettingsCollection connections = ConfigurationManager.ConnectionStrings;
            if (connections.Count != 0)
            {
                Console.WriteLine();
                System.Diagnostics.Debug.WriteLine("Using ConnectionStrings property.");


                //get the collection elements.
                foreach (ConnectionStringSettings connection in
                    connections)
                {
                    string name = connection.Name;
                    string provider = connection.ProviderName;
                    string connectionString = connection.ConnectionString;

                    System.Diagnostics.Debug.WriteLine("Name:                {0}",
                        name);
                    System.Diagnostics.Debug.WriteLine(" Connection string:  {0}",
                        connectionString);
                    System.Diagnostics.Debug.WriteLine("Provider:           {0}",
                       provider);

                }
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("No connection string is defined.");
            }
        }

        //Method defined in logic layer is called here in the DAL
        public ExchangeRate findExchangeRateForConversion(String from, String to)
        {
            List<ExchangeRate> rates = null;
            rates = db.exchangeRates.ToList();

            foreach (ExchangeRate r in rates)
            {
                if (r.toCurrency.Equals(to) && r.fromCurrency.Equals(from))
                {
                    return r;
                }

            }

            return null;

        }
        public HotelDetails findHotelDetailsById(int id)
        {
            return null;
        }

        public HotelDetails addHotelDetails(HotelDetails hotel)
        {
            return null;
        }

    }
}
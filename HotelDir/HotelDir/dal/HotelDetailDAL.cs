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
      //  protected HotelDetailsDb db = new HotelDetailsDb();

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
        /*
        public HotelDetails <Method>(param1, param2)
        {
           return null;

        }
         */

        public HotelDetail findHotelDetailsById(int id)
        {
            return null;
        }

        public HotelDetail addHotelDetails(HotelDetail hotel)
        {
            return null;
        }

    }
}
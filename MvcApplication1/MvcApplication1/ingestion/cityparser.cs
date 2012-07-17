using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LumenWorks.Framework.IO.Csv;
using System.IO;
using MvcApplication1.Models;

namespace MvcApplication1.ingestion
{
    public class cityparser : IDataParser
    {

        private String supportedFormat = "csv";
        private StreamReader reader;

        

           // bring in results data 

        List<City> IDataParser.parseSearchHotel()
        {
            List<City> lst = new List<City>();
            CsvReader csv = new CsvReader(reader, true);
            int fieldCount = csv.FieldCount; 
            
            String[] headers = csv.GetFieldHeaders();

            while (csv.ReadNextRecord())
            {

                City exObj = new City();

                for (int i = 0; i < fieldCount; i++)
                {
                    if (headers[i].Equals("ID"))
                    {
                    }
                    else if (headers[i].Equals("COUNTRY"))
                    {
                        exObj.country = csv[i];
                    }
                    else if (headers[i].Equals("REGION"))
                    {
                        exObj.region = csv[i];
                    }
                    else if (headers[i].Equals("CITY"))
                    {
                        exObj.city = csv[i];
                    }
                    else if (headers[i].Equals("HOTEL_COUNT"))
                    {
                        exObj.hotel_count = csv[i];
                    }
                    else if (headers[i].Equals("CITYID"))
                    {
                        exObj.cityid = csv[i];
                    }
                    else if (headers[i].Equals("URL"))
                    {
                        exObj.url = csv[i];
                    }
                  
              
                }

                lst.Add(exObj);
            }
            return lst;
        }


        void IDataParser.setStreamSource(StreamReader reader)
        {
            this.reader = reader;
        }

        bool IDataParser.supportsType(string format)
        {
            // to cater for the null test
            if (format == null)
            {
                return false;
            }

            if (format.Equals(supportedFormat))
            {
                return true;
            }
            return false;

        }
  
    }
}
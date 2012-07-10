using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LumenWorks.Framework.IO.Csv;
using System.IO;
using HotelDir.Models;


namespace HotelDir.ingestion
{
    public class londoncsvparser
    {
        private String supportedFormat = "csv";
        private StreamReader reader;

        List<Models.HotelDetail> IDataParser.parseHotelDetails()
        {
            CsvReader csv = new CsvReader(reader, true);
            int fieldCount = csv.FieldCount;
            List<HotelDetail> hotels = new List<HotelDetail>();

            String[] headers = csv.GetFieldHeaders();

            while (csv.ReadNextRecord())
            {
                //This is where the models come into effect

                HotelDetail thisObj = new HotelDetail();

                //This loop reflects contents of the model. Header captions match actual text in csv file
                for (int i = 0; i < fieldCount; i++)
                {
                    if (headers[i].Equals("doc_id"))
                    {
                        thisObj.docID = csv[i];
                    }
                    else if (headers[i].Equals("hotel_name"))
                    {
                        thisObj.hotelName = csv[i];
                    }
                    else if (headers[i].Equals("hotel_url"))
                    {
                        thisObj.hotelUrl = csv[i];
                    }
                    else if (headers[i].Equals("street"))
                    {
                        thisObj.street = csv[i];
                    }
                    else if (headers[i].Equals("city"))
                    {
                        thisObj.city = csv[i];
                    }
                    else if (headers[i].Equals("state"))
                    {
                        thisObj.state = csv[i];
                    }
                    else if (headers[i].Equals("country"))
                    {
                        thisObj.country = csv[i];
                    }
                    else if (headers[i].Equals("zip"))
                    {
                        thisObj.zip = csv[i];
                    }
                    else if (headers[i].Equals("class"))
                    {
                        thisObj.classRating = csv[i];
                    }
                    else if (headers[i].Equals("price"))
                    {
                        thisObj.price = csv[i];
                    }
                    else if (headers[i].Equals("num_reviews"))
                    {
                        thisObj.numReviews = csv[i];
                    }
                    else if (headers[i].Equals("CLEANLINESS"))
                    {
                        thisObj.cleanliness = csv[i];
                    }
                    else if (headers[i].Equals("ROOM"))
                    {
                        thisObj.room = csv[i];
                    }
                    else if (headers[i].Equals("SERVICE"))
                    {
                        thisObj.service = csv[i];
                    }
                    else if (headers[i].Equals("LOCATION"))
                    {
                        thisObj.location = csv[i];
                    }
                    else if (headers[i].Equals("VALUE"))
                    {
                        thisObj.value = csv[i];
                    }
                    else if (headers[i].Equals("COMFORT"))
                    {
                        thisObj.comfort = csv[i];
                    }
                    else if (headers[i].Equals("overall_ratingsource"))
                    {
                        thisObj.overallRating = csv[i];
                    }
                }
                //Every time around, add a new object
                hotels.Add(thisObj);
            }
            return hotels;
        }

        void IDataParser.setStreamSource(StreamReader reader)
        {
            this.reader = reader;
        }

        public bool supportsType(string format)
        {
            //'throw' line removed as exception was being called as soon as this method was called
            if (format.Equals(supportedFormat))
            {
                return true;
            }
            return false;
        }
    }
}
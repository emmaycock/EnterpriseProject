using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcApplication1.Models;
using System.IO;

namespace MvcApplication1.ingestion
{
    public interface IDataParser
    {
        List<HotelDetail> parseHotelDetails();
       // List<City> parseCity();
       // List<Room> parseRoom();
       // List<SearchHotel> parseSearchHotel();
       // List<SingleHotel> parseSingleHotel();
       // List<WorldHotelDetail> parseWorldHotelDetail();




        // streamreader will be defined in the business logic
        void setStreamSource(StreamReader reader);
        Boolean supportsType(String format);
    }
}




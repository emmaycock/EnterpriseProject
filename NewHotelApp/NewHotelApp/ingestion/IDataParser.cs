using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewHotelApp.Models;
using System.IO;

namespace NewHotelApp.ingestion
{
    interface IDataParser
    {
        List<HotelDetail> parseHotelDetails();
        void setStreamSource(StreamReader reader);
        Boolean supportsType(String format);
    }
}




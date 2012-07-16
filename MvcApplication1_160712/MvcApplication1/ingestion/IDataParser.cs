using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcApplication1.Models;
using System.IO;

namespace MvcApplication1.ingestion
{
    interface IDataParser
    {
        List<HotelDetail> parseHotelDetails();
        void setStreamSource(StreamReader reader);
        Boolean supportsType(String format);
    }
}




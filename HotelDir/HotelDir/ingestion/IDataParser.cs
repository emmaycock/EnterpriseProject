using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelDir.Models;
using System.IO;

namespace HotelDir.ingestion
{
    interface IDataParser
    {
        List<HotelDetails> parseHotelDetails();
        void setStreamSource(StreamReader reader);
        Boolean supportsType(String format);
    }
}

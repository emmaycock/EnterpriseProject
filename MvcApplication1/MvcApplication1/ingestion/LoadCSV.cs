using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using MvcApplication1.Models;
using System.Reflection;
using MvcApplication1.ingestion;


namespace MvcApplication1
{
    public class InitialiseCSV
    {
        public IDataParser csvparse = new londoncsvparser();
        string csvpath =("C:\\Users\\-\\Desktop\\MvcApplication1\\Data\\HotelCSVData.csv");

        public List<HotelDetail> importHotelCSVData()
        {
            List<HotelDetail> hoteldetails = new List<HotelDetail>();
            StreamReader reader = new StreamReader(csvpath, true);
            csvparse.setStreamSource(reader);
            hoteldetails = csvparse.parseHotelDetails();
            return hoteldetails;
        }

       

    }
}
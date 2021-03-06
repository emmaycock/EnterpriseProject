﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication1.Models;
using System.Configuration;
using MvcApplication1.ingestion;

//Class for handling Data Access Layer

namespace MvcApplication1.dal
{
    public class HotelDetailDAL
    {
        NewHotelDb db = new NewHotelDb();
        public HotelDetailDAL()
        {
            InitialiseCSV csv = new InitialiseCSV();
            List<HotelDetail> data = csv.importHotelCSVData();
            foreach(HotelDetail d in data){
                db.HotelDetails.Add(d);
            }
            db.SaveChanges();

        }

    }

    
}
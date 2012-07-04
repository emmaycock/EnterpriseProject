using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HotelDir.Models;


namespace HotelDir.Models
{
    public class HotelDetailsDB : DbContext
    {
   
        public DbSet<HotelDetails> hoteldetails { get; set; }
    }
}


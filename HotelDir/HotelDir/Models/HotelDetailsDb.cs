using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HotelDir.Models.ui;

//Database connectivity class
namespace HotelDir.Models
{
    //DbContext enabled once EntityFramework package installed via Package Mgr Console
    public class HotelDetailsDb : DbContext
    {
        public DbSet<HotelDetails> hotelDetails { get; set; }

        public DbSet<HotelUI> HotelUIs { get; set; }
    }
}
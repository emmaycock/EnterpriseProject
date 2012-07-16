using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcApplication1.Models;


namespace MvcApplication1.Models
{
    public class HotelModDB : DbContext
    {
        public DbSet<HotelDetail> HotelDetails { get; set; }

        public HotelModDB()
        {
            if (!(this.Database.Exists()))
            {    // Create a default SQL Express DB
                this.Database.Create();
            }
        }
    }
}
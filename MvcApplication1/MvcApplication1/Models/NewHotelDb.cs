using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcApplication1.Models;

namespace MvcApplication1.Models
{
    public class NewHotelDb : DbContext
    {
        public DbSet<HotelDetail> HotelDetails { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<SearchHotel> SearchHotels { get; set; }
        public DbSet<SingleHotel> SingleHotels { get; set; }
        public DbSet<WorldHotelDetail> WorldHotelDetails { get; set; }
        public DbSet<City> Cities { get; set; }

        public NewHotelDb()
        {
            if (!(this.Database.Exists()))
            {  //Create a default SQl express DB
                this.Database.Create();
            }
        }
    
    }
}
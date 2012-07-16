using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NewHotelApp.Models.ui;

namespace NewHotelApp.Models
{
    public class HotelDb : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<HotelDetail> HotelDetails { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<SearchHotel> SearchHotels { get; set; }
        public DbSet<SingleHotel> SingleHotels { get; set; }
        public DbSet<WorldHotelDetail> WorldHotelDetails { get; set; }

    }
}
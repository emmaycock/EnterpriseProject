using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HotelDir.Models.ui;

namespace HotelDir.Models
{
    namespace HotelDir.Models
    {
        public class HotelDetailsDb : DbContext
        {
            public DbSet<HotelDetail> hotelDetails { get; set; }

            public DbSet<HotelUI> HotelUIs { get; set; }
        }
    }
}
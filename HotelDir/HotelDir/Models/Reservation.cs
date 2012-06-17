using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace ModelHotel
{
    [Table(Name = "Reservation")]
    public class Reservation
    {
        [Column(IsPrimaryKey = true, Storage = "_reservationnumberID")]
        public int reservationnumberID { get; set; }

        public int hotelid { get; set; }
        public int roomnumberID { get; set; }
        public String username { get; set; }
        public int checkin { get; set; }
        public int checkout { get; set; }
        public int resvdate { get; set; }
        public int roomprice { get; set; }
    }
}
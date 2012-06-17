using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace ModelHotel
{
    [Table(Name = "Reservation")]
    class Reservation
    {
        [Column(IsPrimaryKey = true, Storage = "_reservationnumberID")]
        public int reservationnumberID;

        int hotelid;
        int roomnumberID;
        int username;
        int checkin;
        int checkout;
        int resvdate;
        int roomprice;
    }
}
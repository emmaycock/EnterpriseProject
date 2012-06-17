using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace ModelHotel
{
   [Table(Name = "Room")]
   class Room
    {
       [Column(IsPrimaryKey = true, Storage = "_roomnumberID")]
       public int roomnumberID;
       
       int hotelid;
       int doornumber;
       int price;
       String type;
       
    }
}
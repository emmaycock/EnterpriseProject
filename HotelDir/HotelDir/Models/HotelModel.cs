using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;


namespace ModelHotel
{
    [Table (Name = "Hotel")]
    class HotelModel
    {
    [Column (IsPrimaryKey = true, Storage = "_hotelID")]
        public int hotelid;
       
        String HotelName;
        String Street;
        String City;
        String State;
        int Zip;
        int Phone;
         }
}





    
     
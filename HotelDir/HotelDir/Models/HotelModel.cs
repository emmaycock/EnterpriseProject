using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;


namespace ModelHotel
{
    [Table (Name = "Hotel")]
    public class HotelModel
    {
    [Column (IsPrimaryKey = true, Storage = "_hotelID")]
        public int hotelid;

    public String HotelName { get; set; }
    public String Street { get; set; }
    public String City { get; set; }
    public String State { get; set; }
    public int Zip { get; set; }
    public int Phone { get; set; }
        }
}





    
     
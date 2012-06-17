using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace ModelHotel
{
    [Table(Name = "Guest")]
    class Guest
    {
        String LastName;
        String FirstName;
        String Street;
        String City;
        String State;
        int Zip;
        String username;
        int reservationnumber;
    }
}
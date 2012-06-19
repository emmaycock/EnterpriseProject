using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace ModelHotel
{
    [Table(Name = "Guest")]
    public class Guest
    {
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public String Street { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public int Zip { get; set; }
        public String username { get; set; }
        public int reservationnumber { get; set; }
    }
}
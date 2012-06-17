using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace ModelHotel
{
    [Table(Name = "Admin")]
    class Admin
    {
        [Column(IsPrimaryKey = true, Storage = "_adminID")]
        public int adminID;
        
        String username;
        int passcode;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models.ui
{
    public class HotelUI
    {
        public int id { get; set; }
        public string hotelName { get; set; }
        public string hotelUrl { get; set; }
        public string street { get; set; }
    }
}


/* this is a model that deals with the views towards the user as opposed to the models that deal with the database */
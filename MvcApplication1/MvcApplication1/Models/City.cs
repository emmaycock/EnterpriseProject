using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace MvcApplication1.Models
{
    //Column names based on data in London csv file in Data folder of project
    [Table(Name = "CITY")]
    public class City
    {
        [Column(IsPrimaryKey = true)]
        public int ID { get; set; }
        [Column(Name = "COUNTRY")]
        public String country { get; set; }
        [Column(Name = "REGION")]
        public String region { get; set; }
        [Column(Name = "CITY")]
        public String city { get; set; }
        [Column(Name = "HOTEL_COUNT")]
        public String hotel_count { get; set; }
        [Column(Name = "CITYID")]
        public String cityid { get; set; }
        [Column(Name = "URL")]
        public String url { get; set; }
    }
}
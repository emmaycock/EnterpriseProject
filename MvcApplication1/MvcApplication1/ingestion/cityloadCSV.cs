using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication1.Models;
using System.IO;

namespace MvcApplication1.ingestion
{
    public class cityloadCSV
    {
        public IDataParser all_data = new cityparser();

        // city parser ingestion folder

        public List<City> loadCity()
        {
            List<City> lst = new List<City>();
            StreamReader reader = new StreamReader("C:\\EnterpriseProject\\EnterpriseProject\\Data\\citytesthotels", true);
            all_data.setStreamSource(reader);
            lst = all_data.parseCity();
            return lst;

        }

    }
}
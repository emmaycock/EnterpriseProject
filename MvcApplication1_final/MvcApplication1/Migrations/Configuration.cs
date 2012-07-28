namespace MvcApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MvcApplication1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration</* TODO: put your Code First context type name here */NewHotelDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }



    }
}

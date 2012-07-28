using System.Data.Entity.Migrations;
namespace MvcApplication1.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTODecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("HotelDetails", "numReviews", c => c.Int(nullable: false));
            AlterColumn("HotelDetails", "cleanliness", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("HotelDetails", "room", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("HotelDetails", "service", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("HotelDetails", "location", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("HotelDetails", "value", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("HotelDetails", "overallRating", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            // DropColumn("HotelDetails", "classRating");
            //DropColumn("HotelDetails", "price");
            //DropColumn("HotelDetails", "comfort");
        }
        
        public override void Down()
        {
            AddColumn("HotelDetails", "comfort", c => c.String());
            AddColumn("HotelDetails", "price", c => c.String());
            AddColumn("HotelDetails", "classRating", c => c.String());
            AlterColumn("HotelDetails", "overallRating", c => c.String());
            AlterColumn("HotelDetails", "value", c => c.String());
            AlterColumn("HotelDetails", "location", c => c.String());
            AlterColumn("HotelDetails", "service", c => c.String());
            AlterColumn("HotelDetails", "room", c => c.String());
            AlterColumn("HotelDetails", "cleanliness", c => c.String());
            AlterColumn("HotelDetails", "numReviews", c => c.String());
        }
    }
}

namespace NSMPublisherForConsumer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablecreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Publishers");
        }
    }
}

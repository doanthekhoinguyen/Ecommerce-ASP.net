namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mixtapetable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mixtapes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Color = c.Int(nullable: false),
                        LabelStyle = c.Int(nullable: false),
                        LinkA = c.String(),
                        LinkB = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Mixtapes");
        }
    }
}

namespace LTQL_1721050355.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hehehee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhaCungCap355",
                c => new
                    {
                        Manhacungcap = c.Int(nullable: false, identity: true),
                        Tennhacungcap = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Manhacungcap);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhaCungCap355");
        }
    }
}

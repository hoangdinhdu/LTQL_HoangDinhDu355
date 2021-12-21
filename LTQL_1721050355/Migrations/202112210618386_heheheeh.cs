namespace LTQL_1721050355.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class heheheeh : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HDDSanPham355",
                c => new
                    {
                        Masanpham = c.String(nullable: false, maxLength: 20),
                        TenSanPham = c.String(maxLength: 50),
                        Manhacungcap = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Masanpham)
                .ForeignKey("dbo.NhaCungCap355", t => t.Manhacungcap, cascadeDelete: true)
                .Index(t => t.Manhacungcap);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HDDSanPham355", "Manhacungcap", "dbo.NhaCungCap355");
            DropIndex("dbo.HDDSanPham355", new[] { "Manhacungcap" });
            DropTable("dbo.HDDSanPham355");
        }
    }
}

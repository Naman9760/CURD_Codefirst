namespace CURD_Codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catagries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Pid = c.Int(nullable: false, identity: true),
                        Pname = c.String(),
                        Descri = c.String(),
                        Contity = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        catagrie_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Pid)
                .ForeignKey("dbo.Catagries", t => t.catagrie_Id)
                .Index(t => t.catagrie_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "catagrie_Id", "dbo.Catagries");
            DropIndex("dbo.Products", new[] { "catagrie_Id" });
            DropTable("dbo.Products");
            DropTable("dbo.Catagries");
        }
    }
}

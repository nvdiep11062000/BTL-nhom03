namespace BTL_Nhom3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Sanpham : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SanPhams",
                c => new
                    {
                        IDSanPham = c.String(nullable: false, maxLength: 128),
                        TenSanPham = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.IDSanPham);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SanPhams");
        }
    }
}

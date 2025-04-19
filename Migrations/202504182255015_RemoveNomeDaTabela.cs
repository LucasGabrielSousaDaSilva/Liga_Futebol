namespace Liga_Futebol.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveNomeDaTabela : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Times", "LigaId", "dbo.Ligas");
            DropIndex("dbo.Times", new[] { "LigaId" });
            RenameColumn(table: "dbo.Times", name: "LigaId", newName: "Liga_Id");
            AlterColumn("dbo.Times", "Liga_Id", c => c.Int());
            CreateIndex("dbo.Times", "Liga_Id");
            AddForeignKey("dbo.Times", "Liga_Id", "dbo.Ligas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Times", "Liga_Id", "dbo.Ligas");
            DropIndex("dbo.Times", new[] { "Liga_Id" });
            AlterColumn("dbo.Times", "Liga_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Times", name: "Liga_Id", newName: "LigaId");
            CreateIndex("dbo.Times", "LigaId");
            AddForeignKey("dbo.Times", "LigaId", "dbo.Ligas", "Id", cascadeDelete: true);
        }
    }
}

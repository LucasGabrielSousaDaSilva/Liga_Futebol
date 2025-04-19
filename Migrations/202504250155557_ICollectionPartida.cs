namespace Liga_Futebol.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ICollectionPartida : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Partidas", "EstatisticaPartida_Id", "dbo.EstatisticasPartidas");
            DropIndex("dbo.Partidas", new[] { "EstatisticaPartida_Id" });
            CreateTable(
                "dbo.PartidaEstatisticaPartida",
                c => new
                    {
                        Partida_Id = c.Int(nullable: false),
                        EstatisticaPartida_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Partida_Id, t.EstatisticaPartida_Id })
                .ForeignKey("dbo.Partidas", t => t.Partida_Id, cascadeDelete: true)
                .ForeignKey("dbo.EstatisticasPartidas", t => t.EstatisticaPartida_Id, cascadeDelete: true)
                .Index(t => t.Partida_Id)
                .Index(t => t.EstatisticaPartida_Id);
            
            DropColumn("dbo.Partidas", "EstatisticaPartida_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Partidas", "EstatisticaPartida_Id", c => c.Int());
            DropForeignKey("dbo.PartidaEstatisticaPartida", "EstatisticaPartida_Id", "dbo.EstatisticasPartidas");
            DropForeignKey("dbo.PartidaEstatisticaPartida", "Partida_Id", "dbo.Partidas");
            DropIndex("dbo.PartidaEstatisticaPartida", new[] { "EstatisticaPartida_Id" });
            DropIndex("dbo.PartidaEstatisticaPartida", new[] { "Partida_Id" });
            DropTable("dbo.PartidaEstatisticaPartida");
            CreateIndex("dbo.Partidas", "EstatisticaPartida_Id");
            AddForeignKey("dbo.Partidas", "EstatisticaPartida_Id", "dbo.EstatisticasPartidas", "Id");
        }
    }
}

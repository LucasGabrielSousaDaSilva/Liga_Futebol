namespace Liga_Futebol.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ICollection : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Times", "Jogador_Id", c => c.Int());
            AddColumn("dbo.Times", "Partida_Id", c => c.Int());
            AddColumn("dbo.Times", "EstatisticaPartida_Id", c => c.Int());
            AddColumn("dbo.Times", "ComissaoTecnica_Id", c => c.Int());
            AddColumn("dbo.Jogadores", "EstatisticaPartida_Id", c => c.Int());
            AddColumn("dbo.Partidas", "EstatisticaPartida_Id", c => c.Int());
            CreateIndex("dbo.Times", "Jogador_Id");
            CreateIndex("dbo.Times", "Partida_Id");
            CreateIndex("dbo.Times", "EstatisticaPartida_Id");
            CreateIndex("dbo.Times", "ComissaoTecnica_Id");
            CreateIndex("dbo.Jogadores", "EstatisticaPartida_Id");
            CreateIndex("dbo.Partidas", "EstatisticaPartida_Id");
            AddForeignKey("dbo.Times", "Jogador_Id", "dbo.Jogadores", "Id");
            AddForeignKey("dbo.Jogadores", "EstatisticaPartida_Id", "dbo.EstatisticasPartidas", "Id");
            AddForeignKey("dbo.Times", "Partida_Id", "dbo.Partidas", "Id");
            AddForeignKey("dbo.Partidas", "EstatisticaPartida_Id", "dbo.EstatisticasPartidas", "Id");
            AddForeignKey("dbo.Times", "EstatisticaPartida_Id", "dbo.EstatisticasPartidas", "Id");
            AddForeignKey("dbo.Times", "ComissaoTecnica_Id", "dbo.ComissoesTecnicas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Times", "ComissaoTecnica_Id", "dbo.ComissoesTecnicas");
            DropForeignKey("dbo.Times", "EstatisticaPartida_Id", "dbo.EstatisticasPartidas");
            DropForeignKey("dbo.Partidas", "EstatisticaPartida_Id", "dbo.EstatisticasPartidas");
            DropForeignKey("dbo.Times", "Partida_Id", "dbo.Partidas");
            DropForeignKey("dbo.Jogadores", "EstatisticaPartida_Id", "dbo.EstatisticasPartidas");
            DropForeignKey("dbo.Times", "Jogador_Id", "dbo.Jogadores");
            DropIndex("dbo.Partidas", new[] { "EstatisticaPartida_Id" });
            DropIndex("dbo.Jogadores", new[] { "EstatisticaPartida_Id" });
            DropIndex("dbo.Times", new[] { "ComissaoTecnica_Id" });
            DropIndex("dbo.Times", new[] { "EstatisticaPartida_Id" });
            DropIndex("dbo.Times", new[] { "Partida_Id" });
            DropIndex("dbo.Times", new[] { "Jogador_Id" });
            DropColumn("dbo.Partidas", "EstatisticaPartida_Id");
            DropColumn("dbo.Jogadores", "EstatisticaPartida_Id");
            DropColumn("dbo.Times", "ComissaoTecnica_Id");
            DropColumn("dbo.Times", "EstatisticaPartida_Id");
            DropColumn("dbo.Times", "Partida_Id");
            DropColumn("dbo.Times", "Jogador_Id");
        }
    }
}

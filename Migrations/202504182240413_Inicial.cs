namespace Liga_Futebol.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ComissoesTecnicas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        Cargo = c.Int(nullable: false),
                        TimeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Times", t => t.TimeId)
                .Index(t => t.TimeId);
            
            CreateTable(
                "dbo.Times",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Status = c.Boolean(nullable: false),
                        CorUniformesPrimaria = c.String(),
                        CorUniformesSecundaria = c.String(),
                        DataFundacao = c.Int(nullable: false),
                        Cidade = c.String(),
                        Estado = c.String(),
                        EstadioTime = c.String(),
                        CapacidadeEstagio = c.Int(nullable: false),
                        LigaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ligas", t => t.LigaId, cascadeDelete: true)
                .Index(t => t.LigaId);
            
            CreateTable(
                "dbo.EstatisticasPartidas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PartidaId = c.Int(nullable: false),
                        JogadorId = c.Int(nullable: false),
                        TimeId = c.Int(nullable: false),
                        GolsMarcados = c.Int(nullable: false),
                        GolsSofridos = c.Int(nullable: false),
                        Asistencias = c.Int(nullable: false),
                        CartoesAmarelos = c.Int(nullable: false),
                        CartoesVermelhos = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jogadores", t => t.JogadorId)
                .ForeignKey("dbo.Partidas", t => t.PartidaId)
                .ForeignKey("dbo.Times", t => t.TimeId)
                .Index(t => t.PartidaId)
                .Index(t => t.JogadorId)
                .Index(t => t.TimeId);
            
            CreateTable(
                "dbo.Jogadores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        Nacionalidade = c.String(),
                        Posicao = c.Int(nullable: false),
                        NumCamisa = c.Int(nullable: false),
                        Altura = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Peso = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PePreferido = c.Int(nullable: false),
                        TimeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Times", t => t.TimeId)
                .Index(t => t.TimeId);
            
            CreateTable(
                "dbo.Partidas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        TimeCasaId = c.Int(nullable: false),
                        TimeForaId = c.Int(nullable: false),
                        GolsTimeCasa = c.Int(nullable: false),
                        GolsTimeFora = c.Int(nullable: false),
                        Local = c.String(),
                        Resultado = c.Int(nullable: false),
                        Rodada = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Times", t => t.TimeCasaId)
                .ForeignKey("dbo.Times", t => t.TimeForaId)
                .Index(t => t.TimeCasaId)
                .Index(t => t.TimeForaId);
            
            CreateTable(
                "dbo.Ligas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        DataInicio = c.DateTime(nullable: false),
                        DataFim = c.DateTime(nullable: false),
                        Localizacao = c.String(),
                        NumeroTimes = c.Int(nullable: false),
                        Rodadas = c.Int(nullable: false),
                        PartidasPorRodada = c.Int(nullable: false),
                        TipoCompeticao = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ComissoesTecnicas", "TimeId", "dbo.Times");
            DropForeignKey("dbo.Times", "LigaId", "dbo.Ligas");
            DropForeignKey("dbo.EstatisticasPartidas", "TimeId", "dbo.Times");
            DropForeignKey("dbo.EstatisticasPartidas", "PartidaId", "dbo.Partidas");
            DropForeignKey("dbo.Partidas", "TimeForaId", "dbo.Times");
            DropForeignKey("dbo.Partidas", "TimeCasaId", "dbo.Times");
            DropForeignKey("dbo.EstatisticasPartidas", "JogadorId", "dbo.Jogadores");
            DropForeignKey("dbo.Jogadores", "TimeId", "dbo.Times");
            DropIndex("dbo.Partidas", new[] { "TimeForaId" });
            DropIndex("dbo.Partidas", new[] { "TimeCasaId" });
            DropIndex("dbo.Jogadores", new[] { "TimeId" });
            DropIndex("dbo.EstatisticasPartidas", new[] { "TimeId" });
            DropIndex("dbo.EstatisticasPartidas", new[] { "JogadorId" });
            DropIndex("dbo.EstatisticasPartidas", new[] { "PartidaId" });
            DropIndex("dbo.Times", new[] { "LigaId" });
            DropIndex("dbo.ComissoesTecnicas", new[] { "TimeId" });
            DropTable("dbo.Ligas");
            DropTable("dbo.Partidas");
            DropTable("dbo.Jogadores");
            DropTable("dbo.EstatisticasPartidas");
            DropTable("dbo.Times");
            DropTable("dbo.ComissoesTecnicas");
        }
    }
}

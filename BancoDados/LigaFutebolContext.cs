using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Liga_Futebol.Models;
using System.Linq;
using System.Web;

namespace Liga_Futebol.BancoDados
{
    public class LigaFutebolContext : DbContext
    {

        public LigaFutebolContext() : base("LigaFutebolDB")
        {
            
        }
        public DbSet<Liga_Futebol.Models.Liga> Ligas { get; set; }
        public DbSet<Liga_Futebol.Models.Time> Times { get; set; }
        public DbSet<Liga_Futebol.Models.Jogador> Jogadores { get; set; }
        public DbSet<Liga_Futebol.Models.ComissaoTecnica> ComissoesTecnicas { get; set; }
        public DbSet<Liga_Futebol.Models.Partida> Partidas { get; set; }
        public DbSet<Liga_Futebol.Models.EstatisticaPartida> EstatisticasPartidas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // Configurações adicionais do modelo, se necessário
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Configurações de tabela
            modelBuilder.Entity<Models.Liga>().ToTable("Ligas");
            modelBuilder.Entity<Models.Time>().ToTable("Times");
            modelBuilder.Entity<Models.Jogador>().ToTable("Jogadores");
            modelBuilder.Entity<Models.ComissaoTecnica>().ToTable("ComissoesTecnicas");
            modelBuilder.Entity<Models.Partida>().ToTable("Partidas");
            modelBuilder.Entity<Models.EstatisticaPartida>().ToTable("EstatisticasPartidas");

            // Configuração para evitar cascatas na relação Jogador -> EstatisticaPartida
            modelBuilder.Entity<EstatisticaPartida>()
                .HasRequired(e => e.Jogador)
                .WithMany(j => j.Estatisticas)
                .HasForeignKey(e => e.JogadorId)
                .WillCascadeOnDelete(false);

            // Configuração para evitar cascatas na relação Partida -> EstatisticaPartida
            modelBuilder.Entity<EstatisticaPartida>()
                .HasRequired(e => e.Partida)
                .WithMany(p => p.Estatisticas)
                .HasForeignKey(e => e.PartidaId)
                .WillCascadeOnDelete(false);

            // Configuração para evitar cascatas na relação Time -> EstatisticaPartida
            modelBuilder.Entity<EstatisticaPartida>()
                .HasRequired(e => e.Time)
                .WithMany(t => t.Estatisticas)
                .HasForeignKey(e => e.TimeId)
                .WillCascadeOnDelete(false);

            // Configuração para evitar cascatas na relação Time -> Jogador
            modelBuilder.Entity<Jogador>()
                .HasRequired(j => j.Time)
                .WithMany(t => t.Jogadores)
                .HasForeignKey(j => j.TimeId)
                .WillCascadeOnDelete(false);
            // Configuração para evitar cascatas na relação Time -> ComissaoTecnica
            modelBuilder.Entity<ComissaoTecnica>()
                .HasRequired(c => c.Time)
                .WithMany(t => t.ComissaoTecnica)
                .HasForeignKey(c => c.TimeId)
                .WillCascadeOnDelete(false);

            // Configuração para evitar cascatas na relação Time -> Partida
            modelBuilder.Entity<Partida>()
                .HasRequired(p => p.TimeCasa)
                .WithMany(t => t.PartidaCasa)
                .HasForeignKey(p => p.TimeCasaId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Partida>()
                .HasRequired(p => p.TimeFora)
                .WithMany(t => t.PartidaFora)
                .HasForeignKey(p => p.TimeForaId)
                .WillCascadeOnDelete(false);


            base.OnModelCreating(modelBuilder);

        }

    }
}
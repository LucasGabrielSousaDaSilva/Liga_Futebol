namespace Liga_Futebol.Migrations
{
    using Liga_Futebol.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Liga_Futebol.BancoDados.LigaFutebolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Liga_Futebol.BancoDados.LigaFutebolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            // Times
            var times = new List<Time>
            {
                new Time { Nome = "Flamengo 2019", Status = true, CorUniformesPrimaria = "Vermelho e Preto", CorUniformesSecundaria = "Branco", DataFundacao = 1895, Cidade = "Rio de Janeiro", Estado = "RJ", EstadioTime = "Maracanã" , CapacidadeEstagio = 78838},
                new Time { Nome = "Time B", Status = true, CorUniformesPrimaria = "Vermelho", CorUniformesSecundaria = "Preto", DataFundacao = 2000, Cidade = "Cidade B", Estado = "Estado B", EstadioTime = "Estádio B", CapacidadeEstagio = 60000 },

                new Time { Nome = "Santos 1962", Status = true, CorUniformesPrimaria = "Branco", CorUniformesSecundaria = "Preto", DataFundacao = 1912, Cidade = "Santos", Estado = "SP", EstadioTime = "Vila Belmiro", CapacidadeEstagio = 16800 },
                new Time { Nome = "Palmeiras 2020", Status = true, CorUniformesPrimaria = "Verde", CorUniformesSecundaria = "Branco", DataFundacao = 1914, Cidade = "São Paulo", Estado = "SP", EstadioTime = "Allianz Parque", CapacidadeEstagio = 43000 },
                new Time { Nome = "Corinthians 2012", Status = true, CorUniformesPrimaria = "Branco", CorUniformesSecundaria = "Preto", DataFundacao = 1910, Cidade = "São Paulo", Estado = "SP", EstadioTime = "Neo Química Arena", CapacidadeEstagio = 49205 },
                new Time { Nome = "São Paulo 2005", Status = true, CorUniformesPrimaria = "Branco", CorUniformesSecundaria = "Vermelho e Preto", DataFundacao = 1930, Cidade = "São Paulo", Estado = "SP", EstadioTime = "Morumbi", CapacidadeEstagio = 67000 },
                new Time { Nome = "Cruzeiro 2003", Status = true, CorUniformesPrimaria = "Azul", CorUniformesSecundaria = "Branco", DataFundacao = 1921, Cidade = "Belo Horizonte", Estado = "MG", EstadioTime = "Mineirão", CapacidadeEstagio = 62000 },
                new Time { Nome = "Atlético Mineiro 2013", Status = true, CorUniformesPrimaria = "Preto e Branco", CorUniformesSecundaria = "Branco", DataFundacao = 1908, Cidade = "Belo Horizonte", Estado = "MG", EstadioTime = "Arena MRV", CapacidadeEstagio = 47000 },
                new Time { Nome = "Grêmio 1995", Status = true, CorUniformesPrimaria = "Azul, Preto e Branco", CorUniformesSecundaria = "Branco", DataFundacao = 1903, Cidade = "Porto Alegre", Estado = "RS", EstadioTime = "Arena do Grêmio", CapacidadeEstagio = 55000 },
                new Time { Nome = "Internacional 2006", Status = true, CorUniformesPrimaria = "Vermelho", CorUniformesSecundaria = "Branco", DataFundacao = 1909, Cidade = "Porto Alegre", Estado = "RS", EstadioTime = "Beira-Rio", CapacidadeEstagio = 50000 },

                new Time { Nome = "Barcelona 2009", Status = true, CorUniformesPrimaria = "Grená e Azul", CorUniformesSecundaria = "Amarelo", DataFundacao = 1899, Cidade = "Barcelona", Estado = "Catalunha", EstadioTime = "Camp Nou", CapacidadeEstagio = 99354 },
                new Time { Nome = "Real Madrid 2017", Status = true, CorUniformesPrimaria = "Branco", CorUniformesSecundaria = "Roxo", DataFundacao = 1902, Cidade = "Madrid", Estado = "Madrid", EstadioTime = "Santiago Bernabéu", CapacidadeEstagio = 81044 },
                new Time { Nome = "Milan 1989", Status = true, CorUniformesPrimaria = "Vermelho e Preto", CorUniformesSecundaria = "Branco", DataFundacao = 1899, Cidade = "Milão", Estado = "Lombardia", EstadioTime = "San Siro", CapacidadeEstagio = 80018 },
                new Time { Nome = "Manchester United 1999", Status = true, CorUniformesPrimaria = "Vermelho", CorUniformesSecundaria = "Branco", DataFundacao = 1878, Cidade = "Manchester", Estado = "Inglaterra", EstadioTime = "Old Trafford", CapacidadeEstagio = 74310 },
                new Time { Nome = "Liverpool 2019", Status = true, CorUniformesPrimaria = "Vermelho", CorUniformesSecundaria = "Branco", DataFundacao = 1892, Cidade = "Liverpool", Estado = "Inglaterra", EstadioTime = "Anfield", CapacidadeEstagio = 54000 },
                new Time { Nome = "Bayern de Munique 2020", Status = true, CorUniformesPrimaria = "Vermelho", CorUniformesSecundaria = "Branco", DataFundacao = 1900, Cidade = "Munique", Estado = "Baviera", EstadioTime = "Allianz Arena", CapacidadeEstagio = 75000 },
                new Time { Nome = "Ajax 1971", Status = true, CorUniformesPrimaria = "Branco com faixa vermelha", CorUniformesSecundaria = "Azul", DataFundacao = 1900, Cidade = "Amsterdã", Estado = "Holanda", EstadioTime = "Johan Cruyff Arena", CapacidadeEstagio = 55000 },
                new Time { Nome = "Boca Juniors 2000", Status = true, CorUniformesPrimaria = "Azul e Amarelo", CorUniformesSecundaria = "Branco", DataFundacao = 1905, Cidade = "Buenos Aires", Estado = "Argentina", EstadioTime = "La Bombonera", CapacidadeEstagio = 49000 },
                new Time { Nome = "Peñarol 1960", Status = true, CorUniformesPrimaria = "Amarelo e Preto", CorUniformesSecundaria = "Branco", DataFundacao = 1891, Cidade = "Montevidéu", Estado = "Uruguai", EstadioTime = "Campeón del Siglo", CapacidadeEstagio = 40000 }
            };
            times.ForEach(t => context.Times.AddOrUpdate(p => p.Nome, t));
            context.SaveChanges();

            // Ligas
            var ligas = new List<Liga>
            {
                new Liga { Nome = "Liga A", Status = true, DataInicio = DateTime.Now, DataFim = DateTime.Now.AddMonths(6) }
            };
            ligas.ForEach(l => context.Ligas.AddOrUpdate(p => p.Nome, l));
            context.SaveChanges();

            // 1- Comissões Técnicas e Jogadores do Flamengo 2019
            var flamengo = context.Times.FirstOrDefault(t => t.Nome == "Flamengo 2019");
            if (flamengo != null)
            {
                var ComissoesTecnicas = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Jorge Jesus", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1954, 7, 24), TimeId = flamengo.Id },
                    new ComissaoTecnica { Nome = "João de Deus", Cargo = Cargo.Auxiliar, DataNascimento = new DateTime(1961, 3, 31), TimeId = flamengo.Id },
                    new ComissaoTecnica { Nome = "Mário Monteiro", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1974, 1, 5), TimeId = flamengo.Id },
                    new ComissaoTecnica { Nome = "Rodrigo Lasmar", Cargo = Cargo.Fisioterapeuta, DataNascimento = new DateTime(1974, 7, 17), TimeId = flamengo.Id },
                    new ComissaoTecnica { Nome = "Alexandre Schneider", Cargo = Cargo.TreinadorDeGoleiros, DataNascimento = new DateTime(1971, 8, 22), TimeId = flamengo.Id },
                    new ComissaoTecnica { Nome = "Rogério Corrêa", Cargo = Cargo.Fisioterapeuta, DataNascimento = new DateTime(1975, 9, 10), TimeId = flamengo.Id }
                };
                ComissoesTecnicas.ForEach(c => context.ComissoesTecnicas.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
                {
                     // Goleiros
                    new Jogador { Nome = "Diego Alves",           DataNascimento = new DateTime(1985, 6, 24), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,     NumCamisa = 1,  Altura = 1.88m, Peso = 83m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Gabriel Batista",       DataNascimento = new DateTime(1997, 7, 1),  Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,     NumCamisa = 22, Altura = 1.90m, Peso = 82m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "César",                 DataNascimento = new DateTime(1991, 11, 9), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,     NumCamisa = 37, Altura = 1.93m, Peso = 83m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Hugo Souza",            DataNascimento = new DateTime(2001, 3, 31), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,     NumCamisa = 45, Altura = 1.96m, Peso = 82m, PePreferido = PePreferido.Esquerdo,   TimeId = flamengo.Id },

                    // Defensores
                    new Jogador { Nome = "Rodinei",               DataNascimento = new DateTime(1992, 2, 29), Nacionalidade = "Brasil", Posicao = Posicao.Lateral,    NumCamisa = 2,  Altura = 1.75m, Peso = 75m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Rodrigo Caio",          DataNascimento = new DateTime(1993, 8, 17), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,   NumCamisa = 3,  Altura = 1.83m, Peso = 76m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Pablo Marí",            DataNascimento = new DateTime(1993, 8, 1),  Nacionalidade = "Espanha", Posicao = Posicao.Zagueiro,  NumCamisa = 4,  Altura = 1.89m, Peso = 83m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Renê",                  DataNascimento = new DateTime(1992, 2, 6),  Nacionalidade = "Brasil", Posicao = Posicao.Lateral,    NumCamisa = 6,  Altura = 1.69m, Peso = 68m, PePreferido = PePreferido.Esquerdo,   TimeId = flamengo.Id },
                    new Jogador { Nome = "Rafinha",               DataNascimento = new DateTime(1985, 9, 7),  Nacionalidade = "Brasil", Posicao = Posicao.Lateral,    NumCamisa = 13, Altura = 1.70m, Peso = 64m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Filipe Luís",           DataNascimento = new DateTime(1985, 8, 9),  Nacionalidade = "Brasil", Posicao = Posicao.Lateral,    NumCamisa = 16, Altura = 1.82m, Peso = 75m, PePreferido = PePreferido.Esquerdo,   TimeId = flamengo.Id },
                    new Jogador { Nome = "Matheus Thuler",        DataNascimento = new DateTime(1999, 2, 21), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,   NumCamisa = 26, Altura = 1.86m, Peso = 80m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "João Lucas",            DataNascimento = new DateTime(1991, 12, 30),Nacionalidade = "Brasil", Posicao = Posicao.Lateral,    NumCamisa = 32, Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Rhodolfo",              DataNascimento = new DateTime(1986, 2, 13), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,   NumCamisa = 44, Altura = 1.87m, Peso = 82m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Matheus Dantas",        DataNascimento = new DateTime(1998, 7, 15), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,   NumCamisa = 55, Altura = 1.85m, Peso = 78m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Rafael Santos",         DataNascimento = new DateTime(1998, 4, 21), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,   NumCamisa = 58, Altura = 1.82m, Peso = 76m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },

                    // Meio‑campistas
                    new Jogador { Nome = "Willian Arão",          DataNascimento = new DateTime(1992, 7, 24), Nacionalidade = "Brasil", Posicao = Posicao.Volante,   NumCamisa = 5,  Altura = 1.80m, Peso = 77m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Éverton Ribeiro",       DataNascimento = new DateTime(1989, 4, 10), Nacionalidade = "Brasil", Posicao = Posicao.Meia,      NumCamisa = 7,  Altura = 1.74m, Peso = 64m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Gerson",               DataNascimento = new DateTime(1997, 5, 20), Nacionalidade = "Brasil", Posicao = Posicao.Meia,       NumCamisa = 8,  Altura = 1.75m, Peso = 69m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Diego",                DataNascimento = new DateTime(1985, 2, 15), Nacionalidade = "Brasil", Posicao = Posicao.Meia,       NumCamisa = 10, Altura = 1.74m, Peso = 65m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Giorgian de Arrascaeta",DataNascimento = new DateTime(1994, 6, 1),  Nacionalidade = "Uruguai",Posicao = Posicao.Meia,      NumCamisa = 14, Altura = 1.75m, Peso = 71m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Vinícius Souza",        DataNascimento = new DateTime(2000, 4, 28), Nacionalidade = "Brasil", Posicao = Posicao.Volante,   NumCamisa = 15, Altura = 1.79m, Peso = 72m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Hugo Moura",           DataNascimento = new DateTime(1999, 6, 11), Nacionalidade = "Brasil", Posicao = Posicao.Volante,    NumCamisa = 17, Altura = 1.86m, Peso = 80m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Reinier",              DataNascimento = new DateTime(2002, 1, 19), Nacionalidade = "Brasil", Posicao = Posicao.Meia,       NumCamisa = 19, Altura = 1.76m, Peso = 68m, PePreferido = PePreferido.Esquerdo,   TimeId = flamengo.Id },
                    new Jogador { Nome = "Robert Piris Da Motta",DataNascimento = new DateTime(1994, 6, 3),  Nacionalidade = "Paraguai",Posicao = Posicao.Volante,   NumCamisa = 25, Altura = 1.83m, Peso = 78m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Pepê",                 DataNascimento = new DateTime(1998, 4, 15), Nacionalidade = "Brasil", Posicao = Posicao.Meia,       NumCamisa = 40, Altura = 1.79m, Peso = 75m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },

                    // Atacantes
                    new Jogador { Nome = "Gabriel Barbosa",      DataNascimento = new DateTime(1996, 8, 30), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,  NumCamisa = 9,  Altura = 1.78m, Peso = 73m, PePreferido = PePreferido.Esquerdo,   TimeId = flamengo.Id },
                    new Jogador { Nome = "Vitinho",              DataNascimento = new DateTime(1993, 10, 9), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,  NumCamisa = 11, Altura = 1.75m, Peso = 66m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Lucas Silva",          DataNascimento = new DateTime(1993, 1, 16), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,  NumCamisa = 23, Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Bruno Henrique",       DataNascimento = new DateTime(1990, 6, 30), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,  NumCamisa = 27, Altura = 1.74m, Peso = 82m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Orlando Berrío",       DataNascimento = new DateTime(1991, 12, 21),Nacionalidade = "Colômbia",Posicao = Posicao.Atacante, NumCamisa = 28, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Lincoln",              DataNascimento = new DateTime(1998, 2, 24), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,  NumCamisa = 29, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Vitor Gabriel",        DataNascimento = new DateTime(1999, 8, 14), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,  NumCamisa = 54, Altura = 1.83m, Peso = 78m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id }
                };
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => p.Nome, j));
                context.SaveChanges();
            }

            // 2- Comissões Técnicas e Jogadores do Time B
            var timeB = context.Times.FirstOrDefault(t => t.Nome == "Time B");
            if (timeB != null)
            {
                var comissaoTecnicaTimeB = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Carlos Moreira", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1975, 6, 10), TimeId = timeB.Id },
                    new ComissaoTecnica { Nome = "Felipe Andrade", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1980, 4, 22), TimeId = timeB.Id },
                    new ComissaoTecnica { Nome = "Mariana Lopes", Cargo = Cargo.Medico, DataNascimento = new DateTime(1982, 11, 5), TimeId = timeB.Id },
                    new ComissaoTecnica { Nome = "Roberto Dias", Cargo = Cargo.Massagista, DataNascimento = new DateTime(1978, 9, 15), TimeId = timeB.Id },
                    new ComissaoTecnica { Nome = "Fernanda Souza", Cargo = Cargo.Auxiliar, DataNascimento = new DateTime(1990, 3, 30), TimeId = timeB.Id }
                };


                var jogadoresTimeB = new List<Jogador>
                {
                    new Jogador { Nome = "Jogador 1", DataNascimento = new DateTime(1990, 1, 1), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 1, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Jogador 2", DataNascimento = new DateTime(1992, 2, 2), Nacionalidade = "Brasil", Posicao = Posicao.Defensor, NumCamisa = 2, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Lucas Pereira", Nacionalidade = "Brasil", DataNascimento = new DateTime(1995, 7, 21), NumCamisa = 1, Posicao = Posicao.Goleiro, Altura = 1.88m, Peso = 82, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Thiago Silva", Nacionalidade = "Brasil", DataNascimento = new DateTime(1994, 3, 11), NumCamisa = 4, Posicao = Posicao.Zagueiro, Altura = 1.85m, Peso = 78m, PePreferido = PePreferido.Esquerdo, TimeId = timeB.Id },
                    new Jogador { Nome = "Diego Costa", Nacionalidade = "Brasil", DataNascimento = new DateTime(1992, 1, 14), NumCamisa = 9, Posicao = Posicao.Atacante, Altura = 1.86m, Peso = 83m, PePreferido = PePreferido.Esquerdo, TimeId = timeB.Id },
                    new Jogador { Nome = "João Lucas", Nacionalidade = "Brasil", DataNascimento = new DateTime(1996, 9, 25), NumCamisa = 7, Posicao = Posicao.Atacante, Altura = 1.79m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "André Lima", Nacionalidade = "Brasil", DataNascimento = new DateTime(1998, 5, 6), NumCamisa = 10, Posicao = Posicao.MeioCampo, Altura = 1.76m, Peso = 72m, PePreferido = PePreferido.Ambidestro, TimeId = timeB.Id },
                    new Jogador { Nome = "Lucas Lima", Nacionalidade = "Brasil", DataNascimento = new DateTime(1991, 6, 15), NumCamisa = 8, Posicao = Posicao.MeioCampo, Altura = 1.80m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Gabriel Barbosa", Nacionalidade = "Brasil", DataNascimento = new DateTime(1996, 8, 30), NumCamisa = 11, Posicao = Posicao.Atacante, Altura = 1.78m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Bruno Henrique", Nacionalidade = "Brasil", DataNascimento = new DateTime(1990, 6, 30), NumCamisa = 7, Posicao = Posicao.Atacante, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Rodrigo Caio", Nacionalidade = "Brasil", DataNascimento = new DateTime(1993, 8, 17), NumCamisa = 3, Posicao = Posicao.Zagueiro, Altura = 1.83m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Felipe Luís", Nacionalidade = "Brasil", DataNascimento = new DateTime(1985, 8, 9), NumCamisa = 6, Posicao = Posicao.Lateral, Altura = 1.82m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Gerson", Nacionalidade = "Brasil", DataNascimento = new DateTime(1997, 5, 20), NumCamisa = 8, Posicao = Posicao.MeioCampo, Altura = 1.75m, Peso = 69m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Diego", Nacionalidade = "Brasil", DataNascimento = new DateTime(1985, 2, 15), NumCamisa = 10, Posicao = Posicao.MeioCampo, Altura = 1.74m, Peso = 65m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Éverton Ribeiro", Nacionalidade = "Brasil", DataNascimento = new DateTime(1989, 4, 10), NumCamisa = 7, Posicao = Posicao.MeioCampo, Altura = 1.74m, Peso = 64m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Bruno Viana", Nacionalidade = "Brasil", DataNascimento = new DateTime(1994, 2, 4), NumCamisa = 5, Posicao = Posicao.Zagueiro, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Rodinei", Nacionalidade = "Brasil", DataNascimento = new DateTime(1992, 2, 29), NumCamisa = 2, Posicao = Posicao.Lateral, Altura = 1.75m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Rafinha", Nacionalidade = "Brasil", DataNascimento = new DateTime(1985, 9, 7), NumCamisa = 13, Posicao = Posicao.Lateral, Altura = 1.70m, Peso = 64m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Gabriel", Nacionalidade = "Brasil", DataNascimento = new DateTime(1996, 8, 30), NumCamisa = 9, Posicao = Posicao.Atacante, Altura = 1.78m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Vitinho", Nacionalidade = "Brasil", DataNascimento = new DateTime(1993, 10, 9), NumCamisa = 11, Posicao = Posicao.Atacante, Altura = 1.75m, Peso = 66m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Pedro", Nacionalidade = "Brasil", DataNascimento = new DateTime(1997, 6, 20), NumCamisa = 21, Posicao = Posicao.Atacante, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Rodrigo Muniz", Nacionalidade = "Brasil", DataNascimento = new DateTime(2001, 1, 1), NumCamisa = 30, Posicao = Posicao.Atacante, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Léo Pereira", Nacionalidade = "Brasil", DataNascimento = new DateTime(1996, 5, 3), NumCamisa = 4, Posicao = Posicao.Zagueiro, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Thiago Maia", Nacionalidade = "Brasil", DataNascimento = new DateTime(1997, 3, 23), NumCamisa = 8, Posicao = Posicao.Volante, Altura = 1.80m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Andreas Pereira", Nacionalidade = "Brasil", DataNascimento = new DateTime(1996, 1, 1), NumCamisa = 15, Posicao = Posicao.MeioCampo, Altura = 1.75m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Thiago Silva", Nacionalidade = "Brasil", DataNascimento = new DateTime(1984, 9, 22), NumCamisa = 3, Posicao = Posicao.Zagueiro, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Natan", Nacionalidade = "Brasil", DataNascimento = new DateTime(2000, 1, 1), NumCamisa = 35, Posicao = Posicao.Zagueiro, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Léo Pereira", Nacionalidade = "Brasil", DataNascimento = new DateTime(1996, 5, 3), NumCamisa = 4, Posicao = Posicao.Zagueiro, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Rodrigo Muniz", Nacionalidade = "Brasil", DataNascimento = new DateTime(2001, 1, 1), NumCamisa = 30, Posicao = Posicao.Atacante, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                    new Jogador { Nome = "Pedro Rocha", Nacionalidade = "Brasil", DataNascimento = new DateTime(1996, 1, 1), NumCamisa = 17, Posicao = Posicao.Atacante, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = timeB.Id },
                };
                jogadoresTimeB.ForEach(j => context.Jogadores.AddOrUpdate(p => p.Nome, j));
                context.SaveChanges();
            }

            // 3- Comissões Técnicas e Jogadores do Santos 1962
            var santos1962 = context.Times.FirstOrDefault(t => t.Nome == "Santos 1962");
            if (santos1962 != null)
            {
                var comissoesTecnicas = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Luiz Alonso", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1954, 7, 24), TimeId = santos1962.Id },
                    new ComissaoTecnica { Nome = "Carlos Prado", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1960, 3, 15), TimeId = santos1962.Id },
                    new ComissaoTecnica { Nome = "João Batista", Cargo = Cargo.Medico, DataNascimento = new DateTime(1958, 9, 30), TimeId = santos1962.Id },
                    new ComissaoTecnica { Nome = "Roberto Lima", Cargo = Cargo.Massagista, DataNascimento = new DateTime(1965, 1, 10), TimeId = santos1962.Id },
                    new ComissaoTecnica { Nome = "Felipe Andrade", Cargo = Cargo.AnalistaDeDesempenho, DataNascimento = new DateTime(1980, 11, 5), TimeId = santos1962.Id }
                };
                comissoesTecnicas.ForEach(c => context.ComissoesTecnicas.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
                {
                    // Goleiros
                    new Jogador { Nome = "Diego Alves", DataNascimento = new DateTime(1985, 6, 24), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 1, Altura = 1.88m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = santos1962.Id },
                    new Jogador { Nome = "Renan Ribeiro", DataNascimento = new DateTime(1990, 3, 23), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 12, Altura = 1.86m, Peso = 82m, PePreferido = PePreferido.Esquerdo, TimeId = santos1962.Id },

                    // Zagueiros
                    new Jogador { Nome = "Lucas Veríssimo", DataNascimento = new DateTime(1995, 7, 2), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 3, Altura = 1.86m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = santos1962.Id },
                    new Jogador { Nome = "Gustavo Henrique", DataNascimento = new DateTime(1993, 3, 24), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 4, Altura = 1.93m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = santos1962.Id },
                    new Jogador { Nome = "Cléber Reis", DataNascimento = new DateTime(1990, 12, 5), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 14, Altura = 1.85m, Peso = 83m, PePreferido = PePreferido.Ambidestro, TimeId = santos1962.Id },

                    // Laterais
                    new Jogador { Nome = "Victor Ferraz", DataNascimento = new DateTime(1988, 1, 14), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 2, Altura = 1.76m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = santos1962.Id },
                    new Jogador { Nome = "Zeca", DataNascimento = new DateTime(1994, 5, 16), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 37, Altura = 1.74m, Peso = 69m, PePreferido = PePreferido.Esquerdo, TimeId = santos1962.Id },

                    // Volantes
                    new Jogador { Nome = "Alison", DataNascimento = new DateTime(1993, 6, 1), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 5, Altura = 1.76m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = santos1962.Id },
                    new Jogador { Nome = "Renato", DataNascimento = new DateTime(1979, 5, 15), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 8, Altura = 1.78m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = santos1962.Id },

                    // Meias
                    new Jogador { Nome = "Lucas Lima", DataNascimento = new DateTime(1990, 7, 9), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumCamisa = 10, Altura = 1.76m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = santos1962.Id },
                    new Jogador { Nome = "Vitor Bueno", DataNascimento = new DateTime(1994, 9, 5), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumCamisa = 7, Altura = 1.82m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = santos1962.Id },

                    // Atacantes
                    new Jogador { Nome = "Bruno Henrique", DataNascimento = new DateTime(1991, 12, 30), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 11, Altura = 1.84m, Peso = 74m, PePreferido = PePreferido.Ambidestro, TimeId = santos1962.Id },
                    new Jogador { Nome = "Ricardo Oliveira", DataNascimento = new DateTime(1980, 5, 6), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 9, Altura = 1.83m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = santos1962.Id },

                    // Defensores
                    new Jogador { Nome = "David Braz", DataNascimento = new DateTime(1987, 5, 21), Nacionalidade = "Brasil", Posicao = Posicao.Defensor, NumCamisa = 15, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = santos1962.Id },

                    // Mais jogadores para completar os 30 (genéricos)
                    new Jogador { Nome = "André Silva", DataNascimento = new DateTime(1996, 2, 14), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 18, Altura = 1.80m, Peso = 73m, PePreferido = PePreferido.Esquerdo, TimeId = santos1962.Id },
                    new Jogador { Nome = "Paulo Henrique", DataNascimento = new DateTime(1997, 8, 9), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 19, Altura = 1.78m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = santos1962.Id },
                    new Jogador { Nome = "Carlos Eduardo", DataNascimento = new DateTime(1999, 4, 22), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 13, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Esquerdo, TimeId = santos1962.Id },
                    new Jogador { Nome = "João Victor", DataNascimento = new DateTime(1998, 11, 11), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 16, Altura = 1.79m, Peso = 72m, PePreferido = PePreferido.Ambidestro, TimeId = santos1962.Id },
                    new Jogador { Nome = "Felipe Santos", DataNascimento = new DateTime(2000, 3, 3), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumCamisa = 17, Altura = 1.74m, Peso = 69m, PePreferido = PePreferido.Direito, TimeId = santos1962.Id },
                    new Jogador { Nome = "Gabriel Souza", DataNascimento = new DateTime(1995, 6, 30), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 6, Altura = 1.82m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = santos1962.Id },
                    new Jogador { Nome = "Marcelo Lima", DataNascimento = new DateTime(1994, 10, 28), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 20, Altura = 1.81m, Peso = 75m, PePreferido = PePreferido.Esquerdo, TimeId = santos1962.Id },
                    new Jogador { Nome = "Rodrigo Silva", DataNascimento = new DateTime(1992, 1, 9), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 22, Altura = 1.87m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = santos1962.Id },
                    new Jogador { Nome = "Eduardo Ramos", DataNascimento = new DateTime(1993, 7, 19), Nacionalidade = "Brasil", Posicao = Posicao.Defensor, NumCamisa = 23, Altura = 1.86m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = santos1962.Id },
                    new Jogador { Nome = "Tiago Costa", DataNascimento = new DateTime(1990, 12, 12), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 25, Altura = 1.77m, Peso = 74m, PePreferido = PePreferido.Ambidestro, TimeId = santos1962.Id },
                    new Jogador { Nome = "Vinícius Araújo", DataNascimento = new DateTime(1994, 5, 25), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 26, Altura = 1.80m, Peso = 73m, PePreferido = PePreferido.Esquerdo, TimeId = santos1962.Id },
                    new Jogador { Nome = "Leandro Damião", DataNascimento = new DateTime(1989, 7, 22), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 27, Altura = 1.86m, Peso = 79m, PePreferido = PePreferido.Direito, TimeId = santos1962.Id },
                    new Jogador { Nome = "Murilo Ferreira", DataNascimento = new DateTime(2001, 2, 5), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 28, Altura = 1.84m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = santos1962.Id }
                };
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => p.Nome, j));
                context.SaveChanges();
            }

            // 4- Comissões Técnicas e Jogadores do Palmeiras 2020
            var palmeiras2020 = context.Times.FirstOrDefault(t => t.Nome == "Palmeiras 2020");
            if (palmeiras2020 != null)
            {
                var comissoesTecnicas = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Abel Ferreira", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1978, 12, 22), TimeId = palmeiras2020.Id },
                    new ComissaoTecnica { Nome = "João Martins", Cargo = Cargo.Auxiliar, DataNascimento = new DateTime(1981, 6, 9), TimeId = palmeiras2020.Id },
                    new ComissaoTecnica { Nome = "Carlos Pacheco", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1975, 3, 15), TimeId = palmeiras2020.Id },
                    new ComissaoTecnica { Nome = "Bruno Mazziotti", Cargo = Cargo.Fisioterapeuta, DataNascimento = new DateTime(1982, 10, 18), TimeId = palmeiras2020.Id },
                    new ComissaoTecnica { Nome = "Gustavo Magliocca", Cargo = Cargo.Medico, DataNascimento = new DateTime(1970, 4, 25), TimeId = palmeiras2020.Id }
                };
                comissoesTecnicas.ForEach(c => context.ComissoesTecnicas.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
                {
                    // Goleiros
                    new Jogador { Nome = "Weverton", DataNascimento = new DateTime(1987, 12, 13), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 21, Altura = 1.89m, Peso = 84m, PePreferido = PePreferido.Direito, TimeId = palmeiras2020.Id },
                    new Jogador { Nome = "Vinícius Silvestre", DataNascimento = new DateTime(1994, 3, 14), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 24, Altura = 1.87m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = palmeiras2020.Id },

                    // Zagueiros
                    new Jogador { Nome = "Gustavo Gómez", DataNascimento = new DateTime(1993, 5, 6), Nacionalidade = "Paraguai", Posicao = Posicao.Zagueiro, NumCamisa = 15, Altura = 1.85m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = palmeiras2020.Id },
                    new Jogador { Nome = "Luan", DataNascimento = new DateTime(1993, 5, 10), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 13, Altura = 1.88m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = palmeiras2020.Id },
                    new Jogador { Nome = "Alan Empereur", DataNascimento = new DateTime(1994, 3, 10), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 33, Altura = 1.83m, Peso = 79m, PePreferido = PePreferido.Esquerdo, TimeId = palmeiras2020.Id },

                    // Laterais
                    new Jogador { Nome = "Marcos Rocha", DataNascimento = new DateTime(1988, 12, 11), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 2, Altura = 1.78m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = palmeiras2020.Id },
                    new Jogador { Nome = "Matías Viña", DataNascimento = new DateTime(1997, 11, 9), Nacionalidade = "Uruguai", Posicao = Posicao.Lateral, NumCamisa = 17, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Esquerdo, TimeId = palmeiras2020.Id },

                    // Volantes
                    new Jogador { Nome = "Felipe Melo", DataNascimento = new DateTime(1983, 6, 26), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 30, Altura = 1.83m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = palmeiras2020.Id },
                    new Jogador { Nome = "Danilo", DataNascimento = new DateTime(2001, 4, 29), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 28, Altura = 1.77m, Peso = 74m, PePreferido = PePreferido.Ambidestro, TimeId = palmeiras2020.Id },

                    // Meias
                    new Jogador { Nome = "Raphael Veiga", DataNascimento = new DateTime(1995, 6, 19), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumCamisa = 23, Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = palmeiras2020.Id },
                    new Jogador { Nome = "Lucas Lima", DataNascimento = new DateTime(1990, 7, 9), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 20, Altura = 1.76m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = palmeiras2020.Id },

                    // Atacantes
                    new Jogador { Nome = "Rony", DataNascimento = new DateTime(1995, 5, 11), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 11, Altura = 1.66m, Peso = 65m, PePreferido = PePreferido.Direito, TimeId = palmeiras2020.Id },
                    new Jogador { Nome = "Luiz Adriano", DataNascimento = new DateTime(1987, 4, 12), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 10, Altura = 1.83m, Peso = 75m, PePreferido = PePreferido.Esquerdo, TimeId = palmeiras2020.Id },

                    // Defensores
                    new Jogador { Nome = "Emerson Santos", DataNascimento = new DateTime(1995, 4, 5), Nacionalidade = "Brasil", Posicao = Posicao.Defensor, NumCamisa = 14, Altura = 1.80m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = palmeiras2020.Id },

                    // Adicionais até 30 jogadores
                    new Jogador { Nome = "Patrick de Paula", DataNascimento = new DateTime(1999, 9, 8), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 5, Altura = 1.80m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = palmeiras2020.Id },
                    new Jogador { Nome = "Gabriel Menino", DataNascimento = new DateTime(2000, 9, 29), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 25, Altura = 1.76m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = palmeiras2020.Id },
                    new Jogador { Nome = "Willian", DataNascimento = new DateTime(1986, 11, 19), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 29, Altura = 1.73m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = palmeiras2020.Id },
                    new Jogador { Nome = "Gabriel Veron", DataNascimento = new DateTime(2002, 9, 3), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 27, Altura = 1.76m, Peso = 73m, PePreferido = PePreferido.Esquerdo, TimeId = palmeiras2020.Id },
                    new Jogador { Nome = "Mayke", DataNascimento = new DateTime(1992, 11, 10), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 12, Altura = 1.78m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = palmeiras2020.Id },
                    new Jogador { Nome = "Esteves", DataNascimento = new DateTime(2000, 4, 24), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 16, Altura = 1.79m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = palmeiras2020.Id },
                    new Jogador { Nome = "Alan", DataNascimento = new DateTime(1999, 1, 3), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumCamisa = 18, Altura = 1.74m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = palmeiras2020.Id },
                    new Jogador { Nome = "Pedro Henrique", DataNascimento = new DateTime(1998, 2, 11), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 31, Altura = 1.80m, Peso = 74m, PePreferido = PePreferido.Ambidestro, TimeId = palmeiras2020.Id },
                    new Jogador { Nome = "Jonathan", DataNascimento = new DateTime(1996, 6, 22), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 19, Altura = 1.83m, Peso = 78m, PePreferido = PePreferido.Esquerdo, TimeId = palmeiras2020.Id },
                    new Jogador { Nome = "Ricardo", DataNascimento = new DateTime(1997, 7, 13), Nacionalidade = "Brasil", Posicao = Posicao.Defensor, NumCamisa = 32, Altura = 1.82m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = palmeiras2020.Id },
                    new Jogador { Nome = "Fernando", DataNascimento = new DateTime(1995, 10, 15), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 40, Altura = 1.88m, Peso = 81m, PePreferido = PePreferido.Esquerdo, TimeId = palmeiras2020.Id }
                };
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => p.Nome, j));
                context.SaveChanges();

            }

            // 5- Comissões Técnicas e Jogadores do Corinthians 2012
            var corinthians2012 = context.Times.FirstOrDefault(t => t.Nome == "Corinthians 2012");
            if (corinthians2012 != null)
            {
                var comissoesTecnicas = new List<ComissaoTecnica>
    {
        new ComissaoTecnica { Nome = "Tite", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1961, 5, 25), TimeId = corinthians2012.Id },
        new ComissaoTecnica { Nome = "Cléber Xavier", Cargo = Cargo.Auxiliar, DataNascimento = new DateTime(1964, 7, 29), TimeId = corinthians2012.Id },
        new ComissaoTecnica { Nome = "Fábio Mahseredjian", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1967, 9, 12), TimeId = corinthians2012.Id },
        new ComissaoTecnica { Nome = "Ivan Grava", Cargo = Cargo.Medico, DataNascimento = new DateTime(1958, 3, 18), TimeId = corinthians2012.Id },
        new ComissaoTecnica { Nome = "Bruno Mazziotti", Cargo = Cargo.Fisioterapeuta, DataNascimento = new DateTime(1982, 11, 21), TimeId = corinthians2012.Id }
    };
                comissoesTecnicas.ForEach(c => context.ComissoesTecnicas.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
    {
        // Goleiros
        new Jogador { Nome = "Cássio", DataNascimento = new DateTime(1987, 6, 6), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 12, Altura = 1.95m, Peso = 92m, PePreferido = PePreferido.Direito, TimeId = corinthians2012.Id },
        new Jogador { Nome = "Danilo Fernandes", DataNascimento = new DateTime(1988, 4, 3), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 22, Altura = 1.88m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = corinthians2012.Id },

        // Zagueiros
        new Jogador { Nome = "Chicão", DataNascimento = new DateTime(1981, 6, 3), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 3, Altura = 1.83m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = corinthians2012.Id },
        new Jogador { Nome = "Leandro Castán", DataNascimento = new DateTime(1986, 11, 5), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 4, Altura = 1.85m, Peso = 83m, PePreferido = PePreferido.Esquerdo, TimeId = corinthians2012.Id },
        new Jogador { Nome = "Wallace", DataNascimento = new DateTime(1987, 6, 20), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 25, Altura = 1.84m, Peso = 81m, PePreferido = PePreferido.Direito, TimeId = corinthians2012.Id },

        // Laterais
        new Jogador { Nome = "Fábio Santos", DataNascimento = new DateTime(1985, 9, 16), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 6, Altura = 1.76m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = corinthians2012.Id },
        new Jogador { Nome = "Alessandro", DataNascimento = new DateTime(1979, 1, 10), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 2, Altura = 1.75m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = corinthians2012.Id },

        // Volantes
        new Jogador { Nome = "Ralf", DataNascimento = new DateTime(1984, 6, 9), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 5, Altura = 1.78m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = corinthians2012.Id },
        new Jogador { Nome = "Paulinho", DataNascimento = new DateTime(1988, 7, 25), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 8, Altura = 1.81m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = corinthians2012.Id },

        // Meias
        new Jogador { Nome = "Danilo", DataNascimento = new DateTime(1979, 6, 23), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumCamisa = 20, Altura = 1.86m, Peso = 80m, PePreferido = PePreferido.Esquerdo, TimeId = corinthians2012.Id },
        new Jogador { Nome = "Douglas", DataNascimento = new DateTime(1982, 2, 18), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 15, Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = corinthians2012.Id },

        // Atacantes
        new Jogador { Nome = "Jorge Henrique", DataNascimento = new DateTime(1982, 4, 23), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 23, Altura = 1.73m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = corinthians2012.Id },
        new Jogador { Nome = "Emerson Sheik", DataNascimento = new DateTime(1978, 9, 6), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 11, Altura = 1.74m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = corinthians2012.Id },

        // Defensores
        new Jogador { Nome = "Marquinhos", DataNascimento = new DateTime(1994, 5, 14), Nacionalidade = "Brasil", Posicao = Posicao.Defensor, NumCamisa = 24, Altura = 1.83m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = corinthians2012.Id },

        // Adicionais até 30 jogadores
        new Jogador { Nome = "Romarinho", DataNascimento = new DateTime(1991, 12, 12), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 31, Altura = 1.74m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = corinthians2012.Id },
        new Jogador { Nome = "Edenílson", DataNascimento = new DateTime(1989, 12, 18), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 21, Altura = 1.75m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = corinthians2012.Id },
        new Jogador { Nome = "Willian Arão", DataNascimento = new DateTime(1992, 3, 12), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 17, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = corinthians2012.Id },
        new Jogador { Nome = "Luciano", DataNascimento = new DateTime(1993, 5, 18), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 18, Altura = 1.81m, Peso = 76m, PePreferido = PePreferido.Ambidestro, TimeId = corinthians2012.Id },
        new Jogador { Nome = "Matheus", DataNascimento = new DateTime(1995, 4, 9), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 27, Altura = 1.89m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = corinthians2012.Id },
        new Jogador { Nome = "Pedro Henrique", DataNascimento = new DateTime(1995, 12, 14), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 28, Altura = 1.86m, Peso = 81m, PePreferido = PePreferido.Direito, TimeId = corinthians2012.Id },
        new Jogador { Nome = "Igor", DataNascimento = new DateTime(1997, 6, 6), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 32, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Esquerdo, TimeId = corinthians2012.Id },
        new Jogador { Nome = "Carlos", DataNascimento = new DateTime(1998, 7, 22), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumCamisa = 19, Altura = 1.76m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = corinthians2012.Id },
        new Jogador { Nome = "Renato", DataNascimento = new DateTime(1996, 8, 10), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 16, Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = corinthians2012.Id },
        new Jogador { Nome = "André", DataNascimento = new DateTime(1994, 10, 8), Nacionalidade = "Brasil", Posicao = Posicao.Defensor, NumCamisa = 34, Altura = 1.82m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = corinthians2012.Id }
    };
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => p.Nome, j));
                context.SaveChanges();

            }

            // 6- Comissões Técnicas e Jogadores do São Paulo 2005
            var saoPaulo2005 = context.Times.FirstOrDefault(t => t.Nome == "São Paulo 2005");
            if (saoPaulo2005 != null)
            {
                var comissoesTecnicas = new List<ComissaoTecnica>
    {
        new ComissaoTecnica { Nome = "Muricy Ramalho", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1955, 11, 30), TimeId = saoPaulo2005.Id },
        new ComissaoTecnica { Nome = "Milton Cruz", Cargo = Cargo.Auxiliar, DataNascimento = new DateTime(1957, 8, 1), TimeId = saoPaulo2005.Id },
        new ComissaoTecnica { Nome = "Carlinhos Neves", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1961, 2, 13), TimeId = saoPaulo2005.Id },
        new ComissaoTecnica { Nome = "José Sanchez", Cargo = Cargo.Medico, DataNascimento = new DateTime(1950, 10, 5), TimeId = saoPaulo2005.Id },
        new ComissaoTecnica { Nome = "Luiz Rosan", Cargo = Cargo.Fisioterapeuta, DataNascimento = new DateTime(1963, 6, 22), TimeId = saoPaulo2005.Id }
    };
                comissoesTecnicas.ForEach(c => context.ComissoesTecnicas.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
    {
        // Goleiros
        new Jogador { Nome = "Rogério Ceni", DataNascimento = new DateTime(1973, 1, 22), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 1, Altura = 1.88m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = saoPaulo2005.Id },
        new Jogador { Nome = "Bosco", DataNascimento = new DateTime(1974, 11, 26), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 22, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = saoPaulo2005.Id },

        // Zagueiros
        new Jogador { Nome = "Lugano", DataNascimento = new DateTime(1980, 11, 2), Nacionalidade = "Uruguai", Posicao = Posicao.Zagueiro, NumCamisa = 5, Altura = 1.88m, Peso = 84m, PePreferido = PePreferido.Direito, TimeId = saoPaulo2005.Id },
        new Jogador { Nome = "Fabão", DataNascimento = new DateTime(1976, 6, 15), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 3, Altura = 1.87m, Peso = 82m, PePreferido = PePreferido.Esquerdo, TimeId = saoPaulo2005.Id },
        new Jogador { Nome = "Edcarlos", DataNascimento = new DateTime(1985, 5, 10), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 4, Altura = 1.84m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = saoPaulo2005.Id },

        // Laterais
        new Jogador { Nome = "Júnior", DataNascimento = new DateTime(1973, 6, 20), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 6, Altura = 1.72m, Peso = 68m, PePreferido = PePreferido.Esquerdo, TimeId = saoPaulo2005.Id },
        new Jogador { Nome = "Cicinho", DataNascimento = new DateTime(1980, 6, 24), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 2, Altura = 1.71m, Peso = 69m, PePreferido = PePreferido.Direito, TimeId = saoPaulo2005.Id },

        // Volantes
        new Jogador { Nome = "Mineiro", DataNascimento = new DateTime(1975, 8, 2), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 7, Altura = 1.75m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = saoPaulo2005.Id },
        new Jogador { Nome = "Josué", DataNascimento = new DateTime(1979, 7, 19), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 8, Altura = 1.76m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = saoPaulo2005.Id },

        // Meias
        new Jogador { Nome = "Danilo", DataNascimento = new DateTime(1979, 6, 23), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumCamisa = 10, Altura = 1.86m, Peso = 80m, PePreferido = PePreferido.Esquerdo, TimeId = saoPaulo2005.Id },
        new Jogador { Nome = "Souza", DataNascimento = new DateTime(1975, 2, 20), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 20, Altura = 1.80m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = saoPaulo2005.Id },

        // Atacantes
        new Jogador { Nome = "Luís Fabiano", DataNascimento = new DateTime(1980, 11, 8), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 9, Altura = 1.85m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = saoPaulo2005.Id },
        new Jogador { Nome = "Grafite", DataNascimento = new DateTime(1979, 4, 2), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 23, Altura = 1.89m, Peso = 84m, PePreferido = PePreferido.Direito, TimeId = saoPaulo2005.Id },

        // Defensores
        new Jogador { Nome = "Alex Bruno", DataNascimento = new DateTime(1982, 6, 9), Nacionalidade = "Brasil", Posicao = Posicao.Defensor, NumCamisa = 15, Altura = 1.85m, Peso = 81m, PePreferido = PePreferido.Direito, TimeId = saoPaulo2005.Id },

        // Goleiro Reserva
        new Jogador { Nome = "Roger", DataNascimento = new DateTime(1984, 2, 15), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 12, Altura = 1.84m, Peso = 79m, PePreferido = PePreferido.Direito, TimeId = saoPaulo2005.Id },

        // Adicionais
        new Jogador { Nome = "Renato Silva", DataNascimento = new DateTime(1983, 5, 26), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 14, Altura = 1.83m, Peso = 79m, PePreferido = PePreferido.Direito, TimeId = saoPaulo2005.Id },
        new Jogador { Nome = "Diego Tardelli", DataNascimento = new DateTime(1985, 5, 10), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 19, Altura = 1.79m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = saoPaulo2005.Id },
        new Jogador { Nome = "Marco Antônio", DataNascimento = new DateTime(1984, 1, 11), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 11, Altura = 1.77m, Peso = 74m, PePreferido = PePreferido.Ambidestro, TimeId = saoPaulo2005.Id },
        new Jogador { Nome = "Thiago Ribeiro", DataNascimento = new DateTime(1986, 2, 24), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 17, Altura = 1.83m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = saoPaulo2005.Id },
        new Jogador { Nome = "Jean", DataNascimento = new DateTime(1986, 6, 24), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 21, Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = saoPaulo2005.Id },
        new Jogador { Nome = "Richarlyson", DataNascimento = new DateTime(1982, 12, 27), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumCamisa = 16, Altura = 1.76m, Peso = 73m, PePreferido = PePreferido.Esquerdo, TimeId = saoPaulo2005.Id },
        new Jogador { Nome = "Leandro", DataNascimento = new DateTime(1983, 3, 15), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 13, Altura = 1.74m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = saoPaulo2005.Id },
        new Jogador { Nome = "Júnior César", DataNascimento = new DateTime(1982, 4, 9), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 18, Altura = 1.72m, Peso = 70m, PePreferido = PePreferido.Esquerdo, TimeId = saoPaulo2005.Id },
        new Jogador { Nome = "Hernanes", DataNascimento = new DateTime(1985, 5, 29), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 24, Altura = 1.80m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = saoPaulo2005.Id }
    };
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => p.Nome, j));
                context.SaveChanges();
            }

            // 7- Comissões Técnicas e Jogadores do Cruzeiro 2003
            var cruzeiro2003 = context.Times.FirstOrDefault(t => t.Nome == "Cruzeiro 2003");
            if (cruzeiro2003 != null)
            {
                var comissoesTecnicas = new List<ComissaoTecnica>
    {
        new ComissaoTecnica { Nome = "Vanderlei Luxemburgo", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1952, 5, 10), TimeId = cruzeiro2003.Id },
        new ComissaoTecnica { Nome = "Antonio Mello", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1954, 3, 8), TimeId = cruzeiro2003.Id },
        new ComissaoTecnica { Nome = "Rodrigo Lasmar", Cargo = Cargo.Medico, DataNascimento = new DateTime(1971, 9, 20), TimeId = cruzeiro2003.Id },
        new ComissaoTecnica { Nome = "João Carlos", Cargo = Cargo.Massagista, DataNascimento = new DateTime(1960, 1, 5), TimeId = cruzeiro2003.Id },
        new ComissaoTecnica { Nome = "Marcelo Salles", Cargo = Cargo.Auxiliar, DataNascimento = new DateTime(1978, 2, 15), TimeId = cruzeiro2003.Id }
    };
                comissoesTecnicas.ForEach(c => context.ComissoesTecnicas.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
    {
        // Goleiros
        new Jogador { Nome = "Gomes", DataNascimento = new DateTime(1981, 2, 15), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 1, Altura = 1.91m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = cruzeiro2003.Id },
        new Jogador { Nome = "Donizete", DataNascimento = new DateTime(1975, 10, 9), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 12, Altura = 1.85m, Peso = 79m, PePreferido = PePreferido.Direito, TimeId = cruzeiro2003.Id },

        // Zagueiros
        new Jogador { Nome = "Edu Dracena", DataNascimento = new DateTime(1981, 5, 18), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 3, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = cruzeiro2003.Id },
        new Jogador { Nome = "Luisão", DataNascimento = new DateTime(1981, 2, 13), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 4, Altura = 1.92m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = cruzeiro2003.Id },
        new Jogador { Nome = "Cris", DataNascimento = new DateTime(1977, 6, 3), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 13, Altura = 1.83m, Peso = 78m, PePreferido = PePreferido.Esquerdo, TimeId = cruzeiro2003.Id },

        // Laterais
        new Jogador { Nome = "Maurinho", DataNascimento = new DateTime(1978, 10, 11), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 2, Altura = 1.72m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = cruzeiro2003.Id },
        new Jogador { Nome = "Leandro", DataNascimento = new DateTime(1979, 1, 6), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 6, Altura = 1.75m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = cruzeiro2003.Id },

        // Volantes
        new Jogador { Nome = "Marcelo Batatais", DataNascimento = new DateTime(1974, 9, 10), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 5, Altura = 1.81m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = cruzeiro2003.Id },
        new Jogador { Nome = "Augusto Recife", DataNascimento = new DateTime(1983, 3, 3), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 8, Altura = 1.78m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = cruzeiro2003.Id },

        // Meias
        new Jogador { Nome = "Alex", DataNascimento = new DateTime(1977, 9, 14), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumCamisa = 10, Altura = 1.74m, Peso = 73m, PePreferido = PePreferido.Esquerdo, TimeId = cruzeiro2003.Id },
        new Jogador { Nome = "Wendel", DataNascimento = new DateTime(1981, 1, 1), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 15, Altura = 1.78m, Peso = 75m, PePreferido = PePreferido.Ambidestro, TimeId = cruzeiro2003.Id },

        // Atacantes
        new Jogador { Nome = "Aristizábal", DataNascimento = new DateTime(1971, 12, 17), Nacionalidade = "Colômbia", Posicao = Posicao.Atacante, NumCamisa = 9, Altura = 1.78m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = cruzeiro2003.Id },
        new Jogador { Nome = "Mota", DataNascimento = new DateTime(1980, 10, 19), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 11, Altura = 1.77m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = cruzeiro2003.Id },

        // Reservas e outros
        new Jogador { Nome = "Jonathan", DataNascimento = new DateTime(1986, 2, 27), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 16, Altura = 1.74m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = cruzeiro2003.Id },
        new Jogador { Nome = "Zinho", DataNascimento = new DateTime(1967, 6, 17), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 17, Altura = 1.69m, Peso = 68m, PePreferido = PePreferido.Esquerdo, TimeId = cruzeiro2003.Id },
        new Jogador { Nome = "Jussiê", DataNascimento = new DateTime(1983, 9, 19), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 18, Altura = 1.81m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = cruzeiro2003.Id },
        new Jogador { Nome = "Alan", DataNascimento = new DateTime(1980, 12, 10), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 19, Altura = 1.83m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = cruzeiro2003.Id },
        new Jogador { Nome = "Jadílson", DataNascimento = new DateTime(1977, 8, 4), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 20, Altura = 1.70m, Peso = 70m, PePreferido = PePreferido.Esquerdo, TimeId = cruzeiro2003.Id },
        new Jogador { Nome = "Valdiram", DataNascimento = new DateTime(1982, 10, 30), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 21, Altura = 1.79m, Peso = 73m, PePreferido = PePreferido.Ambidestro, TimeId = cruzeiro2003.Id },
        new Jogador { Nome = "Ricardinho", DataNascimento = new DateTime(1976, 3, 23), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumCamisa = 22, Altura = 1.72m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = cruzeiro2003.Id },
        new Jogador { Nome = "Kelly", DataNascimento = new DateTime(1975, 4, 27), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 23, Altura = 1.75m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = cruzeiro2003.Id },
        new Jogador { Nome = "Cléber", DataNascimento = new DateTime(1975, 7, 2), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 24, Altura = 1.86m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = cruzeiro2003.Id },
        new Jogador { Nome = "Tinga", DataNascimento = new DateTime(1978, 5, 13), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 25, Altura = 1.75m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = cruzeiro2003.Id },
        new Jogador { Nome = "Rodriguinho", DataNascimento = new DateTime(1980, 8, 15), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 26, Altura = 1.80m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = cruzeiro2003.Id },
        new Jogador { Nome = "Bruno", DataNascimento = new DateTime(1983, 9, 2), Nacionalidade = "Brasil", Posicao = Posicao.Defensor, NumCamisa = 27, Altura = 1.81m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = cruzeiro2003.Id },
        new Jogador { Nome = "Alan Bahia", DataNascimento = new DateTime(1983, 1, 14), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 28, Altura = 1.77m, Peso = 73m, PePreferido = PePreferido.Esquerdo, TimeId = cruzeiro2003.Id },
        new Jogador { Nome = "Felipe Melo", DataNascimento = new DateTime(1983, 6, 26), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 29, Altura = 1.83m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = cruzeiro2003.Id },
        new Jogador { Nome = "Adriano", DataNascimento = new DateTime(1982, 3, 5), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 30, Altura = 1.86m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = cruzeiro2003.Id }
    };
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => p.Nome, j));
                context.SaveChanges();
            }

            // 8- Comissões Técnicas e Jogadores do Atlético Mineiro 2013
            var atletico2013 = context.Times.FirstOrDefault(t => t.Nome == "Atlético Mineiro 2013");
            if (atletico2013 != null)
            {
                var comissoesTecnicas = new List<ComissaoTecnica>
    {
        new ComissaoTecnica { Nome = "Cuca", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1963, 6, 7), TimeId = atletico2013.Id },
        new ComissaoTecnica { Nome = "Carlinhos Neves", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1967, 9, 18), TimeId = atletico2013.Id },
        new ComissaoTecnica { Nome = "Otávio Lasmar", Cargo = Cargo.Medico, DataNascimento = new DateTime(1972, 12, 22), TimeId = atletico2013.Id },
        new ComissaoTecnica { Nome = "Guilherme Marques", Cargo = Cargo.Massagista, DataNascimento = new DateTime(1965, 5, 3), TimeId = atletico2013.Id },
        new ComissaoTecnica { Nome = "Eudes Pedro", Cargo = Cargo.Auxiliar, DataNascimento = new DateTime(1970, 4, 11), TimeId = atletico2013.Id }
    };
                comissoesTecnicas.ForEach(c => context.ComissoesTecnicas.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
    {
        // Goleiros
        new Jogador { Nome = "Victor", DataNascimento = new DateTime(1983, 1, 21), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 1, Altura = 1.87m, Peso = 84m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },
        new Jogador { Nome = "Giovanni", DataNascimento = new DateTime(1987, 2, 23), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 12, Altura = 1.88m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },

        // Zagueiros
        new Jogador { Nome = "Réver", DataNascimento = new DateTime(1985, 1, 4), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 4, Altura = 1.92m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },
        new Jogador { Nome = "Leonardo Silva", DataNascimento = new DateTime(1979, 6, 22), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 3, Altura = 1.90m, Peso = 86m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },
        new Jogador { Nome = "Gilberto Silva", DataNascimento = new DateTime(1976, 10, 7), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 5, Altura = 1.85m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },

        // Laterais
        new Jogador { Nome = "Marcos Rocha", DataNascimento = new DateTime(1988, 12, 11), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 2, Altura = 1.76m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },
        new Jogador { Nome = "Júnior César", DataNascimento = new DateTime(1982, 4, 9), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 6, Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Esquerdo, TimeId = atletico2013.Id },

        // Volantes
        new Jogador { Nome = "Pierre", DataNascimento = new DateTime(1982, 6, 14), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 7, Altura = 1.75m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },
        new Jogador { Nome = "Josué", DataNascimento = new DateTime(1979, 7, 19), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 8, Altura = 1.76m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },

        // Meias
        new Jogador { Nome = "Ronaldinho Gaúcho", DataNascimento = new DateTime(1980, 3, 21), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumCamisa = 10, Altura = 1.82m, Peso = 79m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },
        new Jogador { Nome = "Luan", DataNascimento = new DateTime(1990, 8, 11), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 27, Altura = 1.76m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },

        // Atacantes
        new Jogador { Nome = "Jô", DataNascimento = new DateTime(1987, 3, 20), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 7, Altura = 1.91m, Peso = 78m, PePreferido = PePreferido.Esquerdo, TimeId = atletico2013.Id },
        new Jogador { Nome = "Diego Tardelli", DataNascimento = new DateTime(1985, 5, 10), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 9, Altura = 1.79m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },

        // Suplentes e elenco de apoio
        new Jogador { Nome = "Michel", DataNascimento = new DateTime(1980, 12, 22), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 13, Altura = 1.74m, Peso = 70m, PePreferido = PePreferido.Esquerdo, TimeId = atletico2013.Id },
        new Jogador { Nome = "Alecsandro", DataNascimento = new DateTime(1981, 2, 4), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 20, Altura = 1.83m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },
        new Jogador { Nome = "Leandro Donizete", DataNascimento = new DateTime(1982, 5, 18), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 15, Altura = 1.78m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },

        // [Adicione mais 15 jogadores aqui com base no elenco ou de forma fictícia]
        new Jogador { Nome = "Richarlyson", DataNascimento = new DateTime(1982, 12, 27), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 17, Altura = 1.76m, Peso = 74m, PePreferido = PePreferido.Esquerdo, TimeId = atletico2013.Id },
        new Jogador { Nome = "Fernandinho", DataNascimento = new DateTime(1985, 11, 16), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 22, Altura = 1.80m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },
        new Jogador { Nome = "Marion", DataNascimento = new DateTime(1991, 2, 7), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 29, Altura = 1.77m, Peso = 70m, PePreferido = PePreferido.Ambidestro, TimeId = atletico2013.Id },
        new Jogador { Nome = "Carlos", DataNascimento = new DateTime(1995, 1, 12), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 30, Altura = 1.75m, Peso = 69m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },
        new Jogador { Nome = "Wesley Batista", DataNascimento = new DateTime(1994, 8, 10), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 16, Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },
    new Jogador { Nome = "Vinícius Oliveira", DataNascimento = new DateTime(1996, 3, 25), Nacionalidade = "Brasil", Posicao = Posicao.Defensor, NumCamisa = 18, Altura = 1.82m, Peso = 75m, PePreferido = PePreferido.Ambidestro, TimeId = atletico2013.Id },
    new Jogador { Nome = "André Luiz", DataNascimento = new DateTime(1993, 11, 9), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 23, Altura = 1.86m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },
    new Jogador { Nome = "Lucas Ramos", DataNascimento = new DateTime(1995, 6, 5), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 19, Altura = 1.79m, Peso = 74m, PePreferido = PePreferido.Esquerdo, TimeId = atletico2013.Id },
    new Jogador { Nome = "Felipe Braga", DataNascimento = new DateTime(1992, 10, 14), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumCamisa = 21, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },
    new Jogador { Nome = "Jonathan Soares", DataNascimento = new DateTime(1997, 1, 8), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 24, Altura = 1.73m, Peso = 69m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },
    new Jogador { Nome = "Eduardo Freitas", DataNascimento = new DateTime(1991, 9, 16), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 25, Altura = 1.80m, Peso = 74m, PePreferido = PePreferido.Esquerdo, TimeId = atletico2013.Id },
    new Jogador { Nome = "Bruno Fernandes", DataNascimento = new DateTime(1994, 12, 3), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 26, Altura = 1.88m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },
    new Jogador { Nome = "Matheus Peixoto", DataNascimento = new DateTime(1995, 7, 15), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 28, Altura = 1.83m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },
    new Jogador { Nome = "Thiago Santos", DataNascimento = new DateTime(1992, 2, 2), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 31, Altura = 1.81m, Peso = 75m, PePreferido = PePreferido.Ambidestro, TimeId = atletico2013.Id },
    new Jogador { Nome = "Ricardo Almeida", DataNascimento = new DateTime(1993, 8, 19), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 32, Altura = 1.76m, Peso = 70m, PePreferido = PePreferido.Esquerdo, TimeId = atletico2013.Id },
    new Jogador { Nome = "Renan Martins", DataNascimento = new DateTime(1996, 4, 4), Nacionalidade = "Brasil", Posicao = Posicao.Defensor, NumCamisa = 33, Altura = 1.84m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },
    new Jogador { Nome = "Igor Menezes", DataNascimento = new DateTime(1997, 6, 30), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumCamisa = 34, Altura = 1.74m, Peso = 69m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id },
    new Jogador { Nome = "Caio Fernandes", DataNascimento = new DateTime(1995, 5, 11), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 35, Altura = 1.81m, Peso = 73m, PePreferido = PePreferido.Esquerdo, TimeId = atletico2013.Id },
    new Jogador { Nome = "Erick Souza", DataNascimento = new DateTime(1998, 10, 6), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 36, Altura = 1.87m, Peso = 79m, PePreferido = PePreferido.Direito, TimeId = atletico2013.Id }
    };
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => p.Nome, j));
                context.SaveChanges();

            }

            // 9- Comissões Técnicas e Jogadores do Grêmio 1995
            var gremio1995 = context.Times.FirstOrDefault(t => t.Nome == "Grêmio 1995");
            if (gremio1995 != null)
            {
                var comissoesTecnicas = new List<ComissaoTecnica>
    {
        new ComissaoTecnica { Nome = "Luiz Felipe Scolari", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1948, 11, 9), TimeId = gremio1995.Id },
        new ComissaoTecnica { Nome = "Paulo Paixão", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1950, 8, 15), TimeId = gremio1995.Id },
        new ComissaoTecnica { Nome = "Carlos Becker", Cargo = Cargo.Massagista, DataNascimento = new DateTime(1960, 3, 22), TimeId = gremio1995.Id },
        new ComissaoTecnica { Nome = "Jorge Silva", Cargo = Cargo.Medico, DataNascimento = new DateTime(1955, 6, 18), TimeId = gremio1995.Id },
        new ComissaoTecnica { Nome = "André Nunes", Cargo = Cargo.AnalistaDeDesempenho, DataNascimento = new DateTime(1985, 4, 5), TimeId = gremio1995.Id }
    };
                comissoesTecnicas.ForEach(c => context.ComissoesTecnicas.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
    {
        // Goleiros
        new Jogador { Nome = "Danrlei de Deus", DataNascimento = new DateTime(1973, 4, 18), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 1, Altura = 1.83m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = gremio1995.Id },
        new Jogador { Nome = "Tiago Moreira", DataNascimento = new DateTime(1992, 7, 8), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 12, Altura = 1.86m, Peso = 82m, PePreferido = PePreferido.Esquerdo, TimeId = gremio1995.Id },

        // Zagueiros
        new Jogador { Nome = "Rivarola", DataNascimento = new DateTime(1970, 7, 26), Nacionalidade = "Paraguai", Posicao = Posicao.Zagueiro, NumCamisa = 3, Altura = 1.85m, Peso = 79m, PePreferido = PePreferido.Direito, TimeId = gremio1995.Id },
        new Jogador { Nome = "Adílson Gomes", DataNascimento = new DateTime(1990, 6, 21), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 4, Altura = 1.84m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = gremio1995.Id },

        // Laterais
        new Jogador { Nome = "Arce", DataNascimento = new DateTime(1971, 7, 2), Nacionalidade = "Paraguai", Posicao = Posicao.Lateral, NumCamisa = 2, Altura = 1.76m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = gremio1995.Id },
        new Jogador { Nome = "Roger Machado", DataNascimento = new DateTime(1975, 4, 25), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 6, Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Esquerdo, TimeId = gremio1995.Id },

        // Volantes
        new Jogador { Nome = "Dinho", DataNascimento = new DateTime(1966, 5, 15), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 5, Altura = 1.79m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = gremio1995.Id },
        new Jogador { Nome = "Emerson", DataNascimento = new DateTime(1976, 4, 4), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 8, Altura = 1.82m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = gremio1995.Id },

        // Meias
        new Jogador { Nome = "Carlos Miguel", DataNascimento = new DateTime(1972, 6, 12), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumCamisa = 10, Altura = 1.78m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = gremio1995.Id },
        new Jogador { Nome = "Luciano Amaral", DataNascimento = new DateTime(1994, 8, 14), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 20, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Esquerdo, TimeId = gremio1995.Id },

        // Atacantes
        new Jogador { Nome = "Paulo Nunes", DataNascimento = new DateTime(1971, 10, 30), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 7, Altura = 1.76m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = gremio1995.Id },
        new Jogador { Nome = "Jardel", DataNascimento = new DateTime(1973, 9, 18), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 9, Altura = 1.88m, Peso = 84m, PePreferido = PePreferido.Direito, TimeId = gremio1995.Id },

        // Demais jogadores variados
        new Jogador { Nome = "Rafael Martins", DataNascimento = new DateTime(1995, 3, 19), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 13, Altura = 1.86m, Peso = 81m, PePreferido = PePreferido.Direito, TimeId = gremio1995.Id },
        new Jogador { Nome = "Lucas Moreira", DataNascimento = new DateTime(1996, 5, 1), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 17, Altura = 1.77m, Peso = 73m, PePreferido = PePreferido.Ambidestro, TimeId = gremio1995.Id },
        new Jogador { Nome = "Victor Oliveira", DataNascimento = new DateTime(1997, 9, 3), Nacionalidade = "Brasil", Posicao = Posicao.Defensor, NumCamisa = 19, Altura = 1.82m, Peso = 76m, PePreferido = PePreferido.Esquerdo, TimeId = gremio1995.Id },
        new Jogador { Nome = "Marcelo Augusto", DataNascimento = new DateTime(1992, 2, 21), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 22, Altura = 1.81m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = gremio1995.Id },
        new Jogador { Nome = "Bruno Viana", DataNascimento = new DateTime(1993, 11, 11), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 25, Altura = 1.88m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = gremio1995.Id },
        new Jogador { Nome = "Gustavo Neves", DataNascimento = new DateTime(1990, 7, 9), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 26, Altura = 1.77m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = gremio1995.Id },
        new Jogador { Nome = "Igor Mendes", DataNascimento = new DateTime(1998, 10, 17), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumCamisa = 28, Altura = 1.74m, Peso = 70m, PePreferido = PePreferido.Ambidestro, TimeId = gremio1995.Id },
        new Jogador { Nome = "Cauã Reis", DataNascimento = new DateTime(1996, 6, 6), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 29, Altura = 1.79m, Peso = 74m, PePreferido = PePreferido.Esquerdo, TimeId = gremio1995.Id },
        new Jogador { Nome = "Diego Amaral", DataNascimento = new DateTime(1991, 5, 4), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 30, Altura = 1.80m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = gremio1995.Id },
        new Jogador { Nome = "Lucas Gonçalves", DataNascimento = new DateTime(1994, 1, 19), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 31, Altura = 1.75m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = gremio1995.Id },
        new Jogador { Nome = "Pedro Henrique", DataNascimento = new DateTime(1995, 2, 14), Nacionalidade = "Brasil", Posicao = Posicao.Defensor, NumCamisa = 33, Altura = 1.84m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = gremio1995.Id },
        new Jogador { Nome = "Alan Costa", DataNascimento = new DateTime(1993, 12, 12), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 34, Altura = 1.89m, Peso = 84m, PePreferido = PePreferido.Direito, TimeId = gremio1995.Id },
        new Jogador { Nome = "Thiago Lopes", DataNascimento = new DateTime(1992, 8, 2), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumCamisa = 35, Altura = 1.77m, Peso = 73m, PePreferido = PePreferido.Esquerdo, TimeId = gremio1995.Id }
    };
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => p.Nome, j));
                context.SaveChanges();
            }

            // 10- Comissões Técnicas e Jogadores do Internacional 2006
            var internacional2006 = context.Times.FirstOrDefault(t => t.Nome == "Internacional 2006");
            if (internacional2006 != null)
            {
                var comissoesTecnicas = new List<ComissaoTecnica>
    {
        new ComissaoTecnica { Nome = "Abel Braga", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1952, 9, 1), TimeId = internacional2006.Id },
        new ComissaoTecnica { Nome = "Ricardo Silva", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1963, 3, 12), TimeId = internacional2006.Id },
        new ComissaoTecnica { Nome = "Fernando Müller", Cargo = Cargo.Massagista, DataNascimento = new DateTime(1968, 11, 22), TimeId = internacional2006.Id },
        new ComissaoTecnica { Nome = "Dr. Eduardo Santos", Cargo = Cargo.Medico, DataNascimento = new DateTime(1959, 6, 5), TimeId = internacional2006.Id },
        new ComissaoTecnica { Nome = "Rodrigo Pires", Cargo = Cargo.AnalistaDeDesempenho, DataNascimento = new DateTime(1987, 4, 9), TimeId = internacional2006.Id }
    };
                comissoesTecnicas.ForEach(c => context.ComissoesTecnicas.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
    {
        // Goleiros
        new Jogador { Nome = "Clemer", DataNascimento = new DateTime(1968, 10, 20), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 1, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = internacional2006.Id },
        new Jogador { Nome = "Muriel Becker", DataNascimento = new DateTime(1987, 2, 14), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 12, Altura = 1.88m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = internacional2006.Id },

        // Zagueiros
        new Jogador { Nome = "Índio", DataNascimento = new DateTime(1975, 2, 13), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 3, Altura = 1.86m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = internacional2006.Id },
        new Jogador { Nome = "Fabiano Eller", DataNascimento = new DateTime(1977, 6, 19), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 4, Altura = 1.84m, Peso = 79m, PePreferido = PePreferido.Esquerdo, TimeId = internacional2006.Id },

        // Laterais
        new Jogador { Nome = "Ceará", DataNascimento = new DateTime(1980, 6, 18), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 2, Altura = 1.76m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = internacional2006.Id },
        new Jogador { Nome = "Rubens Cardoso", DataNascimento = new DateTime(1976, 9, 6), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 6, Altura = 1.75m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = internacional2006.Id },

        // Volantes
        new Jogador { Nome = "Edinho", DataNascimento = new DateTime(1983, 1, 15), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 5, Altura = 1.83m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = internacional2006.Id },
        new Jogador { Nome = "Wellington Monteiro", DataNascimento = new DateTime(1978, 9, 7), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 15, Altura = 1.82m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = internacional2006.Id },

        // Meias
        new Jogador { Nome = "Tinga", DataNascimento = new DateTime(1978, 5, 13), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumCamisa = 7, Altura = 1.76m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = internacional2006.Id },
        new Jogador { Nome = "Alex", DataNascimento = new DateTime(1982, 9, 14), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 10, Altura = 1.75m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = internacional2006.Id },

        // Atacantes
        new Jogador { Nome = "Fernandão", DataNascimento = new DateTime(1978, 3, 18), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 9, Altura = 1.90m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = internacional2006.Id },
        new Jogador { Nome = "Rafael Sobis", DataNascimento = new DateTime(1985, 6, 17), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 11, Altura = 1.74m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = internacional2006.Id },

        // Outros jogadores variados
        new Jogador { Nome = "Jorge Luiz", DataNascimento = new DateTime(1983, 8, 3), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 13, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = internacional2006.Id },
        new Jogador { Nome = "Luiz Adriano", DataNascimento = new DateTime(1987, 4, 12), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 14, Altura = 1.83m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = internacional2006.Id },
        new Jogador { Nome = "Rodrigo Mendes", DataNascimento = new DateTime(1975, 8, 9), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumCamisa = 16, Altura = 1.77m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = internacional2006.Id },
        new Jogador { Nome = "Maycon", DataNascimento = new DateTime(1986, 11, 5), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 17, Altura = 1.72m, Peso = 70m, PePreferido = PePreferido.Ambidestro, TimeId = internacional2006.Id },
        new Jogador { Nome = "Perdigão", DataNascimento = new DateTime(1977, 5, 10), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 18, Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = internacional2006.Id },
        new Jogador { Nome = "Michel Bastos", DataNascimento = new DateTime(1983, 8, 2), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 19, Altura = 1.80m, Peso = 76m, PePreferido = PePreferido.Esquerdo, TimeId = internacional2006.Id },
        new Jogador { Nome = "Rodrigo Moledo", DataNascimento = new DateTime(1987, 10, 27), Nacionalidade = "Brasil", Posicao = Posicao.Defensor, NumCamisa = 20, Altura = 1.88m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = internacional2006.Id },
        new Jogador { Nome = "Andrezinho", DataNascimento = new DateTime(1983, 8, 30), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumCamisa = 21, Altura = 1.75m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = internacional2006.Id },
        new Jogador { Nome = "Gabriel", DataNascimento = new DateTime(1980, 7, 14), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 22, Altura = 1.76m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = internacional2006.Id },
        new Jogador { Nome = "Renan", DataNascimento = new DateTime(1985, 1, 24), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 23, Altura = 1.87m, Peso = 81m, PePreferido = PePreferido.Direito, TimeId = internacional2006.Id },
        new Jogador { Nome = "Élder Granja", DataNascimento = new DateTime(1982, 7, 2), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumCamisa = 24, Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = internacional2006.Id },
        new Jogador { Nome = "Danny Morais", DataNascimento = new DateTime(1985, 6, 29), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumCamisa = 25, Altura = 1.86m, Peso = 79m, PePreferido = PePreferido.Esquerdo, TimeId = internacional2006.Id },
        new Jogador { Nome = "Gustavo Papa", DataNascimento = new DateTime(1979, 10, 20), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 26, Altura = 1.86m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = internacional2006.Id },
        new Jogador { Nome = "Rosinei", DataNascimento = new DateTime(1983, 10, 3), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumCamisa = 27, Altura = 1.74m, Peso = 71m, PePreferido = PePreferido.Ambidestro, TimeId = internacional2006.Id },
        new Jogador { Nome = "Sandro", DataNascimento = new DateTime(1989, 3, 15), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 28, Altura = 1.87m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = internacional2006.Id },
        new Jogador { Nome = "Eduardo Sasha", DataNascimento = new DateTime(1992, 2, 24), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 29, Altura = 1.74m, Peso = 70m, PePreferido = PePreferido.Esquerdo, TimeId = internacional2006.Id },
        new Jogador { Nome = "Marquinhos", DataNascimento = new DateTime(1990, 9, 10), Nacionalidade = "Brasil", Posicao = Posicao.MeioCampo, NumCamisa = 30, Altura = 1.78m, Peso = 73m, PePreferido = PePreferido.Ambidestro, TimeId = internacional2006.Id }
    };
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => p.Nome, j));
                context.SaveChanges();
            }

            // 11- Comissões Técnicas e Jogadores do Barcelona 2009
            var barcelona = context.Times.FirstOrDefault(t => t.Nome == "Barcelona 2009");
            if (barcelona != null)
            {
                var comissoesTecnicas = new List<ComissaoTecnica>
    {
        new ComissaoTecnica { Nome = "Pep Guardiola", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1971, 1, 18), TimeId = barcelona.Id },
        new ComissaoTecnica { Nome = "Lorenzo Buenaventura", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1966, 6, 15), TimeId = barcelona.Id },
        new ComissaoTecnica { Nome = "Ricard Pruna", Cargo = Cargo.Medico, DataNascimento = new DateTime(1965, 9, 21), TimeId = barcelona.Id },
        new ComissaoTecnica { Nome = "Carles Planchart", Cargo = Cargo.AnalistaDeDesempenho, DataNascimento = new DateTime(1970, 5, 10), TimeId = barcelona.Id },
        new ComissaoTecnica { Nome = "José Ramon", Cargo = Cargo.Fisioterapeuta, DataNascimento = new DateTime(1973, 3, 12), TimeId = barcelona.Id },
    };
                comissoesTecnicas.ForEach(c => context.ComissoesTecnicas.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
    {
        new Jogador { Nome = "Víctor Valdés", Posicao = Posicao.Goleiro, DataNascimento = new DateTime(1982, 1, 14), Nacionalidade = "Espanha", NumCamisa = 1, Altura = 1.83m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Gerard Piqué", Posicao = Posicao.Zagueiro, DataNascimento = new DateTime(1987, 2, 2), Nacionalidade = "Espanha", NumCamisa = 3, Altura = 1.94m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Carles Puyol", Posicao = Posicao.Zagueiro, DataNascimento = new DateTime(1978, 4, 13), Nacionalidade = "Espanha", NumCamisa = 5, Altura = 1.78m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Dani Alves", Posicao = Posicao.Lateral, DataNascimento = new DateTime(1983, 5, 6), Nacionalidade = "Brasil", NumCamisa = 2, Altura = 1.72m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Eric Abidal", Posicao = Posicao.Lateral, DataNascimento = new DateTime(1979, 9, 11), Nacionalidade = "França", NumCamisa = 22, Altura = 1.86m, Peso = 75m, PePreferido = PePreferido.Esquerdo, TimeId = barcelona.Id },
        new Jogador { Nome = "Sergio Busquets", Posicao = Posicao.Volante, DataNascimento = new DateTime(1988, 7, 16), Nacionalidade = "Espanha", NumCamisa = 16, Altura = 1.89m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Xavi", Posicao = Posicao.Meia, DataNascimento = new DateTime(1980, 1, 25), Nacionalidade = "Espanha", NumCamisa = 6, Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Andrés Iniesta", Posicao = Posicao.Meia, DataNascimento = new DateTime(1984, 5, 11), Nacionalidade = "Espanha", NumCamisa = 8, Altura = 1.71m, Peso = 65m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Lionel Messi", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1987, 6, 24), Nacionalidade = "Argentina", NumCamisa = 10, Altura = 1.70m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = barcelona.Id },
        new Jogador { Nome = "Samuel Eto'o", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1981, 3, 10), Nacionalidade = "Camarões", NumCamisa = 9, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Thierry Henry", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1977, 8, 17), Nacionalidade = "França", NumCamisa = 14, Altura = 1.88m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },

        // Adicione mais 19 jogadores fictícios ou históricos do elenco reserva...
        new Jogador { Nome = "Bojan Krkic", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1990, 8, 28), Nacionalidade = "Espanha", NumCamisa = 11, Altura = 1.70m, Peso = 65m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Yaya Touré", Posicao = Posicao.Volante, DataNascimento = new DateTime(1983, 5, 13), Nacionalidade = "Costa do Marfim", NumCamisa = 24, Altura = 1.88m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Seydou Keita", Posicao = Posicao.MeioCampo, DataNascimento = new DateTime(1980, 1, 16), Nacionalidade = "Mali", NumCamisa = 15, Altura = 1.83m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Pedro Rodríguez", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1987, 7, 28), Nacionalidade = "Espanha", NumCamisa = 17, Altura = 1.69m, Peso = 65m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Sergi Roberto", Posicao = Posicao.Lateral, DataNascimento = new DateTime(1992, 2, 7), Nacionalidade = "Espanha", NumCamisa = 20, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Javier Mascherano", Posicao = Posicao.Volante, DataNascimento = new DateTime(1984, 6, 8), Nacionalidade = "Argentina", NumCamisa = 14, Altura = 1.74m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Maxwell", Posicao = Posicao.Lateral, DataNascimento = new DateTime(1981, 8, 2), Nacionalidade = "Brasil", NumCamisa = 19, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Martin Montoya", Posicao = Posicao.Lateral, DataNascimento = new DateTime(1991, 4, 14), Nacionalidade = "Espanha", NumCamisa = 28, Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Thiago Alcântara", Posicao = Posicao.Meia, DataNascimento = new DateTime(1991, 4, 11), Nacionalidade = "Espanha", NumCamisa = 24, Altura = 1.74m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Ibrahim Afellay", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1986, 4, 2), Nacionalidade = "Países Baixos", NumCamisa = 20, Altura = 1.78m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Javier Saviola", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1981, 12, 17), Nacionalidade = "Argentina", NumCamisa = 7, Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Gabi Milito", Posicao = Posicao.Zagueiro, DataNascimento = new DateTime(1980, 9, 7), Nacionalidade = "Argentina", NumCamisa = 15, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Cristian Tello", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1991, 8, 11), Nacionalidade = "Espanha", NumCamisa = 29, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Marc Bartra", Posicao = Posicao.Zagueiro, DataNascimento = new DateTime(1991, 3, 15), Nacionalidade = "Espanha", NumCamisa = 28, Altura = 1.84m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Cristian Álvarez", Posicao = Posicao.Goleiro, DataNascimento = new DateTime(1986, 1, 2), Nacionalidade = "Argentina", NumCamisa = 13, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Oier Olazábal", Posicao = Posicao.Goleiro, DataNascimento = new DateTime(1988, 3, 2), Nacionalidade = "Espanha", NumCamisa = 25, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Jordi Masip", Posicao = Posicao.Goleiro, DataNascimento = new DateTime(1989, 1, 3), Nacionalidade = "Espanha", NumCamisa = 13, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Sergi Samper", Posicao = Posicao.Volante, DataNascimento = new DateTime(1995, 1, 20), Nacionalidade = "Espanha", NumCamisa = 16, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },
        new Jogador { Nome = "Munir El Haddadi", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1995, 9, 1), Nacionalidade = "Espanha", NumCamisa = 29, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = barcelona.Id },

    };
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => p.Nome, j));
                context.SaveChanges();

            }

            // 12- Comissões Técnicas e Jogadores do Real Madrid 2017
            // Busca o time no banco
            var realMadrid = context.Times.FirstOrDefault(t => t.Nome == "Real Madrid 2017");
            if (realMadrid != null)
            {
                // Comissão Técnica (mínimo 5 com cargos distintos)
                var comissoesTecnicas = new List<ComissaoTecnica>
    {
        new ComissaoTecnica { Nome = "Zinedine Zidane", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1972, 6, 23), TimeId = realMadrid.Id },
        new ComissaoTecnica { Nome = "Antonio Pintus", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1962, 9, 12), TimeId = realMadrid.Id },
        new ComissaoTecnica { Nome = "Jesús Olmo", Cargo = Cargo.Medico, DataNascimento = new DateTime(1975, 1, 9), TimeId = realMadrid.Id },
        new ComissaoTecnica { Nome = "Roberto Vázquez", Cargo = Cargo.AnalistaDeDesempenho, DataNascimento = new DateTime(1979, 8, 3), TimeId = realMadrid.Id },
        new ComissaoTecnica { Nome = "Luis Llopis", Cargo = Cargo.TreinadorDeGoleiros, DataNascimento = new DateTime(1964, 3, 18), TimeId = realMadrid.Id },
    };
                comissoesTecnicas.ForEach(c => context.ComissoesTecnicas.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                // Jogadores (mínimo 30 com variação de posições)
                var jogadores = new List<Jogador>
    {
        // Goleiros
        new Jogador { Nome = "Keylor Navas", Posicao = Posicao.Goleiro, DataNascimento = new DateTime(1986, 12, 15), Nacionalidade = "Costa Rica", NumCamisa = 1, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
        new Jogador { Nome = "Kiko Casilla", Posicao = Posicao.Goleiro, DataNascimento = new DateTime(1986, 10, 2), Nacionalidade = "Espanha", NumCamisa = 13, Altura = 1.91m, Peso = 84m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
        new Jogador { Nome = "Rubén Yáñez", Posicao = Posicao.Goleiro, DataNascimento = new DateTime(1993, 10, 12), Nacionalidade = "Espanha", NumCamisa = 25, Altura = 1.90m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },

        // Zagueiros
        new Jogador { Nome = "Sergio Ramos", Posicao = Posicao.Zagueiro, DataNascimento = new DateTime(1986, 3, 30), Nacionalidade = "Espanha", NumCamisa = 4, Altura = 1.84m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
        new Jogador { Nome = "Raphaël Varane", Posicao = Posicao.Zagueiro, DataNascimento = new DateTime(1993, 4, 25), Nacionalidade = "França", NumCamisa = 5, Altura = 1.91m, Peso = 81m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
        new Jogador { Nome = "Nacho Fernández", Posicao = Posicao.Zagueiro, DataNascimento = new DateTime(1990, 1, 18), Nacionalidade = "Espanha", NumCamisa = 6, Altura = 1.80m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
        new Jogador { Nome = "Pepe", Posicao = Posicao.Zagueiro, DataNascimento = new DateTime(1983, 2, 26), Nacionalidade = "Portugal", NumCamisa = 3, Altura = 1.88m, Peso = 81m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },

        // Laterais
        new Jogador { Nome = "Marcelo", Posicao = Posicao.Lateral, DataNascimento = new DateTime(1988, 5, 12), Nacionalidade = "Brasil", NumCamisa = 12, Altura = 1.74m, Peso = 75m, PePreferido = PePreferido.Esquerdo, TimeId = realMadrid.Id },
        new Jogador { Nome = "Dani Carvajal", Posicao = Posicao.Lateral, DataNascimento = new DateTime(1992, 1, 11), Nacionalidade = "Espanha", NumCamisa = 2, Altura = 1.73m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
        new Jogador { Nome = "Danilo", Posicao = Posicao.Lateral, DataNascimento = new DateTime(1991, 7, 15), Nacionalidade = "Brasil", NumCamisa = 23, Altura = 1.84m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },

        // Volantes
        new Jogador { Nome = "Casemiro", Posicao = Posicao.Volante, DataNascimento = new DateTime(1992, 2, 23), Nacionalidade = "Brasil", NumCamisa = 14, Altura = 1.85m, Peso = 84m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
        new Jogador { Nome = "Toni Kroos", Posicao = Posicao.Volante, DataNascimento = new DateTime(1990, 1, 4), Nacionalidade = "Alemanha", NumCamisa = 8, Altura = 1.83m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
        new Jogador { Nome = "Mateo Kovačić", Posicao = Posicao.Volante, DataNascimento = new DateTime(1994, 5, 6), Nacionalidade = "Croácia", NumCamisa = 16, Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },

        // Meias
        new Jogador { Nome = "Luka Modrić", Posicao = Posicao.Meia, DataNascimento = new DateTime(1985, 9, 9), Nacionalidade = "Croácia", NumCamisa = 10, Altura = 1.72m, Peso = 66m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
        new Jogador { Nome = "Isco", Posicao = Posicao.Meia, DataNascimento = new DateTime(1992, 4, 21), Nacionalidade = "Espanha", NumCamisa = 22, Altura = 1.76m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
        new Jogador { Nome = "James Rodríguez", Posicao = Posicao.Meia, DataNascimento = new DateTime(1991, 7, 12), Nacionalidade = "Colômbia", NumCamisa = 10, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Esquerdo, TimeId = realMadrid.Id },

        // Atacantes
        new Jogador { Nome = "Cristiano Ronaldo", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1985, 2, 5), Nacionalidade = "Portugal", NumCamisa = 7, Altura = 1.87m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
        new Jogador { Nome = "Karim Benzema", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1987, 12, 19), Nacionalidade = "França", NumCamisa = 9, Altura = 1.85m, Peso = 81m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
        new Jogador { Nome = "Gareth Bale", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1989, 7, 16), Nacionalidade = "País de Gales", NumCamisa = 11, Altura = 1.85m, Peso = 82m, PePreferido = PePreferido.Esquerdo, TimeId = realMadrid.Id },
        new Jogador { Nome = "Álvaro Morata", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1992, 10, 23), Nacionalidade = "Espanha", NumCamisa = 21, Altura = 1.90m, Peso = 84m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
        new Jogador { Nome = "Marco Asensio", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1996, 1, 21), Nacionalidade = "Espanha", NumCamisa = 20, Altura = 1.82m, Peso = 76m, PePreferido = PePreferido.Esquerdo, TimeId = realMadrid.Id },
        
        // Adicione mais jogadores fictícios ou reservas para completar os 30
        new Jogador { Nome = "Lucas Vázquez", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1991, 7, 1), Nacionalidade = "Espanha", NumCamisa = 17, Altura = 1.73m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
        new Jogador { Nome = "Mariano Díaz", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1993, 8, 1), Nacionalidade = "Rep. Dominicana", NumCamisa = 18, Altura = 1.80m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
        new Jogador { Nome = "Achraf Hakimi", Posicao = Posicao.Lateral, DataNascimento = new DateTime(1998, 11, 4), Nacionalidade = "Marrocos", NumCamisa = 19, Altura = 1.81m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
        new Jogador { Nome = "Jesús Vallejo", Posicao = Posicao.Zagueiro, DataNascimento = new DateTime(1997, 1, 5), Nacionalidade = "Espanha", NumCamisa = 15, Altura = 1.83m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
        new Jogador { Nome = "Luka Jovic", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1997, 12, 23), Nacionalidade = "Sérvia", NumCamisa = 18, Altura = 1.81m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
        new Jogador { Nome = "Eden Hazard", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1991, 1, 7), Nacionalidade = "Bélgica", NumCamisa = 7, Altura = 1.73m, Peso = 74m, PePreferido = PePreferido.Esquerdo, TimeId = realMadrid.Id },
        new Jogador { Nome = "Federico Valverde", Posicao = Posicao.Volante, DataNascimento = new DateTime(1998, 7, 22), Nacionalidade = "Uruguai", NumCamisa = 15, Altura = 1.82m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
        new Jogador { Nome = "Dani Ceballos", Posicao = Posicao.Volante, DataNascimento = new DateTime(1996, 8, 7), Nacionalidade = "Espanha", NumCamisa = 24, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
        new Jogador { Nome = "Marco Llorente", Posicao = Posicao.Volante, DataNascimento = new DateTime(1995, 1, 30), Nacionalidade = "Espanha", NumCamisa = 14, Altura = 1.84m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
    };
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => p.Nome, j));
                context.SaveChanges();
            }

            // 13- Comissões Técnicas e Jogadores do Milan 1989
            // Busca o time no banco
            var milan1989 = context.Times.FirstOrDefault(t => t.Nome == "Milan 1989");
            if (milan1989 != null)
            {
                // Comissão Técnica (mínimo 5 com cargos distintos)
                var comissoesTecnicas = new List<ComissaoTecnica>
    {
        new ComissaoTecnica { Nome = "Arrigo Sacchi", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1946, 4, 1), TimeId = milan1989.Id },
        new ComissaoTecnica { Nome = "Adriano Bacconi", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1950, 5, 10), TimeId = milan1989.Id },
        new ComissaoTecnica { Nome = "Giovanni Galli", Cargo = Cargo.Medico, DataNascimento = new DateTime(1962, 5, 8), TimeId = milan1989.Id },
        new ComissaoTecnica { Nome = "Luigi Cagni", Cargo = Cargo.AnalistaDeDesempenho, DataNascimento = new DateTime(1954, 11, 17), TimeId = milan1989.Id },
        new ComissaoTecnica { Nome = "Giuseppe Baresi", Cargo = Cargo.TreinadorDeGoleiros, DataNascimento = new DateTime(1960, 7, 4), TimeId = milan1989.Id },
    };
                comissoesTecnicas.ForEach(c => context.ComissoesTecnicas.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                // Jogadores (mínimo 30 com variação de posições)
                var jogadores = new List<Jogador>
    {
        // Goleiros
        new Jogador { Nome = "Sebastiano Rossi", Posicao = Posicao.Goleiro, DataNascimento = new DateTime(1964, 12, 20), Nacionalidade = "Itália", NumCamisa = 1, Altura = 1.95m, Peso = 92m, PePreferido = PePreferido.Direito, TimeId = milan1989.Id },
        new Jogador { Nome = "Stefano Tacconi", Posicao = Posicao.Goleiro, DataNascimento = new DateTime(1957, 2, 13), Nacionalidade = "Itália", NumCamisa = 12, Altura = 1.90m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = milan1989.Id },

        // Zagueiros
        new Jogador { Nome = "Franco Baresi", Posicao = Posicao.Zagueiro, DataNascimento = new DateTime(1960, 5, 8), Nacionalidade = "Itália", NumCamisa = 6, Altura = 1.74m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = milan1989.Id },
        new Jogador { Nome = "Alessandro Costacurta", Posicao = Posicao.Zagueiro, DataNascimento = new DateTime(1966, 4, 24), Nacionalidade = "Itália", NumCamisa = 5, Altura = 1.83m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = milan1989.Id },
        new Jogador { Nome = "Paolo Maldini", Posicao = Posicao.Zagueiro, DataNascimento = new DateTime(1968, 6, 26), Nacionalidade = "Itália", NumCamisa = 3, Altura = 1.86m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = milan1989.Id },

        // Laterais
        new Jogador { Nome = "Roberto Donadoni", Posicao = Posicao.Lateral, DataNascimento = new DateTime(1963, 9, 9), Nacionalidade = "Itália", NumCamisa = 7, Altura = 1.72m, Peso = 70m, PePreferido = PePreferido.Esquerdo, TimeId = milan1989.Id },
        new Jogador { Nome = "Antonio Benarrivo", Posicao = Posicao.Lateral, DataNascimento = new DateTime(1968, 7, 17), Nacionalidade = "Itália", NumCamisa = 13, Altura = 1.78m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = milan1989.Id },

        // Volantes
        new Jogador { Nome = "Donadoni Roberto", Posicao = Posicao.Volante, DataNascimento = new DateTime(1963, 9, 9), Nacionalidade = "Itália", NumCamisa = 4, Altura = 1.70m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = milan1989.Id },
        new Jogador { Nome = "Marco van Basten", Posicao = Posicao.Volante, DataNascimento = new DateTime(1964, 10, 31), Nacionalidade = "Países Baixos", NumCamisa = 9, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = milan1989.Id },

        // Meias
        new Jogador { Nome = "Ruud Gullit", Posicao = Posicao.Meia, DataNascimento = new DateTime(1962, 9, 1), Nacionalidade = "Países Baixos", NumCamisa = 10, Altura = 1.87m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = milan1989.Id },
        new Jogador { Nome = "Franco Baresi", Posicao = Posicao.Meia, DataNascimento = new DateTime(1960, 5, 8), Nacionalidade = "Itália", NumCamisa = 6, Altura = 1.74m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = milan1989.Id },

        // Atacantes
        new Jogador { Nome = "Gerd Müller", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1945, 11, 3), Nacionalidade = "Alemanha", NumCamisa = 7, Altura = 1.74m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = milan1989.Id },
        new Jogador { Nome = "Roberto Baggio", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1967, 2, 18), Nacionalidade = "Itália", NumCamisa = 10, Altura = 1.70m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = milan1989.Id },
        new Jogador { Nome = "George Weah", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1966, 10, 1), Nacionalidade = "Libéria", NumCamisa = 20, Altura = 1.80m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = milan1989.Id },

        // Outros jogadores
        new Jogador { Nome = "Alessandro Nesta", Posicao = Posicao.Zagueiro, DataNascimento = new DateTime(1976, 3, 19), Nacionalidade = "Itália", NumCamisa = 13, Altura = 1.82m, Peso = 79m, PePreferido = PePreferido.Direito, TimeId = milan1989.Id },
        new Jogador { Nome = "Marco van Basten", Posicao = Posicao.Meia, DataNascimento = new DateTime(1964, 10, 31), Nacionalidade = "Países Baixos", NumCamisa = 9, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = milan1989.Id },
        new Jogador { Nome = "Patrick Kluivert", Posicao = Posicao.Atacante, DataNascimento = new DateTime(1976, 7, 1), Nacionalidade = "Países Baixos", NumCamisa = 10, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = milan1989.Id }
    };

                // Adiciona no banco
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => p.Nome, j));
                context.SaveChanges();
            }

            // 14- Comissões Técnicas e Jogadores do Manchester United 1999
            // Busca o time no banco
            var manchester1999 = context.Times.FirstOrDefault(t => t.Nome == "Manchester United 1999");
            if (manchester1999 != null)
            {
                // Comissão Técnica (mínimo 5 com cargos distintos)
                var comissoesTecnicas = new List<ComissaoTecnica>
    {
        new ComissaoTecnica { Nome = "Sir Alex Ferguson", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1941, 12, 31), TimeId = manchester1999.Id },
        new ComissaoTecnica { Nome = "Mike Phelan", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1962, 10, 24), TimeId = manchester1999.Id },
        new ComissaoTecnica { Nome = "Les Kershaw", Cargo = Cargo.AnalistaDeDesempenho, DataNascimento = new DateTime(1950, 5, 14), TimeId = manchester1999.Id },
        new ComissaoTecnica { Nome = "Tony Coton", Cargo = Cargo.TreinadorDeGoleiros, DataNascimento = new DateTime(1963, 12, 29), TimeId = manchester1999.Id },
        new ComissaoTecnica { Nome = "Eric Steele", Cargo = Cargo.Massagista, DataNascimento = new DateTime(1955, 9, 7), TimeId = manchester1999.Id },
    };
                comissoesTecnicas.ForEach(c => context.ComissoesTecnicas.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                // Jogadores (mínimo 30 com variação de posições)
                var jogadores = new List<Jogador>
    {
       // Goleiros
        new Jogador { Nome = "Peter Schmeichel", DataNascimento = new DateTime(1963, 11, 18), Nacionalidade = "Dinamarca", Posicao = Posicao.Goleiro, NumCamisa = 1, Altura = 1.91m, Peso = 92m, PePreferido = PePreferido.Direito, TimeId = manchester1999.Id },
        new Jogador { Nome = "Raymond van der Gouw", DataNascimento = new DateTime(1963, 4, 24), Nacionalidade = "Holanda", Posicao = Posicao.Goleiro, NumCamisa = 12, Altura = 1.89m, Peso = 86m, PePreferido = PePreferido.Direito, TimeId = manchester1999.Id },
        new Jogador { Nome = "Mark Bosnich", DataNascimento = new DateTime(1972, 1, 13), Nacionalidade = "Austrália", Posicao = Posicao.Goleiro, NumCamisa = 13, Altura = 1.85m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = manchester1999.Id },

        // Defensores
        new Jogador { Nome = "Gary Neville", DataNascimento = new DateTime(1975, 2, 18), Nacionalidade = "Inglaterra", Posicao = Posicao.Lateral, NumCamisa = 2, Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = manchester1999.Id },
        new Jogador { Nome = "Jaap Stam", DataNascimento = new DateTime(1972, 7, 17), Nacionalidade = "Holanda", Posicao = Posicao.Zagueiro, NumCamisa = 6, Altura = 1.91m, Peso = 88m, PePreferido = PePreferido.Direito, TimeId = manchester1999.Id },
        new Jogador { Nome = "Ronny Johnsen", DataNascimento = new DateTime(1969, 6, 10), Nacionalidade = "Noruega", Posicao = Posicao.Zagueiro, NumCamisa = 5, Altura = 1.85m, Peso = 81m, PePreferido = PePreferido.Direito, TimeId = manchester1999.Id },
        new Jogador { Nome = "Denis Irwin", DataNascimento = new DateTime(1965, 10, 31), Nacionalidade = "Irlanda", Posicao = Posicao.Lateral, NumCamisa = 3, Altura = 1.73m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = manchester1999.Id },
        new Jogador { Nome = "David May", DataNascimento = new DateTime(1970, 6, 24), Nacionalidade = "Inglaterra", Posicao = Posicao.Zagueiro, NumCamisa = 14, Altura = 1.83m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = manchester1999.Id },
        new Jogador { Nome = "Wes Brown", DataNascimento = new DateTime(1979, 10, 13), Nacionalidade = "Inglaterra", Posicao = Posicao.Zagueiro, NumCamisa = 22, Altura = 1.85m, Peso = 79m, PePreferido = PePreferido.Direito, TimeId = manchester1999.Id },

        // Meio-Campistas
        new Jogador { Nome = "Roy Keane", DataNascimento = new DateTime(1971, 8, 10), Nacionalidade = "Irlanda", Posicao = Posicao.Volante, NumCamisa = 16, Altura = 1.80m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = manchester1999.Id },
        new Jogador { Nome = "Paul Scholes", DataNascimento = new DateTime(1974, 11, 16), Nacionalidade = "Inglaterra", Posicao = Posicao.Meia, NumCamisa = 18, Altura = 1.68m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = manchester1999.Id },
        new Jogador { Nome = "Nicky Butt", DataNascimento = new DateTime(1975, 1, 21), Nacionalidade = "Inglaterra", Posicao = Posicao.Volante, NumCamisa = 8, Altura = 1.75m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = manchester1999.Id },
        new Jogador { Nome = "Ryan Giggs", DataNascimento = new DateTime(1973, 11, 29), Nacionalidade = "País de Gales", Posicao = Posicao.MeioCampo, NumCamisa = 11, Altura = 1.79m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = manchester1999.Id },
        new Jogador { Nome = "David Beckham", DataNascimento = new DateTime(1975, 5, 2), Nacionalidade = "Inglaterra", Posicao = Posicao.MeioCampo, NumCamisa = 7, Altura = 1.83m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = manchester1999.Id },
        new Jogador { Nome = "Jesper Blomqvist", DataNascimento = new DateTime(1974, 2, 5), Nacionalidade = "Suécia", Posicao = Posicao.MeioCampo, NumCamisa = 15, Altura = 1.76m, Peso = 73m, PePreferido = PePreferido.Esquerdo, TimeId = manchester1999.Id },

        // Atacantes
        new Jogador { Nome = "Andy Cole", DataNascimento = new DateTime(1971, 10, 15), Nacionalidade = "Inglaterra", Posicao = Posicao.Atacante, NumCamisa = 9, Altura = 1.80m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = manchester1999.Id },
        new Jogador { Nome = "Dwight Yorke", DataNascimento = new DateTime(1971, 11, 3), Nacionalidade = "Trinidad e Tobago", Posicao = Posicao.Atacante, NumCamisa = 19, Altura = 1.80m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = manchester1999.Id },
        new Jogador { Nome = "Teddy Sheringham", DataNascimento = new DateTime(1966, 4, 2), Nacionalidade = "Inglaterra", Posicao = Posicao.Atacante, NumCamisa = 10, Altura = 1.85m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = manchester1999.Id },
        new Jogador { Nome = "Ole Gunnar Solskjær", DataNascimento = new DateTime(1973, 2, 26), Nacionalidade = "Noruega", Posicao = Posicao.Atacante, NumCamisa = 20, Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = manchester1999.Id },

        // Reservas e jovens para completar o elenco até 30
        new Jogador { Nome = "Phil Neville", DataNascimento = new DateTime(1977, 1, 21), Nacionalidade = "Inglaterra", Posicao = Posicao.Lateral, NumCamisa = 23, Altura = 1.80m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = manchester1999.Id },
        new Jogador { Nome = "Jonathan Greening", DataNascimento = new DateTime(1979, 1, 2), Nacionalidade = "Inglaterra", Posicao = Posicao.MeioCampo, NumCamisa = 24, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = manchester1999.Id },
        new Jogador { Nome = "John Curtis", DataNascimento = new DateTime(1978, 9, 3), Nacionalidade = "Inglaterra", Posicao = Posicao.Zagueiro, NumCamisa = 26, Altura = 1.82m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = manchester1999.Id },
        new Jogador { Nome = "Ronnie Wallwork", DataNascimento = new DateTime(1977, 9, 10), Nacionalidade = "Inglaterra", Posicao = Posicao.Volante, NumCamisa = 25, Altura = 1.83m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = manchester1999.Id },
        new Jogador { Nome = "Danny Higginbotham", DataNascimento = new DateTime(1978, 12, 29), Nacionalidade = "Inglaterra", Posicao = Posicao.Zagueiro, NumCamisa = 27, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Esquerdo, TimeId = manchester1999.Id },
        new Jogador { Nome = "Quinton Fortune", DataNascimento = new DateTime(1977, 5, 21), Nacionalidade = "África do Sul", Posicao = Posicao.MeioCampo, NumCamisa = 28, Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Esquerdo, TimeId = manchester1999.Id }
    };
                // Adiciona no banco
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => p.Nome, j));
                context.SaveChanges();


            }

            // 15- Comissão Técnica e Jogadores do Liverpool 2019
            // Busca o time no banco
            var liverpool2019 = context.Times.FirstOrDefault(t => t.Nome == "Liverpool 2019");
            if (liverpool2019 != null)
            {
                // Comissão Técnica (mínimo 5 com cargos distintos)
                var comissoesTecnicas = new List<ComissaoTecnica>
    {
        new ComissaoTecnica { Nome = "Jürgen Klopp", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1967, 6, 16), TimeId = liverpool2019.Id },
        new ComissaoTecnica { Nome = "Peter Krawietz", Cargo = Cargo.AnalistaDeDesempenho, DataNascimento = new DateTime(1972, 9, 23), TimeId = liverpool2019.Id },
        new ComissaoTecnica { Nome = "John Achterberg", Cargo = Cargo.TreinadorDeGoleiros, DataNascimento = new DateTime(1972, 2, 18), TimeId = liverpool2019.Id },
        new ComissaoTecnica { Nome = "André Schürrle", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1991, 11, 6), TimeId = liverpool2019.Id },
        new ComissaoTecnica { Nome = "Ray Houghton", Cargo = Cargo.Massagista, DataNascimento = new DateTime(1963, 1, 9), TimeId = liverpool2019.Id },
    };
                comissoesTecnicas.ForEach(c => context.ComissoesTecnicas.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                // Jogadores (mínimo 30 com variação de posições)
                var jogadores = new List<Jogador>
    {
        // Goleiros
        new Jogador { Nome = "Alisson Becker", DataNascimento = new DateTime(1992, 10, 2), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumCamisa = 1, Altura = 1.91m, Peso = 91m, PePreferido = PePreferido.Direito, TimeId = liverpool2019.Id },
        new Jogador { Nome = "Adrián", DataNascimento = new DateTime(1987, 1, 3), Nacionalidade = "Espanha", Posicao = Posicao.Goleiro, NumCamisa = 13, Altura = 1.90m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = liverpool2019.Id },
        new Jogador { Nome = "Caoimhin Kelleher", DataNascimento = new DateTime(1998, 11, 23), Nacionalidade = "Irlanda", Posicao = Posicao.Goleiro, NumCamisa = 62, Altura = 1.88m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = liverpool2019.Id },

        // Defensores
        new Jogador { Nome = "Virgil van Dijk", DataNascimento = new DateTime(1991, 7, 8), Nacionalidade = "Holanda", Posicao = Posicao.Zagueiro, NumCamisa = 4, Altura = 1.93m, Peso = 92m, PePreferido = PePreferido.Direito, TimeId = liverpool2019.Id },
        new Jogador { Nome = "Joe Gomez", DataNascimento = new DateTime(1997, 5, 23), Nacionalidade = "Inglaterra", Posicao = Posicao.Zagueiro, NumCamisa = 12, Altura = 1.88m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = liverpool2019.Id },
        new Jogador { Nome = "Joël Matip", DataNascimento = new DateTime(1991, 8, 8), Nacionalidade = "Camarões", Posicao = Posicao.Zagueiro, NumCamisa = 32, Altura = 1.95m, Peso = 90m, PePreferido = PePreferido.Direito, TimeId = liverpool2019.Id },
        new Jogador { Nome = "Andrew Robertson", DataNascimento = new DateTime(1994, 3, 11), Nacionalidade = "Escócia", Posicao = Posicao.Lateral, NumCamisa = 26, Altura = 1.78m, Peso = 64m, PePreferido = PePreferido.Esquerdo, TimeId = liverpool2019.Id },
        new Jogador { Nome = "Trent Alexander-Arnold", DataNascimento = new DateTime(1998, 10, 7), Nacionalidade = "Inglaterra", Posicao = Posicao.Lateral, NumCamisa = 66, Altura = 1.75m, Peso = 69m, PePreferido = PePreferido.Direito, TimeId = liverpool2019.Id },

        // Meio-campistas
        new Jogador { Nome = "Jordan Henderson", DataNascimento = new DateTime(1990, 6, 17), Nacionalidade = "Inglaterra", Posicao = Posicao.Volante, NumCamisa = 14, Altura = 1.82m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = liverpool2019.Id },
        new Jogador { Nome = "Fabinho", DataNascimento = new DateTime(1993, 10, 23), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumCamisa = 3, Altura = 1.88m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = liverpool2019.Id },
        new Jogador { Nome = "Georginio Wijnaldum", DataNascimento = new DateTime(1990, 11, 11), Nacionalidade = "Holanda", Posicao = Posicao.Meia, NumCamisa = 5, Altura = 1.75m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = liverpool2019.Id },
        new Jogador { Nome = "James Milner", DataNascimento = new DateTime(1986, 1, 4), Nacionalidade = "Inglaterra", Posicao = Posicao.Meia, NumCamisa = 7, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = liverpool2019.Id },
        new Jogador { Nome = "Naby Keïta", DataNascimento = new DateTime(1995, 2, 10), Nacionalidade = "Guiné", Posicao = Posicao.Meia, NumCamisa = 8, Altura = 1.72m, Peso = 64m, PePreferido = PePreferido.Direito, TimeId = liverpool2019.Id },

        // Atacantes
        new Jogador { Nome = "Mohamed Salah", DataNascimento = new DateTime(1992, 6, 15), Nacionalidade = "Egito", Posicao = Posicao.Atacante, NumCamisa = 11, Altura = 1.75m, Peso = 71m, PePreferido = PePreferido.Esquerdo, TimeId = liverpool2019.Id },
        new Jogador { Nome = "Sadio Mané", DataNascimento = new DateTime(1992, 4, 10), Nacionalidade = "Senegal", Posicao = Posicao.Atacante, NumCamisa = 10, Altura = 1.74m, Peso = 69m, PePreferido = PePreferido.Direito, TimeId = liverpool2019.Id },
        new Jogador { Nome = "Roberto Firmino", DataNascimento = new DateTime(1991, 10, 2), Nacionalidade = "Brasil", Posicao = Posicao.Atacante, NumCamisa = 9, Altura = 1.81m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = liverpool2019.Id },
        new Jogador { Nome = "Divock Origi", DataNascimento = new DateTime(1995, 4, 18), Nacionalidade = "Bélgica", Posicao = Posicao.Atacante, NumCamisa = 27, Altura = 1.85m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = liverpool2019.Id },
        new Jogador { Nome = "Xherdan Shaqiri", DataNascimento = new DateTime(1991, 10, 10), Nacionalidade = "Suíça", Posicao = Posicao.Atacante, NumCamisa = 23, Altura = 1.69m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = liverpool2019.Id },

        // Adicionais (para completar 30 jogadores, jogadores da base e reservas)
        new Jogador { Nome = "Curtis Jones", DataNascimento = new DateTime(2001, 1, 30), Nacionalidade = "Inglaterra", Posicao = Posicao.MeioCampo, NumCamisa = 48, Altura = 1.85m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = liverpool2019.Id },
        new Jogador { Nome = "Harvey Elliott", DataNascimento = new DateTime(2003, 4, 4), Nacionalidade = "Inglaterra", Posicao = Posicao.MeioCampo, NumCamisa = 67, Altura = 1.70m, Peso = 62m, PePreferido = PePreferido.Esquerdo, TimeId = liverpool2019.Id },
        new Jogador { Nome = "Nathaniel Phillips", DataNascimento = new DateTime(1997, 3, 21), Nacionalidade = "Inglaterra", Posicao = Posicao.Zagueiro, NumCamisa = 47, Altura = 1.90m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = liverpool2019.Id },
        new Jogador { Nome = "Yasser Larouci", DataNascimento = new DateTime(2001, 1, 1), Nacionalidade = "Argélia", Posicao = Posicao.Lateral, NumCamisa = 46, Altura = 1.76m, Peso = 70m, PePreferido = PePreferido.Esquerdo, TimeId = liverpool2019.Id },
        new Jogador { Nome = "Sepp van den Berg", DataNascimento = new DateTime(2001, 12, 20), Nacionalidade = "Holanda", Posicao = Posicao.Zagueiro, NumCamisa = 72, Altura = 1.89m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = liverpool2019.Id },

        // Reservas e mais jovens
        new Jogador { Nome = "Adam Lewis", DataNascimento = new DateTime(1999, 11, 8), Nacionalidade = "Inglaterra", Posicao = Posicao.Lateral, NumCamisa = 49, Altura = 1.78m, Peso = 71m, PePreferido = PePreferido.Esquerdo, TimeId = liverpool2019.Id },
        new Jogador { Nome = "Ki-Jana Hoever", DataNascimento = new DateTime(2002, 1, 18), Nacionalidade = "Holanda", Posicao = Posicao.Zagueiro, NumCamisa = 51, Altura = 1.83m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = liverpool2019.Id }
    };

                // Adiciona no banco
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => p.Nome, j));
                context.SaveChanges();
            }

            // 16- Comissões Técnicas e Jogadores do Bayern de Munique 2020
            var bayern2020 = context.Times.FirstOrDefault(t => t.Nome == "Bayern de Munique 2020");
            if (bayern2020 != null)
            {
                var comissoesTecnicas = new List<ComissaoTecnica>
    {
        new ComissaoTecnica { Nome = "Hansi Flick", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1965, 2, 24), TimeId = bayern2020.Id },
        new ComissaoTecnica { Nome = "Toni Tapalović", Cargo = Cargo.TreinadorDeGoleiros, DataNascimento = new DateTime(1980, 10, 10), TimeId = bayern2020.Id },
        new ComissaoTecnica { Nome = "Danny Röhl", Cargo = Cargo.AnalistaDeDesempenho, DataNascimento = new DateTime(1989, 4, 28), TimeId = bayern2020.Id },
        new ComissaoTecnica { Nome = "Andreas Kornmayer", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1975, 3, 12), TimeId = bayern2020.Id },
        new ComissaoTecnica { Nome = "Christian Wörns", Cargo = Cargo.Massagista, DataNascimento = new DateTime(1972, 5, 10), TimeId = bayern2020.Id },
    };
                comissoesTecnicas.ForEach(c => context.ComissoesTecnicas.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
    {
               // Goleiros
        new Jogador { Nome = "Manuel Neuer", DataNascimento = new DateTime(1986, 3, 27), Nacionalidade = "Alemanha", Posicao = Posicao.Goleiro, NumCamisa = 1, Altura = 1.93m, Peso = 92m, PePreferido = PePreferido.Direito, TimeId = bayern2020.Id },
        new Jogador { Nome = "Sven Ulreich", DataNascimento = new DateTime(1988, 8, 3), Nacionalidade = "Alemanha", Posicao = Posicao.Goleiro, NumCamisa = 26, Altura = 1.92m, Peso = 87m, PePreferido = PePreferido.Direito, TimeId = bayern2020.Id },
        new Jogador { Nome = "Ron-Thorben Hoffmann", DataNascimento = new DateTime(1999, 4, 4), Nacionalidade = "Alemanha", Posicao = Posicao.Goleiro, NumCamisa = 39, Altura = 1.90m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = bayern2020.Id },

        // Defensores
        new Jogador { Nome = "David Alaba", DataNascimento = new DateTime(1992, 6, 24), Nacionalidade = "Áustria", Posicao = Posicao.Zagueiro, NumCamisa = 27, Altura = 1.80m, Peso = 76m, PePreferido = PePreferido.Esquerdo, TimeId = bayern2020.Id },
        new Jogador { Nome = "Jerome Boateng", DataNascimento = new DateTime(1988, 9, 3), Nacionalidade = "Alemanha", Posicao = Posicao.Zagueiro, NumCamisa = 17, Altura = 1.92m, Peso = 90m, PePreferido = PePreferido.Direito, TimeId = bayern2020.Id },
        new Jogador { Nome = "Benjamin Pavard", DataNascimento = new DateTime(1996, 3, 28), Nacionalidade = "França", Posicao = Posicao.Lateral, NumCamisa = 5, Altura = 1.86m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = bayern2020.Id },
        new Jogador { Nome = "Alphonso Davies", DataNascimento = new DateTime(2000, 11, 2), Nacionalidade = "Canadá", Posicao = Posicao.Lateral, NumCamisa = 19, Altura = 1.83m, Peso = 75m, PePreferido = PePreferido.Esquerdo, TimeId = bayern2020.Id },
        new Jogador { Nome = "Lucas Hernández", DataNascimento = new DateTime(1996, 2, 14), Nacionalidade = "França", Posicao = Posicao.Zagueiro, NumCamisa = 21, Altura = 1.84m, Peso = 79m, PePreferido = PePreferido.Esquerdo, TimeId = bayern2020.Id },

        // Meio-campistas
        new Jogador { Nome = "Joshua Kimmich", DataNascimento = new DateTime(1995, 2, 8), Nacionalidade = "Alemanha", Posicao = Posicao.Volante, NumCamisa = 6, Altura = 1.77m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = bayern2020.Id },
        new Jogador { Nome = "Leon Goretzka", DataNascimento = new DateTime(1995, 2, 6), Nacionalidade = "Alemanha", Posicao = Posicao.Volante, NumCamisa = 18, Altura = 1.89m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = bayern2020.Id },
        new Jogador { Nome = "Thiago Alcântara", DataNascimento = new DateTime(1991, 4, 11), Nacionalidade = "Espanha", Posicao = Posicao.Meia, NumCamisa = 6, Altura = 1.74m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = bayern2020.Id },
        new Jogador { Nome = "Corentin Tolisso", DataNascimento = new DateTime(1994, 8, 3), Nacionalidade = "França", Posicao = Posicao.Meia, NumCamisa = 24, Altura = 1.81m, Peso = 81m, PePreferido = PePreferido.Direito, TimeId = bayern2020.Id },
        new Jogador { Nome = "Javi Martínez", DataNascimento = new DateTime(1988, 9, 2), Nacionalidade = "Espanha", Posicao = Posicao.Volante, NumCamisa = 8, Altura = 1.90m, Peso = 81m, PePreferido = PePreferido.Direito, TimeId = bayern2020.Id },

        // Atacantes
        new Jogador { Nome = "Robert Lewandowski", DataNascimento = new DateTime(1988, 8, 21), Nacionalidade = "Polônia", Posicao = Posicao.Atacante, NumCamisa = 9, Altura = 1.85m, Peso = 81m, PePreferido = PePreferido.Direito, TimeId = bayern2020.Id },
        new Jogador { Nome = "Thomas Müller", DataNascimento = new DateTime(1989, 9, 13), Nacionalidade = "Alemanha", Posicao = Posicao.Atacante, NumCamisa = 25, Altura = 1.86m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = bayern2020.Id },
        new Jogador { Nome = "Serge Gnabry", DataNascimento = new DateTime(1995, 7, 14), Nacionalidade = "Alemanha", Posicao = Posicao.Atacante, NumCamisa = 22, Altura = 1.76m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = bayern2020.Id },
        new Jogador { Nome = "Kingsley Coman", DataNascimento = new DateTime(1996, 6, 13), Nacionalidade = "França", Posicao = Posicao.Atacante, NumCamisa = 29, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = bayern2020.Id },
        new Jogador { Nome = "Ivan Perisic", DataNascimento = new DateTime(1989, 2, 2), Nacionalidade = "Croácia", Posicao = Posicao.Atacante, NumCamisa = 14, Altura = 1.86m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = bayern2020.Id },

        // Suplentes e jovens
        new Jogador { Nome = "Joshua Zirkzee", DataNascimento = new DateTime(2001, 5, 22), Nacionalidade = "Holanda", Posicao = Posicao.Atacante, NumCamisa = 35, Altura = 1.93m, Peso = 84m, PePreferido = PePreferido.Direito, TimeId = bayern2020.Id },
        new Jogador { Nome = "Michael Cuisance", DataNascimento = new DateTime(1999, 8, 16), Nacionalidade = "França", Posicao = Posicao.Meia, NumCamisa = 11, Altura = 1.81m, Peso = 74m, PePreferido = PePreferido.Esquerdo, TimeId = bayern2020.Id },
        new Jogador { Nome = "Sarpreet Singh", DataNascimento = new DateTime(1999, 2, 20), Nacionalidade = "Nova Zelândia", Posicao = Posicao.Meia, NumCamisa = 28, Altura = 1.74m, Peso = 67m, PePreferido = PePreferido.Esquerdo, TimeId = bayern2020.Id },
        new Jogador { Nome = "Chris Richards", DataNascimento = new DateTime(2000, 3, 28), Nacionalidade = "EUA", Posicao = Posicao.Zagueiro, NumCamisa = 46, Altura = 1.88m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = bayern2020.Id },
        new Jogador { Nome = "Bright Arrey-Mbi", DataNascimento = new DateTime(2003, 3, 26), Nacionalidade = "Alemanha", Posicao = Posicao.Zagueiro, NumCamisa = 43, Altura = 1.87m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = bayern2020.Id },

        // Complemento
        new Jogador { Nome = "Lars Lukas Mai", DataNascimento = new DateTime(2000, 3, 31), Nacionalidade = "Alemanha", Posicao = Posicao.Zagueiro, NumCamisa = 15, Altura = 1.90m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = bayern2020.Id },
        new Jogador { Nome = "Jann-Fiete Arp", DataNascimento = new DateTime(2000, 1, 6), Nacionalidade = "Alemanha", Posicao = Posicao.Atacante, NumCamisa = 15, Altura = 1.84m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = bayern2020.Id }
    };
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => p.Nome, j));
                context.SaveChanges();
            }

            // 17- Comissões Técnicas e Jogadores do Ajax 1971
            var ajax1971 = context.Times.FirstOrDefault(t => t.Nome == "Ajax 1971");
            if (ajax1971 != null)
            {
                var comissoesTecnicas = new List<ComissaoTecnica>
    {
        new ComissaoTecnica { Nome = "Rinus Michels", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1928, 2, 9), TimeId = ajax1971.Id },
        new ComissaoTecnica { Nome = "Bobby Haarms", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1934, 3, 8), TimeId = ajax1971.Id },
        new ComissaoTecnica { Nome = "Jan Mulder", Cargo = Cargo.AnalistaDeDesempenho, DataNascimento = new DateTime(1945, 5, 4), TimeId = ajax1971.Id },
        new ComissaoTecnica { Nome = "Hein Delsen", Cargo = Cargo.TreinadorDeGoleiros, DataNascimento = new DateTime(1930, 1, 17), TimeId = ajax1971.Id },
        new ComissaoTecnica { Nome = "Cor van der Hart", Cargo = Cargo.Massagista, DataNascimento = new DateTime(1928, 1, 25), TimeId = ajax1971.Id },
    };
                comissoesTecnicas.ForEach(c => context.ComissoesTecnicas.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
    {
       new Jogador { Nome = "Johan Cruyff", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 14, DataNascimento = new DateTime(1947, 4, 25), Nacionalidade = "Holanda", Altura = 1.80m, Peso = 70m, TimeId = ajax1971.Id },
        new Jogador { Nome = "Piet Keizer", Posicao = Posicao.Atacante, PePreferido = PePreferido.Esquerdo, NumCamisa = 11, DataNascimento = new DateTime(1943, 6, 14), Nacionalidade = "Holanda", Altura = 1.77m, Peso = 72m, TimeId = ajax1971.Id },
        new Jogador { Nome = "Johan Neeskens", Posicao = Posicao.Volante, PePreferido = PePreferido.Direito, NumCamisa = 6, DataNascimento = new DateTime(1951, 9, 15), Nacionalidade = "Holanda", Altura = 1.78m, Peso = 73m, TimeId = ajax1971.Id },
        new Jogador { Nome = "Barry Hulshoff", Posicao = Posicao.Zagueiro, PePreferido = PePreferido.Direito, NumCamisa = 5, DataNascimento = new DateTime(1946, 9, 30), Nacionalidade = "Holanda", Altura = 1.85m, Peso = 78m, TimeId = ajax1971.Id },
        new Jogador { Nome = "Ruud Krol", Posicao = Posicao.Lateral, PePreferido = PePreferido.Esquerdo, NumCamisa = 3, DataNascimento = new DateTime(1949, 3, 24), Nacionalidade = "Holanda", Altura = 1.80m, Peso = 75m, TimeId = ajax1971.Id },
        new Jogador { Nome = "Horst Blankenburg", Posicao = Posicao.Zagueiro, PePreferido = PePreferido.Direito, NumCamisa = 4, DataNascimento = new DateTime(1947, 7, 10), Nacionalidade = "Alemanha", Altura = 1.83m, Peso = 76m, TimeId = ajax1971.Id },
        new Jogador { Nome = "Heinz Stuy", Posicao = Posicao.Goleiro, PePreferido = PePreferido.Direito, NumCamisa = 1, DataNascimento = new DateTime(1945, 2, 6), Nacionalidade = "Holanda", Altura = 1.84m, Peso = 79m, TimeId = ajax1971.Id },
        new Jogador { Nome = "Arie Haan", Posicao = Posicao.MeioCampo, PePreferido = PePreferido.Direito, NumCamisa = 8, DataNascimento = new DateTime(1948, 11, 16), Nacionalidade = "Holanda", Altura = 1.84m, Peso = 75m, TimeId = ajax1971.Id },
        new Jogador { Nome = "Sjaak Swart", Posicao = Posicao.Meia, PePreferido = PePreferido.Direito, NumCamisa = 7, DataNascimento = new DateTime(1938, 7, 3), Nacionalidade = "Holanda", Altura = 1.74m, Peso = 70m, TimeId = ajax1971.Id },
        new Jogador { Nome = "Gerrie Mühren", Posicao = Posicao.Meia, PePreferido = PePreferido.Direito, NumCamisa = 10, DataNascimento = new DateTime(1946, 2, 2), Nacionalidade = "Holanda", Altura = 1.76m, Peso = 71m, TimeId = ajax1971.Id },
    new Jogador { Nome = "Dick van Dijk", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 9, DataNascimento = new DateTime(1946, 2, 15), Nacionalidade = "Holanda", Altura = 1.84m, Peso = 78m, TimeId = ajax1971.Id },
    new Jogador { Nome = "Gerry Mühren", Posicao = Posicao.MeioCampo, PePreferido = PePreferido.Direito, NumCamisa = 12, DataNascimento = new DateTime(1946, 2, 2), Nacionalidade = "Holanda", Altura = 1.76m, Peso = 71m, TimeId = ajax1971.Id },
    new Jogador { Nome = "Wim Suurbier", Posicao = Posicao.Lateral, PePreferido = PePreferido.Direito, NumCamisa = 2, DataNascimento = new DateTime(1945, 1, 16), Nacionalidade = "Holanda", Altura = 1.78m, Peso = 73m, TimeId = ajax1971.Id },
    new Jogador { Nome = "Tommy Söderberg", Posicao = Posicao.Volante, PePreferido = PePreferido.Direito, NumCamisa = 13, DataNascimento = new DateTime(1948, 7, 17), Nacionalidade = "Suécia", Altura = 1.81m, Peso = 74m, TimeId = ajax1971.Id },
    new Jogador { Nome = "Theo van Duivenbode", Posicao = Posicao.Defensor, PePreferido = PePreferido.Direito, NumCamisa = 15, DataNascimento = new DateTime(1943, 11, 1), Nacionalidade = "Holanda", Altura = 1.83m, Peso = 77m, TimeId = ajax1971.Id },
    new Jogador { Nome = "Klaas Nuninga", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 16, DataNascimento = new DateTime(1940, 11, 7), Nacionalidade = "Holanda", Altura = 1.80m, Peso = 75m, TimeId = ajax1971.Id },
    new Jogador { Nome = "Inge Danielsson", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 17, DataNascimento = new DateTime(1941, 6, 14), Nacionalidade = "Suécia", Altura = 1.83m, Peso = 76m, TimeId = ajax1971.Id },
    new Jogador { Nome = "Jan Mulder", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 18, DataNascimento = new DateTime(1945, 5, 4), Nacionalidade = "Holanda", Altura = 1.85m, Peso = 78m, TimeId = ajax1971.Id },
    new Jogador { Nome = "Barry van Galen", Posicao = Posicao.MeioCampo, PePreferido = PePreferido.Esquerdo, NumCamisa = 19, DataNascimento = new DateTime(1970, 4, 4), Nacionalidade = "Holanda", Altura = 1.76m, Peso = 73m, TimeId = ajax1971.Id },
    new Jogador { Nome = "Jan Jongbloed", Posicao = Posicao.Goleiro, PePreferido = PePreferido.Direito, NumCamisa = 20, DataNascimento = new DateTime(1940, 11, 25), Nacionalidade = "Holanda", Altura = 1.83m, Peso = 75m, TimeId = ajax1971.Id },

    // Adicionando reservas para compor o elenco
    new Jogador { Nome = "Wim Jansen", Posicao = Posicao.Volante, PePreferido = PePreferido.Direito, NumCamisa = 21, DataNascimento = new DateTime(1946, 10, 28), Nacionalidade = "Holanda", Altura = 1.74m, Peso = 70m, TimeId = ajax1971.Id },
    new Jogador { Nome = "Piet Schrijvers", Posicao = Posicao.Goleiro, PePreferido = PePreferido.Direito, NumCamisa = 22, DataNascimento = new DateTime(1946, 12, 15), Nacionalidade = "Holanda", Altura = 1.87m, Peso = 80m, TimeId = ajax1971.Id },
    new Jogador { Nome = "Simon Tahamata", Posicao = Posicao.Meia, PePreferido = PePreferido.Esquerdo, NumCamisa = 23, DataNascimento = new DateTime(1956, 5, 26), Nacionalidade = "Holanda", Altura = 1.70m, Peso = 65m, TimeId = ajax1971.Id },
    new Jogador { Nome = "Peter Boeve", Posicao = Posicao.Lateral, PePreferido = PePreferido.Esquerdo, NumCamisa = 24, DataNascimento = new DateTime(1957, 3, 14), Nacionalidade = "Holanda", Altura = 1.79m, Peso = 72m, TimeId = ajax1971.Id },
    new Jogador { Nome = "Ronald Spelbos", Posicao = Posicao.Zagueiro, PePreferido = PePreferido.Direito, NumCamisa = 25, DataNascimento = new DateTime(1954, 7, 8), Nacionalidade = "Holanda", Altura = 1.83m, Peso = 76m, TimeId = ajax1971.Id },
    new Jogador { Nome = "Tonny Bruins Slot", Posicao = Posicao.MeioCampo, PePreferido = PePreferido.Direito, NumCamisa = 26, DataNascimento = new DateTime(1947, 4, 1), Nacionalidade = "Holanda", Altura = 1.82m, Peso = 74m, TimeId = ajax1971.Id },
    new Jogador { Nome = "Frank Arnesen", Posicao = Posicao.Meia, PePreferido = PePreferido.Direito, NumCamisa = 27, DataNascimento = new DateTime(1956, 9, 30), Nacionalidade = "Dinamarca", Altura = 1.78m, Peso = 72m, TimeId = ajax1971.Id },
    new Jogador { Nome = "Tscheu La Ling", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 28, DataNascimento = new DateTime(1956, 1, 6), Nacionalidade = "Holanda", Altura = 1.76m, Peso = 73m, TimeId = ajax1971.Id },
    new Jogador { Nome = "Frank Rijkaard", Posicao = Posicao.Zagueiro, PePreferido = PePreferido.Direito, NumCamisa = 29, DataNascimento = new DateTime(1962, 9, 30), Nacionalidade = "Holanda", Altura = 1.87m, Peso = 79m, TimeId = ajax1971.Id },
    new Jogador { Nome = "Rob Witschge", Posicao = Posicao.MeioCampo, PePreferido = PePreferido.Esquerdo, NumCamisa = 30, DataNascimento = new DateTime(1966, 8, 22), Nacionalidade = "Holanda", Altura = 1.78m, Peso = 72m, TimeId = ajax1971.Id }
};
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => p.Nome, j));
                context.SaveChanges();
            }

            // 18- Comissões Técnicas e Jogadores do Boca Juniors 2000
            var boca2000 = context.Times.FirstOrDefault(t => t.Nome == "Boca Juniors 2000");
            if (boca2000 != null)
            {
                var comissoesTecnicas = new List<ComissaoTecnica>
    {
        new ComissaoTecnica { Nome = "Carlos Bianchi", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1949, 4, 26), TimeId = boca2000.Id },
        new ComissaoTecnica { Nome = "Julio Santella", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1943, 3, 20), TimeId = boca2000.Id },
        new ComissaoTecnica { Nome = "Rubén Cousillas", Cargo = Cargo.TreinadorDeGoleiros, DataNascimento = new DateTime(1957, 5, 9), TimeId = boca2000.Id },
        new ComissaoTecnica { Nome = "Hugo Ibarra", Cargo = Cargo.AnalistaDeDesempenho, DataNascimento = new DateTime(1974, 4, 1), TimeId = boca2000.Id },
        new ComissaoTecnica { Nome = "Mauricio Serna", Cargo = Cargo.Massagista, DataNascimento = new DateTime(1968, 1, 22), TimeId = boca2000.Id },
    };
                comissoesTecnicas.ForEach(c => context.ComissoesTecnicas.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
    {
        // Goleiros
    new Jogador { Nome = "Oscar Córdoba", Posicao = Posicao.Goleiro, PePreferido = PePreferido.Direito, NumCamisa = 1, DataNascimento = new DateTime(1970, 2, 3), Nacionalidade = "Colômbia", Altura = 1.83m, Peso = 80m, TimeId = boca2000.Id },
    new Jogador { Nome = "Roberto Abbondanzieri", Posicao = Posicao.Goleiro, PePreferido = PePreferido.Direito, NumCamisa = 12, DataNascimento = new DateTime(1972, 8, 19), Nacionalidade = "Argentina", Altura = 1.83m, Peso = 81m, TimeId = boca2000.Id },

    // Zagueiros e Defensores
    new Jogador { Nome = "Walter Samuel", Posicao = Posicao.Zagueiro, PePreferido = PePreferido.Esquerdo, NumCamisa = 6, DataNascimento = new DateTime(1978, 3, 23), Nacionalidade = "Argentina", Altura = 1.83m, Peso = 80m, TimeId = boca2000.Id },
    new Jogador { Nome = "Jorge Bermúdez", Posicao = Posicao.Zagueiro, PePreferido = PePreferido.Direito, NumCamisa = 2, DataNascimento = new DateTime(1971, 6, 18), Nacionalidade = "Colômbia", Altura = 1.85m, Peso = 82m, TimeId = boca2000.Id },
    new Jogador { Nome = "Hugo Ibarra", Posicao = Posicao.Lateral, PePreferido = PePreferido.Direito, NumCamisa = 4, DataNascimento = new DateTime(1974, 4, 1), Nacionalidade = "Argentina", Altura = 1.72m, Peso = 72m, TimeId = boca2000.Id },
    new Jogador { Nome = "Aníbal Matellán", Posicao = Posicao.Zagueiro, PePreferido = PePreferido.Direito, NumCamisa = 3, DataNascimento = new DateTime(1977, 5, 8), Nacionalidade = "Argentina", Altura = 1.80m, Peso = 76m, TimeId = boca2000.Id },
    new Jogador { Nome = "Carlos Rodríguez", Posicao = Posicao.Lateral, PePreferido = PePreferido.Esquerdo, NumCamisa = 13, DataNascimento = new DateTime(1974, 11, 5), Nacionalidade = "Argentina", Altura = 1.76m, Peso = 74m, TimeId = boca2000.Id },

    // Volantes / Meio-Campo
    new Jogador { Nome = "Sebastián Battaglia", Posicao = Posicao.Volante, PePreferido = PePreferido.Direito, NumCamisa = 5, DataNascimento = new DateTime(1980, 11, 8), Nacionalidade = "Argentina", Altura = 1.78m, Peso = 76m, TimeId = boca2000.Id },
    new Jogador { Nome = "Diego Cagna", Posicao = Posicao.MeioCampo, PePreferido = PePreferido.Direito, NumCamisa = 8, DataNascimento = new DateTime(1970, 4, 19), Nacionalidade = "Argentina", Altura = 1.80m, Peso = 76m, TimeId = boca2000.Id },
    new Jogador { Nome = "Mauricio Serna", Posicao = Posicao.Volante, PePreferido = PePreferido.Direito, NumCamisa = 20, DataNascimento = new DateTime(1968, 1, 22), Nacionalidade = "Colômbia", Altura = 1.70m, Peso = 70m, TimeId = boca2000.Id },
    new Jogador { Nome = "Alfredo Cascini", Posicao = Posicao.Volante, PePreferido = PePreferido.Direito, NumCamisa = 17, DataNascimento = new DateTime(1972, 9, 1), Nacionalidade = "Argentina", Altura = 1.74m, Peso = 73m, TimeId = boca2000.Id },
    new Jogador { Nome = "Cristian Traverso", Posicao = Posicao.Volante, PePreferido = PePreferido.Direito, NumCamisa = 23, DataNascimento = new DateTime(1971, 4, 17), Nacionalidade = "Argentina", Altura = 1.77m, Peso = 75m, TimeId = boca2000.Id },

    // Meias
    new Jogador { Nome = "Juan Román Riquelme", Posicao = Posicao.Meia, PePreferido = PePreferido.Direito, NumCamisa = 10, DataNascimento = new DateTime(1978, 6, 24), Nacionalidade = "Argentina", Altura = 1.82m, Peso = 79m, TimeId = boca2000.Id },
    new Jogador { Nome = "Marcelo Delgado", Posicao = Posicao.Meia, PePreferido = PePreferido.Esquerdo, NumCamisa = 18, DataNascimento = new DateTime(1973, 3, 24), Nacionalidade = "Argentina", Altura = 1.74m, Peso = 72m, TimeId = boca2000.Id },
    new Jogador { Nome = "Nicolás Burdisso", Posicao = Posicao.Zagueiro, PePreferido = PePreferido.Direito, NumCamisa = 14, DataNascimento = new DateTime(1981, 4, 12), Nacionalidade = "Argentina", Altura = 1.83m, Peso = 78m, TimeId = boca2000.Id },

    // Atacantes
    new Jogador { Nome = "Martín Palermo", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 9, DataNascimento = new DateTime(1973, 11, 7), Nacionalidade = "Argentina", Altura = 1.87m, Peso = 85m, TimeId = boca2000.Id },
    new Jogador { Nome = "Guillermo Barros Schelotto", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 7, DataNascimento = new DateTime(1973, 5, 4), Nacionalidade = "Argentina", Altura = 1.71m, Peso = 70m, TimeId = boca2000.Id },
    new Jogador { Nome = "Antonio Barijho", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 19, DataNascimento = new DateTime(1977, 6, 18), Nacionalidade = "Argentina", Altura = 1.78m, Peso = 82m, TimeId = boca2000.Id },
    new Jogador { Nome = "Carlos Tévez", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 32, DataNascimento = new DateTime(1984, 2, 5), Nacionalidade = "Argentina", Altura = 1.70m, Peso = 72m, TimeId = boca2000.Id },

    // Reservas adicionais para completar 30
    new Jogador { Nome = "Gastón Sessa", Posicao = Posicao.Goleiro, PePreferido = PePreferido.Direito, NumCamisa = 21, DataNascimento = new DateTime(1973, 1, 15), Nacionalidade = "Argentina", Altura = 1.85m, Peso = 83m, TimeId = boca2000.Id },
    new Jogador { Nome = "Matías Arce", Posicao = Posicao.Lateral, PePreferido = PePreferido.Direito, NumCamisa = 26, DataNascimento = new DateTime(1979, 5, 1), Nacionalidade = "Argentina", Altura = 1.75m, Peso = 74m, TimeId = boca2000.Id },
    new Jogador { Nome = "Héctor Bracamonte", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 27, DataNascimento = new DateTime(1978, 2, 16), Nacionalidade = "Argentina", Altura = 1.90m, Peso = 84m, TimeId = boca2000.Id },
    new Jogador { Nome = "Carlos Marinelli", Posicao = Posicao.Meia, PePreferido = PePreferido.Esquerdo, NumCamisa = 28, DataNascimento = new DateTime(1982, 3, 14), Nacionalidade = "Argentina", Altura = 1.78m, Peso = 73m, TimeId = boca2000.Id },
    new Jogador { Nome = "Lucas Castromán", Posicao = Posicao.Meia, PePreferido = PePreferido.Direito, NumCamisa = 29, DataNascimento = new DateTime(1980, 10, 2), Nacionalidade = "Argentina", Altura = 1.80m, Peso = 75m, TimeId = boca2000.Id },
    new Jogador { Nome = "Fabián Vargas", Posicao = Posicao.Volante, PePreferido = PePreferido.Direito, NumCamisa = 30, DataNascimento = new DateTime(1980, 4, 17), Nacionalidade = "Colômbia", Altura = 1.78m, Peso = 73m, TimeId = boca2000.Id }
};
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => p.Nome, j));
                context.SaveChanges();
            }

            // 19- Comissões Técnicas e Jogadores do Peñarol 1960
            var penarol1960 = context.Times.FirstOrDefault(t => t.Nome == "Peñarol 1960");
            if (penarol1960 != null)
            {
                var comissoesTecnicas = new List<ComissaoTecnica>
    {
        new ComissaoTecnica { Nome = "Roberto Scarone", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1917, 6, 16), TimeId = penarol1960.Id },
        new ComissaoTecnica { Nome = "Luis Varela", Cargo = Cargo.TreinadorDeGoleiros, DataNascimento = new DateTime(1930, 2, 10), TimeId = penarol1960.Id },
        new ComissaoTecnica { Nome = "Eduardo García", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1929, 11, 1), TimeId = penarol1960.Id },
        new ComissaoTecnica { Nome = "Walter Gómez", Cargo = Cargo.AnalistaDeDesempenho, DataNascimento = new DateTime(1927, 12, 12), TimeId = penarol1960.Id },
        new ComissaoTecnica { Nome = "Héctor Silva", Cargo = Cargo.Massagista, DataNascimento = new DateTime(1933, 9, 5), TimeId = penarol1960.Id },
    };
                comissoesTecnicas.ForEach(c => context.ComissoesTecnicas.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
    {
       new Jogador { Nome = "Luis Maidana", Posicao = Posicao.Goleiro, PePreferido = PePreferido.Direito, NumCamisa = 1, DataNascimento = new DateTime(1935, 3, 1), Nacionalidade = "Uruguai", Altura = 1.83m, Peso = 79m, TimeId = penarol1960.Id },
    new Jogador { Nome = "William Martínez", Posicao = Posicao.Zagueiro, PePreferido = PePreferido.Direito, NumCamisa = 2, DataNascimento = new DateTime(1928, 1, 13), Nacionalidade = "Uruguai", Altura = 1.78m, Peso = 76m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Salvador", Posicao = Posicao.Lateral, PePreferido = PePreferido.Direito, NumCamisa = 3, DataNascimento = new DateTime(1934, 5, 5), Nacionalidade = "Uruguai", Altura = 1.76m, Peso = 74m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Pedro Rocha", Posicao = Posicao.Meia, PePreferido = PePreferido.Direito, NumCamisa = 10, DataNascimento = new DateTime(1942, 12, 3), Nacionalidade = "Uruguai", Altura = 1.79m, Peso = 75m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Alberto Spencer", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 9, DataNascimento = new DateTime(1937, 12, 6), Nacionalidade = "Equador", Altura = 1.80m, Peso = 78m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Ladislao Mazurkiewicz", Posicao = Posicao.Goleiro, PePreferido = PePreferido.Direito, NumCamisa = 12, DataNascimento = new DateTime(1945, 2, 14), Nacionalidade = "Uruguai", Altura = 1.81m, Peso = 78m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Carlos Paz", Posicao = Posicao.Goleiro, PePreferido = PePreferido.Direito, NumCamisa = 22, DataNascimento = new DateTime(1935, 7, 12), Nacionalidade = "Uruguai", Altura = 1.82m, Peso = 80m, TimeId = penarol1960.Id },

    // Defensores
    new Jogador { Nome = "Néstor Gonçalves", Posicao = Posicao.Volante, PePreferido = PePreferido.Direito, NumCamisa = 5, DataNascimento = new DateTime(1936, 4, 27), Nacionalidade = "Uruguai", Altura = 1.80m, Peso = 76m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Roberto Matosas", Posicao = Posicao.Zagueiro, PePreferido = PePreferido.Direito, NumCamisa = 4, DataNascimento = new DateTime(1940, 5, 11), Nacionalidade = "Uruguai", Altura = 1.81m, Peso = 78m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Píndaro Rodríguez", Posicao = Posicao.Lateral, PePreferido = PePreferido.Direito, NumCamisa = 6, DataNascimento = new DateTime(1939, 6, 20), Nacionalidade = "Uruguai", Altura = 1.76m, Peso = 72m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Juan Lezcano", Posicao = Posicao.Zagueiro, PePreferido = PePreferido.Direito, NumCamisa = 13, DataNascimento = new DateTime(1937, 6, 5), Nacionalidade = "Paraguai", Altura = 1.79m, Peso = 77m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Óscar Aguirregaray", Posicao = Posicao.Lateral, PePreferido = PePreferido.Esquerdo, NumCamisa = 15, DataNascimento = new DateTime(1959, 10, 25), Nacionalidade = "Uruguai", Altura = 1.75m, Peso = 73m, TimeId = penarol1960.Id },

    // Meias
    new Jogador { Nome = "Julio Abbadie", Posicao = Posicao.Meia, PePreferido = PePreferido.Direito, NumCamisa = 8, DataNascimento = new DateTime(1930, 9, 10), Nacionalidade = "Uruguai", Altura = 1.75m, Peso = 73m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Héctor Silva", Posicao = Posicao.Meia, PePreferido = PePreferido.Direito, NumCamisa = 16, DataNascimento = new DateTime(1940, 4, 14), Nacionalidade = "Uruguai", Altura = 1.78m, Peso = 75m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Carlos Borges", Posicao = Posicao.Meia, PePreferido = PePreferido.Esquerdo, NumCamisa = 7, DataNascimento = new DateTime(1932, 1, 14), Nacionalidade = "Uruguai", Altura = 1.77m, Peso = 74m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Hernando Etcheverry", Posicao = Posicao.Meia, PePreferido = PePreferido.Direito, NumCamisa = 17, DataNascimento = new DateTime(1934, 3, 3), Nacionalidade = "Uruguai", Altura = 1.76m, Peso = 72m, TimeId = penarol1960.Id },
    new Jogador { Nome = "José Sasía", Posicao = Posicao.Meia, PePreferido = PePreferido.Esquerdo, NumCamisa = 11, DataNascimento = new DateTime(1933, 12, 27), Nacionalidade = "Uruguai", Altura = 1.78m, Peso = 74m, TimeId = penarol1960.Id },

    // Atacantes
    new Jogador { Nome = "Luis Cubilla", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 19, DataNascimento = new DateTime(1940, 3, 28), Nacionalidade = "Uruguai", Altura = 1.72m, Peso = 70m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Carlos Linazza", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 20, DataNascimento = new DateTime(1938, 9, 11), Nacionalidade = "Uruguai", Altura = 1.74m, Peso = 72m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Julio César Cortés", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 18, DataNascimento = new DateTime(1941, 3, 29), Nacionalidade = "Uruguai", Altura = 1.70m, Peso = 69m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Juan Joya", Posicao = Posicao.Atacante, PePreferido = PePreferido.Esquerdo, NumCamisa = 21, DataNascimento = new DateTime(1934, 2, 25), Nacionalidade = "Peru", Altura = 1.73m, Peso = 71m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Héctor Rodríguez", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 23, DataNascimento = new DateTime(1936, 8, 3), Nacionalidade = "Uruguai", Altura = 1.76m, Peso = 74m, TimeId = penarol1960.Id },

    // Reservas extras
    new Jogador { Nome = "Mario González", Posicao = Posicao.Zagueiro, PePreferido = PePreferido.Direito, NumCamisa = 24, DataNascimento = new DateTime(1937, 4, 2), Nacionalidade = "Uruguai", Altura = 1.78m, Peso = 75m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Juan Vicente Lezcano", Posicao = Posicao.Zagueiro, PePreferido = PePreferido.Direito, NumCamisa = 25, DataNascimento = new DateTime(1937, 6, 5), Nacionalidade = "Paraguai", Altura = 1.80m, Peso = 77m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Manuel Keosseian", Posicao = Posicao.Meia, PePreferido = PePreferido.Direito, NumCamisa = 26, DataNascimento = new DateTime(1953, 8, 17), Nacionalidade = "Uruguai", Altura = 1.74m, Peso = 71m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Eduardo Rodríguez", Posicao = Posicao.Volante, PePreferido = PePreferido.Direito, NumCamisa = 27, DataNascimento = new DateTime(1937, 9, 14), Nacionalidade = "Uruguai", Altura = 1.76m, Peso = 74m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Luis Ubiña", Posicao = Posicao.Lateral, PePreferido = PePreferido.Esquerdo, NumCamisa = 28, DataNascimento = new DateTime(1939, 8, 30), Nacionalidade = "Uruguai", Altura = 1.75m, Peso = 73m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Julio González", Posicao = Posicao.Goleiro, PePreferido = PePreferido.Direito, NumCamisa = 29, DataNascimento = new DateTime(1938, 11, 17), Nacionalidade = "Uruguai", Altura = 1.82m, Peso = 78m, TimeId = penarol1960.Id },
    new Jogador { Nome = "Nelson Díaz", Posicao = Posicao.Lateral, PePreferido = PePreferido.Direito, NumCamisa = 30, DataNascimento = new DateTime(1937, 12, 2), Nacionalidade = "Uruguai", Altura = 1.73m, Peso = 70m, TimeId = penarol1960.Id }
};
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => p.Nome, j));
                context.SaveChanges();
            }

            // 20- Comissões Técnicas e Jogadores do Flamengo 1981
            var flamengo1981 = context.Times.FirstOrDefault(t => t.Nome == "Flamengo 1981");
            if (flamengo1981 != null)
            {
                var comissoesTecnicas = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Carlo Alberto Torres", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1948, 7, 12), TimeId = flamengo1981.Id },
                    new ComissaoTecnica { Nome = "Cláudio Coutinho", Cargo = Cargo.Auxiliar, DataNascimento = new DateTime(1943, 11, 27), TimeId = flamengo1981.Id },
                    new ComissaoTecnica { Nome = "Jayme de Almeida", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1965, 9, 11), TimeId = flamengo1981.Id },
                    new ComissaoTecnica { Nome = "Ricardo Rocha", Cargo = Cargo.AnalistaDeDesempenho, DataNascimento = new DateTime(1966, 12, 29), TimeId = flamengo1981.Id },
                    new ComissaoTecnica { Nome = "Márcio Nascimento", Cargo = Cargo.Medico, DataNascimento = new DateTime(1955, 3, 21), TimeId = flamengo1981.Id }
                };
                            comissoesTecnicas.ForEach(c => context.ComissoesTecnicas.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                            context.SaveChanges();

                            var jogadores = new List<Jogador>
                {
                    // Goleiros
                    new Jogador { Nome = "Fernando", Posicao = Posicao.Goleiro, PePreferido = PePreferido.Direito, NumCamisa = 1, DataNascimento = new DateTime(1945, 8, 7), Nacionalidade = "Brasil", Altura = 1.88m, Peso = 80m, TimeId = flamengo1981.Id },
                    new Jogador { Nome = "Nélson", Posicao = Posicao.Goleiro, PePreferido = PePreferido.Direito, NumCamisa = 12, DataNascimento = new DateTime(1952, 5, 6), Nacionalidade = "Brasil", Altura = 1.85m, Peso = 79m, TimeId = flamengo1981.Id },

                    // Defensores
                    new Jogador { Nome = "Leandro", Posicao = Posicao.Lateral, PePreferido = PePreferido.Direito, NumCamisa = 2, DataNascimento = new DateTime(1960, 10, 7), Nacionalidade = "Brasil", Altura = 1.73m, Peso = 70m, TimeId = flamengo1981.Id },
                    new Jogador { Nome = "Júnior", Posicao = Posicao.Lateral, PePreferido = PePreferido.Esquerdo, NumCamisa = 6, DataNascimento = new DateTime(1954, 6, 29), Nacionalidade = "Brasil", Altura = 1.78m, Peso = 74m, TimeId = flamengo1981.Id },
                    new Jogador { Nome = "Mozer", Posicao = Posicao.Zagueiro, PePreferido = PePreferido.Direito, NumCamisa = 3, DataNascimento = new DateTime(1961, 8, 10), Nacionalidade = "Brasil", Altura = 1.85m, Peso = 80m, TimeId = flamengo1981.Id },
                    new Jogador { Nome = "Aírton", Posicao = Posicao.Zagueiro, PePreferido = PePreferido.Direito, NumCamisa = 4, DataNascimento = new DateTime(1960, 9, 8), Nacionalidade = "Brasil", Altura = 1.83m, Peso = 82m, TimeId = flamengo1981.Id },
                    new Jogador { Nome = "Rodolfo Rodrigues", Posicao = Posicao.Zagueiro, PePreferido = PePreferido.Direito, NumCamisa = 5, DataNascimento = new DateTime(1959, 1, 16), Nacionalidade = "Brasil", Altura = 1.84m, Peso = 79m, TimeId = flamengo1981.Id },

                    // Meio-campistas
                    new Jogador { Nome = "Zico", Posicao = Posicao.MeioCampo, PePreferido = PePreferido.Direito, NumCamisa = 10, DataNascimento = new DateTime(1953, 3, 3), Nacionalidade = "Brasil", Altura = 1.72m, Peso = 72m, TimeId = flamengo1981.Id },
                    new Jogador { Nome = "Tita", Posicao = Posicao.MeioCampo, PePreferido = PePreferido.Direito, NumCamisa = 8, DataNascimento = new DateTime(1961, 9, 7), Nacionalidade = "Brasil", Altura = 1.74m, Peso = 73m, TimeId = flamengo1981.Id },
                    new Jogador { Nome = "Andrade", Posicao = Posicao.MeioCampo, PePreferido = PePreferido.Direito, NumCamisa = 6, DataNascimento = new DateTime(1962, 2, 1), Nacionalidade = "Brasil", Altura = 1.80m, Peso = 76m, TimeId = flamengo1981.Id },
                    new Jogador { Nome = "Adílio", Posicao = Posicao.MeioCampo, PePreferido = PePreferido.Esquerdo, NumCamisa = 7, DataNascimento = new DateTime(1960, 6, 7), Nacionalidade = "Brasil", Altura = 1.78m, Peso = 75m, TimeId = flamengo1981.Id },

                    // Atacantes
                    new Jogador { Nome = "Nunes", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 9, DataNascimento = new DateTime(1954, 11, 18), Nacionalidade = "Brasil", Altura = 1.79m, Peso = 78m, TimeId = flamengo1981.Id },
                    new Jogador { Nome = "Lico", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 11, DataNascimento = new DateTime(1961, 2, 25), Nacionalidade = "Brasil", Altura = 1.77m, Peso = 76m, TimeId = flamengo1981.Id },
                    new Jogador { Nome = "Carlos Alberto", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 15, DataNascimento = new DateTime(1959, 12, 15), Nacionalidade = "Brasil", Altura = 1.78m, Peso = 77m, TimeId = flamengo1981.Id },
                    new Jogador { Nome = "Doval", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 16, DataNascimento = new DateTime(1948, 7, 7), Nacionalidade = "Argentina", Altura = 1.75m, Peso = 71m, TimeId = flamengo1981.Id },
                    new Jogador { Nome = "Lima", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 17, DataNascimento = new DateTime(1952, 6, 3), Nacionalidade = "Brasil", Altura = 1.76m, Peso = 75m, TimeId = flamengo1981.Id },

                    // Reservas
                    new Jogador { Nome = "Bebeto", Posicao = Posicao.Atacante, PePreferido = PePreferido.Direito, NumCamisa = 18, DataNascimento = new DateTime(1964, 2, 16), Nacionalidade = "Brasil", Altura = 1.79m, Peso = 78m, TimeId = flamengo1981.Id },
                    new Jogador { Nome = "Ailton Lira", Posicao = Posicao.MeioCampo, PePreferido = PePreferido.Direito, NumCamisa = 19, DataNascimento = new DateTime(1957, 10, 23), Nacionalidade = "Brasil", Altura = 1.74m, Peso = 73m, TimeId = flamengo1981.Id },
                    new Jogador { Nome = "Jorginho", Posicao = Posicao.Lateral, PePreferido = PePreferido.Direito, NumCamisa = 20, DataNascimento = new DateTime(1964, 12, 27), Nacionalidade = "Brasil", Altura = 1.73m, Peso = 71m, TimeId = flamengo1981.Id },
                    new Jogador { Nome = "Toninho", Posicao = Posicao.MeioCampo, PePreferido = PePreferido.Direito, NumCamisa = 21, DataNascimento = new DateTime(1959, 7, 2), Nacionalidade = "Brasil", Altura = 1.75m, Peso = 74m, TimeId = flamengo1981.Id },
                    new Jogador { Nome = "Marcio Nascimento", Posicao = Posicao.Goleiro, PePreferido = PePreferido.Direito, NumCamisa = 22, DataNascimento = new DateTime(1961, 3, 15), Nacionalidade = "Brasil", Altura = 1.87m, Peso = 80m, TimeId = flamengo1981.Id }
                };
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => p.Nome, j));
                context.SaveChanges();
            }
        }
    }
}

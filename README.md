# 🏆 Liga Futebol

Sistema web para gerenciamento de uma liga fictícia de futebol, permitindo o cadastro e visualização de times, jogadores, comissão técnica, partidas e estatísticas.

## 🚀 Tecnologias Utilizadas

- ASP.NET Framework (Web Forms / MVC)
- Entity Framework
- SQL Server
- Bootstrap (tema escuro)
- HTML/CSS/JavaScript

## 📋 Funcionalidades

- Cadastro de times de futebol
- Adição de jogadores com posição, pé preferido, estatísticas e mais
- Gestão de comissão técnica com cargos distintos
- Geração e acompanhamento de partidas
- Tabelas de classificação e resultados por rodada
- Interface com abas: Visão Geral, Partidas, Classificação etc.

## 📁 Estrutura do Projeto

Liga_Futebol │ ├── App_Start/ # Configurações iniciais da aplicação ├── Controllers/ # Controllers da aplicação MVC ├── Models/ # Entidades do Entity Framework ├── Views/ # Páginas da aplicação (Razor ou Web Forms) ├── Scripts/ # Scripts JS (Bootstrap, jQuery, etc.) ├── Content/ # Arquivos estáticos (CSS, imagens, etc.) ├── Global.asax # Arquivo de inicialização global ├── Web.config # Configurações da aplicação └── Liga_Futebol.sln # Solução do Visual Studio


## 🛠️ Como Executar

1. Clone este repositório:
   ```bash
   git clone
2. Abra o arquivo Liga_Futebol.sln no Visual Studio.

3. Configure a string de conexão com seu banco SQL Server em Web.config.

4. Execute as migrações do Entity Framework (se aplicável) ou gere o banco manualmente.

5. Pressione F5 ou clique em Iniciar no Visual Studio.

📊 Dados Fictícios
O projeto pode ser populado com dados fictícios de:

20 times com 30 jogadores cada

5 membros de comissão técnica por time (cargos distintos)

Partidas com resultados simulados e estatísticas por jogador

🔮 Possibilidades Futuras
Autenticação de usuários

Edição em tempo real via SignalR

Dashboard com gráficos

Ranking de artilharia e assistências

📌 Requisitos
Visual Studio 2019 ou superior

.NET Framework 4.7+

SQL Server LocalDB ou versão completa

Entity Framework instalado

Desenvolvido para fins de estudo e prática de ASP.NET e Entity Framework ⚽

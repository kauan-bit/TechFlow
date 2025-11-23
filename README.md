# TechFlow – Sistema de HelpDesk (Aplicação Desktop em C#)

O TechFlow é um sistema de HelpDesk desenvolvido em C# Windows Forms, utilizando uma arquitetura organizada com Data Access Object (DAO), Models e Views.  
O sistema integra-se ao SQL Server e oferece controle completo de chamados, setores, técnicos, usuários, auditorias e histórico de atendimento.

---

## Índice

- Sobre o Sistema
- Funcionalidades
- Arquitetura do Projeto
- Tecnologias Utilizadas
- Pré-requisitos
- Como Clonar o Repositório
- Configuração do Banco de Dados
- Tabela HistoricoChamado Corrigida
- Como Executar o Projeto
- Estrutura de Pastas
- Contribuição
- Licença

---

## Sobre o Sistema

O TechFlow foi projetado para empresas que necessitam de um sistema eficiente para:

- Gerenciar chamados técnicos  
- Registrar atendimentos  
- Controlar setor e categorias  
- Atribuir técnicos  
- Manter histórico detalhado  
- Gerar auditorias internas  

O sistema é simples, moderno e leve, adequado tanto para pequenas quanto grandes equipes.

---

## Funcionalidades

- Cadastro de Usuários  
- Cadastro de Técnicos  
- Cadastro de Setores  
- Cadastro de Categorias  
- Abertura de Chamados  
- Histórico completo de atendimento  
- Dashboard informativo  
- Relatórios internos  
- Auditoria de ações  
- Login com controle de acesso  

---

## Arquitetura do Projeto
TechFlow/
├── Data/
│ ├── Db.cs
│ ├── UsuarioDAO.cs
│ ├── TecnicoDAO.cs
│ ├── SetorDAO.cs
│ ├── CategoriaDAO.cs
│ ├── AuditoriaDAO.cs
│ └── RelatorioDAO.cs
│
├── Models/
│ ├── Usuario.cs
│ ├── Tecnico.cs
│ ├── Setor.cs
│ ├── Categoria.cs
│ ├── Auditoria.cs
│ └── RelatorioModel.cs
│
├── Views/
│ ├── Login.cs
│ ├── Dashboard.cs
│ ├── FrmUsuario.cs
│ ├── FrmTecnico.cs
│ ├── FrmSetor.cs
│ ├── FrmCategoria.cs
│ ├── FrmAuditoria.cs
│ └── FrmRelatorio.cs
│
├── App.config
├── Program.cs
└── TechFlow.csproj

---

## Tecnologias Utilizadas

- Linguagem: **C#**
- Framework: **.NET Framework / .NET 6+**
- Interface: **Windows Forms (WinForms)**
- Banco: **SQL Server**
- Acesso ao banco: **ADO.NET**
- Arquitetura: **DAO Pattern**

---

## Pré-requisitos

### Sistema
- Windows 10 ou superior

### Ferramentas Necessárias
- Visual Studio 2019 ou 2022  
- Workload: *Desenvolvimento para Desktop .NET*  
- SQL Server (Express, Developer ou LocalDB)  
- SQL Server Management Studio (SSMS)  
- .NET Framework compatível com o projeto  

---

## Como Clonar o Repositório

```bash
git clone https://github.com/SEU-USUARIO/TechFlow.git

## Abrir no Visual Studio
- TechFlow.sln


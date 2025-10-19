# Projeto Cadastro de Clientes (ASP.NET Core Razor Pages + PostgreSQL)

Este projeto é uma aplicação web simples, construída com ASP.NET Core Razor Pages, que implementa um CRUD (Create, Read, Update, Delete) completo para o gerenciamento de clientes, utilizando o Entity Framework Core e o PostgreSQL como banco de dados.

**Objetivo:** Praticar a configuração de um ambiente de desenvolvimento .NET Core com um banco de dados relacional robusto.

## 🚀 Tecnologias

* **Framework:** ASP.NET Core 9.0 (ou a versão que você está usando)
* **Linguagem:** C#
* **Banco de Dados:** PostgreSQL
* **ORM:** Entity Framework Core
* **Provedor EF:** Npgsql.EntityFrameworkCore.PostgreSQL
* **Estilo:** Bootstrap

## ⚙️ Pré-requisitos

Para rodar este projeto, você precisa ter instalado:

* [.NET 9.0 SDK](https://dotnet.microsoft.com/download) (ou a versão do seu projeto, ex: `net9.0`)
* [Git](https://git-scm.com/downloads)
* **Servidor PostgreSQL** (Rodando localmente, geralmente na porta 5432)
* [dotnet-ef CLI](https://docs.microsoft.com/en-us/ef/core/cli/dotnet) (instalação global: `dotnet tool install --global dotnet-ef`)

## 🛠️ Configuração e Execução

### 1. Clonar o Repositório

```bash
git clone https://github.com/NaelNunes/users-crud-with-aspnet
cd ProjetoCadastroUsuarios
```

### 2. Configurar Conexão com Banco de Dados

#### 1. Crie um banco de dados vazio no PostgreSQL
#### 2. Abra o arquivo appsettings.json e configure a ConnectionStrings com suas credenciais de acesso:

```bash
"ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=SEU_DB;Username=SEU_USUARIO;Password=SUA_SENHA"
}
```

### 3. Aplicar as Migrações do Banco de Dados

```bash
# Aplica todas as migrações (incluindo a 'InitialPostgresCreate')
dotnet ef database update
```

### 4. Inicializar aplicação
```bash
dotnet run
```

### 5. Abrir na Web

A aplicação estará disponível em seu navegador (geralmente http://localhost:5000 ou https://localhost:7000).

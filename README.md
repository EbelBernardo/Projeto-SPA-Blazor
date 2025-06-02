# Projeto SPA Blazor

## Descrição

Este é um projeto Single Page Application (SPA) desenvolvido em **Blazor** com **.NET 8** e **C#**. O sistema implementa um CRUD completo para gerenciamento de categorias e produtos, utilizando Entity Framework Core para acesso a dados.

---

## Funcionalidades

- CRUD de Categorias
- CRUD de Produtos
- Validação de formulários com Data Annotations
- Navegação SPA sem recarregar a página
- Conexão com banco de dados via Entity Framework Core
- Tratamento básico de erros

---

## Tecnologias Utilizadas

- [.NET 8](https://dotnet.microsoft.com/en-us/)
- [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
- C#
- Bootstrap 5

---

## Como Rodar o Projeto

1. Clone este repositório:
   ```bash
   git clone https://github.com/EbelBernardo/Projeto-SPA-Blazor.git

2. Navegue até a pasta do projeto
   ```bash
   cd Projeto-SPA-Blazor

3. Restaure os pacotes NuGet
   ```bash
   dotnet restore

4. Execute as migrações do Entity Framework Core para criar o banco de dados:
   ```bash
   dotnet ef database update

5. Rode o projeto
   ```bash
   dotnet run

## Estrutura do Projeto
    ```bash
    /Pages           - Componentes Razor das páginas
    /Data            - Contexto do banco e classes de migração
    /Models          - Classes do domínio (Category, Product, etc)
    /wwwroot         - Arquivos estáticos (CSS, JS)
    /Program.cs      - Configuração e inicialização da aplicação

## Contribuições
Contribuições são bem vindas! Sinta-se à vontade para abrir issues ou pull requests.

## Autor
Bernardo Ebel <br>
[GitHub](https://github.com/EbelBernardo) | [LinkedIn](https://www.linkedin.com/in/bernardo-ebel-743831303/)

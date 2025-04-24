# 📚 Library System

Esse projeto foi desenvolvido com objetivo de criar uma API REST para um sistema de biblioteca, usando .NET, com uma estrutura bem organizada e autenticação JWT.

---

## 💡 Sobre o projeto

A ideia foi seguir princípios de**Clean Architecture**, separando bem as responsabilidades entre as camadas. A estrutura ficou assim:

- **Domain**: entidades e interfaces base  
- **Application**: regras de negócio e DTOs  
- **Infrastructure**: repositórios, contexto EF Core e serviços  
- **API**: controllers e toda a configuração da aplicação

No momento, a API usa um banco de dados InMemory, mas está pronta para ser conectada a um banco real — basta ajustar a configuração do DbContext.

---

## ⚙️ Tecnologias e ferramentas

- .NET 9  
- ASP.NET Core  
- Entity Framework Core (InMemory)  
- AutoMapper  
- JWT Bearer Authentication  
- Swagger (para documentação e testes)  
- Clean Architecture  
- Git + GitHub  

---

## 🔐 Autenticação

A autenticação foi implementada com **JWT**. Para acessar as rotas protegidas (como criar, editar ou deletar livros), siga os passos:

1. Registre um novo usuário em /api/Auth/register
2. Faça login em /api/Auth/login
3. Copie o token JWT retornado
4. Clique no botão **Authorize** no Swagger e cole o token no formato:  
Bearer "seu_token_aqui"

---

## 🧪 Testando com o Swagger

1. Rode a aplicação abrindo o bash na pasta da API e digitando:

"dotnet run"

2. Acesse no navegador:
   
https://localhost:xxxxx/swagger

Adaptando de acordo com o localhost mostrado.


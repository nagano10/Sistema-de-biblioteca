# 📚 Library System
Projeto desenvolvido com proposta de criar uma API REST para um sistema de biblioteca, utilizando .NET com uma arquitetura bem organizada e autenticação JWT.

---

## 💡 Sobre o projeto

Seguindo as ideias de Clean Architecture e boas práticas, para melhor organização e resposabilidade entre as camadas, o projeto foi distribuído da seguinte forma:

- Domain: entidades e interfaces base
- Application: regras de negócio e DTOs
- Infrastructure: repositórios, contexto EF Core e serviços
- API: controllers e configuração geral

Apesar de usar um banco em memória local, é possível integrá-la a um banco de dados real, somente trocando a configuração do DbContext.

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

A autenticação foi feita usando JWT. Para acessar rotas protegidas (como criar ou editar um livro), é necessário:

1. Registrar um usuário usando o "register"
2. Fazer login em "login"
3. Copiar o token JWT retornado e usar no botão "Authorize" do Swagger

---

## 🧪 Testando no Swagger

1. Rode a aplicação com "dotnet run"
2. Acesse o localhost

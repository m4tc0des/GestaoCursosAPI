# Course Management System API

[![.NET 8](https://img.shields.io/badge/.NET-8.0-512bd4)](https://dotnet.microsoft.com/download/dotnet/8.0)
[![MySQL](https://img.shields.io/badge/MySQL-8.0-blue)](https://www.mysql.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## Sobre o Projeto

Uma API robusta para gestão de cursos, estudantes e matrículas, desenvolvida para demonstrar práticas avançadas no ecossistema .NET. O foco principal é a **escalabilidade**, **testabilidade** e **separação de responsabilidades**.

Este projeto foi construído utilizando os princípios de **Domain-Driven Design (DDD)**, garantindo que as regras de negócio sejam o coração da aplicação.

---

## Arquitetura e Tecnologias

A solução segue os princípios da **Clean Architecture**, dividida em:

- **`GestaoCursos.Domain`**: O núcleo (Core). Contém entidades, enums e interfaces. Independente de frameworks.
- **`GestaoCursos.Application`**: Fluxo da aplicação. Contém serviços, DTOs, validadores e mapeamentos.
- **`GestaoCursos.Infrastructure`**: Detalhes técnicos. EF Core, Repositórios e Migrations.
- **`GestaoCursos.Api`**: Camada de entrada. Controllers, Injeção de Dependência e Swagger.

### Tech Stack & Main Packages

- **Linguagem:** C# (.NET 8)
- **Banco de Dados:** MySQL (via **Pomelo.EntityFrameworkCore.MySql**)
- **ORM:** Entity Framework Core
- **Mapeamento:** **Mapster** (Alta performance)
- **Validação:** **FluentValidation.AspNetCore**
- **Injeção de Dependência:** Microsoft.Extensions.DependencyInjection
- **Documentação:** Swagger/OpenAPI

---

## Como Executar

### Pré-requisitos
- .NET 8 SDK
- MySQL Server

### Passo a Passo

1. **Clone o repositório:**
   ```bash
   git clone [https://github.com/m4tc0des/GestaoCursos.git](https://github.com/m4tc0des/GestaoCursos.git)

# Course Management System API

[![.NET 8](https://img.shields.io/badge/.NET-8.0-512bd4)](https://dotnet.microsoft.com/download/dotnet/8.0)
[![MySQL](https://img.shields.io/badge/MySQL-8.0-blue)](https://www.mysql.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## Sobre o Projeto

Uma API robusta para gestão de cursos, estudantes e matrículas, desenvolvida para demonstrar práticas avançadas no ecossistema .NET. O foco principal é a **escalabilidade**, **testabilidade** e **separação de responsabilidades**.

Este projeto utiliza **Domain-Driven Design (DDD)** para proteger as regras de negócio e garantir um código desacoplado e de fácil manutenção.

---

## Diferenciais Técnicos Implementados

O projeto foi evoluído para incluir padrões de mercado utilizados em sistemas de alta criticidade:

- **Soft Delete (Exclusão Lógica)**: Implementação de remoção de registros sem perda de dados históricos, utilizando o controle do campo `Active`.
- **Granular Patch Updates**: Endpoints específicos para alteração de propriedades sensíveis (Preço e Data de Criação), evitando vulnerabilidades de *Mass Assignment*.
- **Fluent Mappings**: Configuração avançada do banco de dados via `IEntityTypeConfiguration`, garantindo precisão decimal (18,2) para valores monetários e tipos de data otimizados (`DATE` no MySQL).
- **Inversão de Dependência**: Interfaces de repositório localizadas no `Domain`, garantindo que o núcleo da aplicação seja independente de detalhes de infraestrutura.

---

## Arquitetura e Tecnologias

A solução segue os princípios da **Clean Architecture**, dividida em:

- **`GestaoCursos.Domain`**: O núcleo (Core). Contém entidades com lógica encapsulada, interfaces e contratos.
- **`GestaoCursos.Application`**: Orquestração. Contém serviços, DTOs (Requests/Responses), validadores e lógica de mapeamento.
- **`GestaoCursos.Infrastructure`**: Detalhes técnicos. Implementação do EF Core, Repositórios, Migrations e Mapeamentos Fluentes.
- **`GestaoCursos.Api`**: Camada de entrada. Controllers RESTful, Configuração de Injeção de Dependência e Documentação.

### Tech Stack & Main Packages

- **Linguagem:** C# (.NET 8)
- **Banco de Dados:** MySQL (via **Pomelo.EntityFrameworkCore.MySql**)
- **ORM:** Entity Framework Core
- **Mapeamento:** **Mapster** (Estratégia de alta performance)
- **Validação:** **FluentValidation**
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
   cd GestaoCursos

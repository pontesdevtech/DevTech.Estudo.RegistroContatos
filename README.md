# 📚 DevTech Registro de Contatos

![.NET](https://img.shields.io/badge/.NET-9.0-purple?style=flat&logo=dotnet)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-Core-blue?style=flat&logo=ef)
![SQL Server](https://img.shields.io/badge/SQL%20Server-DB-red?style=flat&logo=microsoftsqlserver)
![Swagger](https://img.shields.io/badge/Swagger-UI-green?style=flat&logo=swagger)

> Projeto criado para estudo e aperfeiçoamento de arquitetura em APIs Minimal usando C# .NET 9, Entity Framework Core e SQL Server, modelando um registro de contatos vinculado a pessoas.

---

## ✨ Sobre o projeto

O **DevTech Registro de Contatos** é um sistema que exemplifica uma arquitetura limpa e modular para o registro de pessoas e seus contatos. O projeto tem como objetivo principal:

✅ Demonstrar o uso de **Minimal APIs** com separação de responsabilidades.  
✅ Implementar persistência de dados usando **Entity Framework Core**.  
✅ Utilizar boas práticas de `DbContext` (injeção de dependência, migrations e repository pattern).  
✅ Expor documentação interativa via **Swagger**.

---

## ⚙️ Funcionalidades implementadas

✅ **Pessoa**
- Cadastro de pessoa com nome, CPF e data de nascimento.
- Listagem completa ou filtrada por data de nascimento.
- Atualização e exclusão.

✅ **Contato**
- Cadastro de contatos vinculados à pessoa (telefone, email etc).
- Listagem de contatos.
- Vinculação por `PessoaId`.

✅ **Swagger**
- Interface automática para testar os endpoints REST.

---

## 🗂️ Estrutura do projeto

```plaintext
DevTech.RegistroContatos
├── DevTech.RegistroContatos.Api
│   ├── Program.cs             // Configuração da API e DI
│   └── Endpoints/             // Minimal API endpoints separados
│       ├── PessoaEndpoint.cs
│       └── ContatoEndpoint.cs
│
├── DevTech.RegistroContatos.Dados
│   ├── Contextos/Contexto.cs  // DbContext
│   └── Repositorios/          // Repositórios implementando os contratos
│
├── DevTech.RegistroContatos.Dominio
│   ├── Entidades/             // Modelos Pessoa e Contato
│   └── Interfaces/            // IRepositorio<T>
│
└── DevTech.RegistroContatos.Dominio.Enums
    └── ETipoContato.cs        // Enum de tipos de contato
```

---

## 💾 Como executar localmente

### 🚀 Pré-requisitos
- [.NET 9.0 SDK (Preview)](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- SQL Server (local ou Docker)

### ⚙️ Configuração do banco
Altere o `appsettings.json` ou `appsettings.Development.json` para colocar sua connection string:

```json
{
  "ConnectionStrings": {
    "dev": "Server=localhost;Database=RegistroContatosDB;User Id=sa;Password=SuaSenha123;"
  }
}
```

### 🗄️ Executar migrations
Abra o terminal na pasta do projeto e rode:

```bash
dotnet ef database update --startup-project ../DevTech.RegistroContatos.Api
```

### ▶️ Rodar a API
Na pasta `DevTech.RegistroContatos.Api`:

```bash
dotnet run
```

A API será inicializada em `https://localhost:7127` e abrirá o Swagger automaticamente.

---

## 🔍 Principais endpoints

> Documentados via Swagger em `https://localhost:7127/swagger`

### 📌 Pessoas
- `GET /pessoas`  
  Lista todas as pessoas cadastradas.

- `GET /pessoas/data_nascimento?dtInicio=2024-01-01&dtTermino=2024-12-31`  
  Lista pessoas filtrando por data de nascimento entre `dtInicio` e `dtTermino`.

- `POST /pessoas`  
  Cria uma nova pessoa.

- `PUT /pessoas`  
  Atualiza dados de uma pessoa existente.

- `DELETE /pessoas/{id}`  
  Remove uma pessoa.

### 📌 Contatos
- `GET /contatos`  
  Lista todos os contatos.

- `POST /contatos`  
  Cria um novo contato vinculado a uma pessoa.

---

## 🚀 Tecnologias utilizadas

| Tecnologia | Descrição |
|------------|-----------|
| **.NET 9 (Preview)** | Backend em C# com Minimal APIs |
| **Entity Framework Core** | ORM para persistência no SQL Server |
| **SQL Server** | Banco relacional |
| **Swagger (Swashbuckle)** | UI para documentação e testes dos endpoints |

---

## 💡 Possíveis melhorias futuras

✅ Implementar **DTOs** para evitar ciclos de referência e controlar a serialização.  
✅ Adicionar testes unitários e integração com xUnit / FluentAssertions.  
✅ Configurar logs estruturados com Serilog.  
✅ Implementar cache para listagens.  
✅ Criar imagens Docker e `docker-compose` para subida rápida.

---

## 👤 Autor

> Desenvolvido por **Tiago Pontes**  
> [![GitHub](https://img.shields.io/badge/GitHub-pontesdevtech-black?logo=github)](https://github.com/pontesdevtech)

---

## 📝 Licença

Este projeto está licenciado sob a [MIT License](LICENSE).

---

## ⭐ Contribuição

Se quiser sugerir melhorias ou estudar junto, fique à vontade para abrir uma issue ou um pull request. 🚀

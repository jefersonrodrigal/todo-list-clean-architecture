# 🧾 TodoList API — Clean Architecture

![.NET](https://img.shields.io/badge/.NET-10.0-purple)
![Build](https://img.shields.io/badge/build-passing-brightgreen)
![Architecture](https://img.shields.io/badge/architecture-clean--architecture-orange)

Projeto de exemplo implementando uma API de gerenciamento de tarefas (**Todo List**) utilizando:

* .NET
* ASP.NET Core (Controllers)
* Entity Framework Core
* SQLite
* Clean Architecture

---

## 🧱 Arquitetura

O projeto segue os princípios da **Clean Architecture**, separando responsabilidades em camadas:

```
          ┌──────────────────────────┐
          │        WebApi            │
          │ (Controllers / HTTP)     │
          └──────────┬───────────────┘
                     │
          ┌──────────▼───────────────┐
          │      Application         │
          │   (Use Cases / DTOs)     │
          └──────────┬───────────────┘
                     │
          ┌──────────▼───────────────┐
          │        Domain            │
          │   (Entities / Rules)     │
          └──────────┬───────────────┘
                     │
          ┌──────────▼───────────────┐
          │     Infrastructure       │
          │ (EF Core / Database)     │
          └──────────────────────────┘
```

### 📦 Camadas

* **Domain** → Entidades e regras de negócio
* **Application** → Use Cases (casos de uso)
* **Infrastructure** → Acesso a dados (EF Core, SQLite)
* **WebApi** → Controllers e configuração da API

---

## 🚀 Tecnologias

* .NET
* ASP.NET Core
* EF Core
* SQLite
* Swagger

---

## ▶️ Como rodar o projeto

### 1. Clonar repositório

```bash
git clone https://github.com/seu-usuario/todolist-clean-architecture.git
cd todolist-clean-architecture
```

---

### 2. Restaurar dependências

```bash
dotnet restore
```

---

### 3. Instalar ferramenta do EF (se necessário)

```bash
dotnet tool install --global dotnet-ef
```

---

### 4. Criar banco de dados

```bash
dotnet ef migrations add InitialCreate -p Infrastructure -s WebApi
dotnet ef database update -p Infrastructure -s WebApi
```

---

### 5. Executar aplicação

```bash
dotnet run --project WebApi
```

---

## 📡 Endpoints

### 🔹 Listar todos

```http
GET /api/todo
```

---

### 🔹 Criar tarefa

```http
POST /api/todo
Content-Type: application/json

{
  "title": "Minha tarefa"
}
```

---

## 🧪 Exemplos com cURL

### Criar tarefa

```bash
curl -X POST http://localhost:5000/api/todo \
  -H "Content-Type: application/json" \
  -d '{
    "title": "Estudar Clean Architecture"
  }'
```

### Listar tarefas

```bash
curl http://localhost:5000/api/todo
```

---

## 📮 Postman

### Criar request

* Método: POST
* URL: [http://localhost:5000/api/todo](http://localhost:5000/api/todo)
* Body (JSON):

```json
{
  "title": "Aprender .NET"
}
```

### Listar

* Método: GET
* URL: [http://localhost:5000/api/todo](http://localhost:5000/api/todo)

---

## 📘 Exemplo de resposta

```json
[
  {
    "id": "guid",
    "title": "Minha tarefa",
    "isCompleted": false
  }
]
```

---

## 🧠 Conceitos aplicados

* Clean Architecture
* Separation of Concerns
* Dependency Injection
* Repository Pattern
* Use Case Pattern

---


## 👨‍💻 Autor

Desenvolvido por Jeferson Almeida

# 🧾 TodoList API — Clean Architecture

Projeto de exemplo implementando uma API de gerenciamento de tarefas (**Todo List**) utilizando:

- .NET 10
- ASP.NET Core (Controllers)
- Entity Framework Core
- SQLite
- Clean Architecture

---

## 🧱 Arquitetura

O projeto segue os princípios da **Clean Architecture**, separando responsabilidades em camadas:

```
TodoListCleanArchitecture
├── Domain
├── Application
├── Infrastructure
└── WebApi
```

### 📦 Camadas

- **Domain** → Entidades e regras de negócio
- **Application** → Use Cases (casos de uso)
- **Infrastructure** → Acesso a dados (EF Core, SQLite)
- **WebApi** → Controllers e configuração da API

---

## 🚀 Tecnologias

- .NET 8
- ASP.NET Core
- EF Core
- SQLite
- Swagger

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

- Clean Architecture
- Separation of Concerns
- Dependency Injection
- Repository Pattern
- Use Case Pattern

---

## 👨‍💻 Autor

Desenvolvido por Jeferson Almeida

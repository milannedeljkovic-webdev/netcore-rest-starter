# .NET Core REST API Starter

## 📝 About

This project is a starter template for building REST API applications using ASP.NET Core, C#, Entity Framework Core, and SQL Server. It is designed for developers who want a quick start with modern web services featuring essential functionalities such as CRUD operations, JWT authentication, and automatic Swagger/OpenAPI documentation.

The goal of this project is to provide a clean and simple foundation for further development, simplify database interactions, ensure secure authentication, and make API endpoint testing easier. It also helps speed up onboarding for new team members.

---

## 🔧 Tech Stack
- ASP.NET Core 6
- C#
- SQL Server + Entity Framework Core
- JWT Authentication
- Swagger / OpenAPI

---

## 📂 Features
- User registration & login with JWT tokens
- CRUD endpoints (Users, Products)
- EF Core migrations for database setup
- Swagger UI for testing endpoints

---

## 🚀 Getting Started

### 1. Clone the repo
```bash
git clone https://github.com/milannedeljkovic-webdev/netcore-rest-starter.git
cd netcore-rest-starter
```

### 2. Setup Database

Update appsettings.json with your SQL Server connection string.

Run migrations:
```bash
dotnet ef database update
```

### 3. Run the API
```bash
dotnet run
```

Visit: https://localhost:5001/swagger

---

📫 About Me

Backend Developer with strong skills in C#, .NET, SQL optimization, and performance tuning.

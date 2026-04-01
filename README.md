# 🚀 Dockerized ASP.NET Core Web API

A containerized ASP.NET Core Web API integrated with SQL Server using Docker and Docker Compose.  
This project demonstrates modern backend development, containerization, and scalable deployment practices.

---

## 📌 Tech Stack

- ASP.NET Core Web API
- SQL Server
- Docker
- Docker Compose
- Entity Framework Core

---

## 📂 Project Structure

/project-root  
├── Controllers/  
├── Models/  
├── Data/  
├── Program.cs  
├── Dockerfile  
├── docker-compose.yml  
├── appsettings.json  
└── .gitignore  

---

## ⚙️ Features

- RESTful API implementation  
- Database integration with SQL Server  
- Fully containerized setup using Docker  
- Multi-container orchestration using Docker Compose  
- Scalable and environment-independent deployment  

---

## ▶️ Running the Application

### 🔹 Before Docker Setup

- Run the application locally using Visual Studio  
- Ensure Swagger UI is working correctly  
- Verify the application URL and port:  
  - https://localhost:5001  
  - http://localhost:5000  

✔ This step confirms the API works before containerization  

---

### 🔹 After Docker Setup

Run the project using Docker Compose:

```bash
docker-compose up --build


| Method | Endpoint        | Description     |
| ------ | --------------- | --------------- |
| GET    | /api/items      | Get all items   |
| GET    | /api/items/{id} | Get item by ID  |
| POST   | /api/items      | Create new item |
| PUT    | /api/items/{id} | Update item     |
| DELETE | /api/items/{id} | Delete item     |


🗄️ Database Configuration
SQL Server runs in a Docker container
Connection string configured in appsettings.json
Entity Framework Core used as ORM


📦 Docker Setup
Dockerfile
Builds ASP.NET Core application
Exposes required port
Runs the application inside a container

Docker Compose
Configures:
API container
SQL Server container
Handles networking between services

⚠️ Notes
Before Docker → Runs on default ports (5000/5001)
After Docker → Runs on configured port (e.g., 8080)
Ensure Docker is installed and running
Update ports if conflicts occur


---

## 🔥 What I Fixed
- Clean structure ✅  
- Proper Markdown formatting ✅  
- Removed duplicates ✅  
- Professional flow ✅  
- Interview-ready content ✅  

---


## 💡 Final Tip

👉 You understand **development → testing → containerization → deployment**

That’s exactly what recruiters want 🔥  

---
<img width="1265" height="1020" alt="Screenshot 2026-03-31 115004" src="https://github.com/user-attachments/assets/b8ec4637-bb6a-467f-a7cf-482073eb8ee7" />

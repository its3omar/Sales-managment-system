
# Sales Management System

A full-stack Sales Management System built using **ASP.NET Core (.NET 10)** for the backend and **React (Vite)** for the frontend.

---

## 🚀 Project Overview

This system is designed to manage sales operations including products, users, and transactions.  
It follows a clean architecture approach separating concerns between layers.

---

## 🧱 Tech Stack

### Backend
- ASP.NET Core Web API (.NET 10)
- Entity Framework Core
- LINQ
- SQL Server
- Clean Architecture (BLL / DAL / API)

### Frontend
- React (Vite)
- JavaScript (ES6+)
- Axios for API calls
- HTML / CSS

---

## 📁 Project Structure

```

SalesManagementSystem/
│
├── SalesMS.API
├── SalesMS.BLL
├── SalesMS.DAL
├── frontend
├── SalesMS.WinForms (optional legacy)
└── README.md

````

---

## ⚙️ How to Run

### Backend (.NET API)

```bash
dotnet run
````

Make sure to configure your database connection in `appsettings.json`.

---

### Frontend (React)

```bash
cd frontend
npm install
npm run dev
```

Frontend will run on:

```
http://localhost:5173
```

---

## 🔗 API Communication

The frontend communicates with the backend using REST API via Axios.

Example base URL:

```js
http://localhost:5000/api
```

---

## ✨ Features

* Product management (CRUD operations)
* Sales tracking system
* Clean layered architecture
* Responsive React UI
* RESTful API integration

---

## 👨‍💻 Author

Developed by: **Omar Ismail**

---

## 📌 Notes

* Make sure backend is running before starting frontend
* Update API base URL if ports change
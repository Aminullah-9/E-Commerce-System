# E-Commerce Backend API

A scalable and secure **e-commerce backend system** built with **ASP.NET Core Web API** and **SQL Server**, designed using RESTful principles, role-based access control, and stored procedures for database operations.

---

## 🚀 Features

* 🔐 **Authentication & Authorization**

  * JWT-based authentication
  * Refresh token mechanism
  * Role-based access (Admin, Seller, Customer)

* 👤 **User Management (Admin)**

  * View users with pagination
  * Assign/update user roles
  * Block / unblock users

* 🛍️ **Product & Category Management**

  * Create, update, view, and soft-delete products
  * Product images support
  * Category-based product filtering

* 🛒 **Shopping Cart**

  * Add, update, remove cart items
  * User-specific cart handling

* 📦 **Orders & Checkout**

  * Order creation with transactional integrity
  * Order items tracking
  * Order and payment status handling

* 💳 **Payment Simulation**

  * Transaction recording
  * Payment status tracking

* 📊 **Reporting (Admin)**

  * Sales reports
  * User activity reports

* 📝 **Activity Logging**

  * Tracks important user actions (login, purchase, role update, etc.)

---

## 🧱 Technology Stack

* **Backend:** ASP.NET Core Web API
* **Database:** SQL Server
* **Authentication:** JWT + Refresh Tokens
* **Data Access:** Stored Procedures
* **Architecture:** RESTful, Layered Architecture

---

## 🗂️ Database Design

The system uses a normalized relational database with the following core tables:

* Users
* Roles
* UserRoles
* Products
* ProductImages
* Categories
* CartItems
* Orders
* OrderItems
* Transactions
* RefreshTokens
* ActivityLogs

All business logic and CRUD operations are handled using **stored procedures** for performance and security.

---

## 📡 API Controllers

* AuthController
* UserController
* ProductController
* CartController
* OrderController
* PaymentController
* ReportController

Each controller follows RESTful conventions and enforces role-based authorization.

---

## ⚙️ Setup Instructions

1. Clone the repository
2. Configure the SQL Server connection string in `appsettings.json`
3. Execute database scripts (tables & stored procedures)
4. Run the project using Visual Studio or `dotnet run`

---

## 🔒 Security Practices

* Passwords stored as hashes
* JWT access tokens with expiration
* Refresh tokens stored securely
* Soft deletes for critical entities
* Activity logging for auditing

---

## 🎯 Project Purpose

This project is built for **learning, portfolio, and real-world backend practice**, demonstrating:

* Clean API design
* Secure authentication
* Proper database modeling
* Use of stored procedures
* Role-based access control

---

## 📌 Future Enhancements

* Product reviews & ratings
* Discount & coupon system
* Real payment gateway integration
* Email notifications
* Docker support

---

## 👨‍💻 Author

**Amin Ullah**
Backend Developer | ASP.NET Core | SQL Server

---

⭐ If you find this project useful, feel free to star the repository!

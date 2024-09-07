# 📦 C# Inventory Management System API

## 📄 Overview
This repository contains the source code for a C# inventory management system API. The API is built using ASP.NET Core and provides RESTful services for managing inventory data including products, categories, and suppliers.

## ✨ Features
- CRUD operations for product management.
- Category management to organize products.
- Supplier interaction to manage product suppliers.
- Detailed API documentation.

## 🛠 Technologies
- ASP.NET Core 5
- Entity Framework Core
- MySQL

## 🚀 Getting Started

### 📋 Prerequisites
- .NET 5 SDK
- Visual Studio 2022
- MySQL Server

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/andrenormlang/inventory-management-api-csharp.git  
   git clone https://github.com/andrenormlang/inventory-management-api-csharp.git
   ```
   
2. Open the solution in Visual Studio 2022.

3. Restore the necessary packages. Visual Studio should prompt you to restore packages once the project is opened. Alternatively, you can restore packages by right-clicking on the solution in Solution Explorer and selecting Restore NuGet Packages.

4. Set up the database URL as an environment variable:

Windows:
Open Command Prompt or PowerShell and run:

   ```powershell
   setx DATABASE_URL "server=localhost;port=3307;database=inventory_management;user=root;password=root"
   ```
macOS / Linux:
Add the following to your .bashrc, .zshrc, or .bash_profile

```bash
   export DATABASE_URL="server=localhost;port=3307;database=inventory_management;user=root;password=root"
```
   
5. Update the database by opening the Package Manager Console (Tools -> NuGet Package Manager -> Package Manager Console) and running:

```powershell
   Update-Database
```

6. 🪄Start the application by pressing F5 or clicking on the green Start button.

### 📚 API Documentation

Once the application is running, you can access the API documentation by navigating to the following URL:

```bash
http://localhost:{port}/swagger
```

This will provide interactive API documentation where you can test out the endpoints directly.

### 💡 Posting in Bulk

To post multiple categories, products, or suppliers at once, you can use the **bulk post** endpoints.

1. **Bulk Post Categories:**
   Send a `POST` request to `/api/categories/bulk` with a JSON array containing multiple categories.

   **Example Request:**

   ```json
   [
     {
       "name": "Electronics"
     },
     {
       "name": "Home Appliances"
     }
   ]
   ```

2. **Bulk Post Suppliers:**
   Send a `POST` request to `/api/suppliers/bulk` with a JSON array of suppliers.

   **Example Request:**

   ```json
   [
     {
       "name": "Best Supplier",
       "address": "1234 Market St",
       "phone": "555-555-5555"
     },
     {
       "name": "Great Supplier",
       "address": "5678 Main St",
       "phone": "555-555-5556"
     }
   ]
   ```

3. **Bulk Post Products:**
   Send a `POST` request to `/api/products/bulk` with a JSON array of products.

   **Example Request:**

   ```json
   [
     {
       "name": "Laptop",
       "price": 999.99,
       "quantity": 10,
       "categoryId": 1,
       "supplierId": 2
     },
     {
       "name": "Smartphone",
       "price": 699.99,
       "quantity": 15,
       "categoryId": 1,
       "supplierId": 1
     }
   ]
   ```

### ⚙️ Environment Variables

You should avoid storing sensitive information, such as database credentials, directly in the `appsettings.json`. Instead, store these values as **environment variables**.

#### Example for setting up the environment variable:

```bash
DATABASE_URL="server=localhost;port=3307;database=inventory_management;user=root;password=root"
```

In the `appsettings.json` or `appsettings.Development.json`, you can reference it like so:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "${DATABASE_URL}"
  }
}
```



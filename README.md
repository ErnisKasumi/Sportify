# Sportify
# Sportify
**Sportify** is a .NET-based eCommerce application focused on sports products.
## Features
- Product management (add, update, delete products)
- RESTful API for managing products
- Swagger API documentation
## Technologies Used
- **ASP.NET Core 6.0**: Backend framework for building the web API.
- **C#**: Primary language for API development.
- **In-memory Data Store**: For development purposes, the project uses an in-memory data store for managing products, brands, and types.
- **Swagger**: For API documentation and testing.
- **Entity Framework Core (Planned)**: ORM for database management (planned for future versions).
## Setup Instructions
1. Clone the repository:
   ```bash
   git clone https://github.com/arbiasGashi/Sportify.git
2. Navigate to the project directory:
   ```bash
   cd sportify
   
3. Restore the dependencies:
   ```bash
   dotnet restore
4. Run the application:
   ```bash
   dotnet run
5. Open a web browser and navigate to the Swagger UI for testing the API:
   ```bash
   [git clone https://github.com/ErnisKasumi/Sportify.git](http://localhost:5018/swagger)
# API Endpoints
- `GET /api/v1/products`: Get a list of all products.
- `GET /api/v1/products/{id}`: Get details of a specific product by ID.
- `POST /api/v1/products`: Create a new product.
- `PUT /api/v1/products/{id}`: Update an existing product.
- `DELETE /api/v1/products/{id}`: Delete a product by ID.
## In-Memory Data
The app uses an in-memory data store for managing products during development. Future iterations will integrate a proper relational database using Entity Framework Core.
## Planned Features
- **User Authentication**: Add user authentication and authorization features.
- **Database Integration**: Migrate from in-memory data to a SQL-based database using Entity Framework Core.
- **Product Filtering**: Add advanced filtering and sorting options for products.
- **Order Management**: Enable customers to place orders, view order history, and manage their shopping cart.

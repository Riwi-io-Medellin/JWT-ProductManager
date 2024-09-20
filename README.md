# Products API with JWT Authentication
This API, built with .NET, provides a set of endpoints to manage products. It uses JWT Authentication to ensure that only authenticated users can access the resources. The API is connected to a MySQL database, and environment variables are used for configuration.

## Features
CRUD (Create, Read, Update, Delete) operations for products.
Authentication and authorization using JSON Web Tokens (JWT).
Protected endpoints, accessible only to authenticated users.
Integrated with Swagger for API testing and exploration.

## Requirements
+ .NET 8 SDK or higher.
+ MySQL server.
+ Swagger is integrated, so no need for Postman or external API testing tools.
+ Environment Variables
Ensure you set the following environment variables before running the application:

```csharp
DB_HOST = your_host
DB_NAME = your_database_name
DB_PORT = your_port
DB_USERNAME = your_username
DB_PASSWORD = your_password

JWT_KEY = your_jwt_key
JWT_ISSUER = your_jwt_issuer
JWT_AUDIENCE = your_jwt_audience
JWT_EXPIRES_IN = time_in_minutes
```
## Project Setup
### Clone the repository:

```bash
git clone https://github.com/Riwi-io-Medellin/JWT-ProductManager.git
```
```bash
cd JWT-ProductManager
```

### Restore NuGet packages:

Run the following command in the project directory to restore necessary packages:

```bash
dotnet restore
```

### Set environment variables:

Before running the application, ensure that the environment variables for the database and JWT are set up as shown above.

### Apply database migrations:

Run the following command to apply migrations and set up the database tables:

```bash
dotnet ef database update
```

###  Run the API:

Start the API using the following command:

```bash
dotnet run
```

###  Access Swagger UI:

After running the API, Swagger will be available at https://localhost:5001/swagger or http://localhost:5000/swagger, where you can explore and test the API directly.

## JWT Authentication
To access protected endpoints, you first need to authenticate by sending a POST request to /api/v1/auth/login with your user credentials. The server will return a JWT token, which you must include in the headers of subsequent requests:

```bash
Authorization: Bearer {your-jwt-token}
```

## Technologies Used
+ ASP.NET Core 8
+ Entity Framework Core
+ JWT (JSON Web Tokens)
+ MySQL Database
+ Swagger (for testing and API documentation)

## License

© 2024 Riwi. All rights reserved.

The content of this project, including but not limited to text, images, graphics, and code, is the property of Riwi and is protected by copyright laws. It may not be reproduced, distributed, modified, or transmitted in any form or by any means without the prior written permission of Riwi.

For inquiries regarding the use or distribution of this project, please contact Riwi at [formacion@riwi.com](mailto:formacion@riwi.com).
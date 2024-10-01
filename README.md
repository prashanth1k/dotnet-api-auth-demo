# ASP.NET 8 API Authentication Demo

This project demonstrates a simple implementation of authentication in ASP.NET 8 APIs, including JWT (JSON Web Tokens) and Identity authentication.

## Features

- **JWT Authentication**: Secure your APIs using JSON Web Tokens.
- **Identity Authentication**: Simplify user management and authentication with ASP.NET Identity.
- **ASP.NET 8**: Leverage the latest features and improvements in ASP.NET 8.

Minimal APIs are used here, but the same principles can be applied to traditional ASP.NET Core APIs.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or any other compatible IDE

### Installation

1. Clone the repository:

```sh
git clone https://github.com/techformist/dotnet-api-auth-demo.git
```

2. Navigate to the project directory:

```sh
cd dotnet-api-auth-demo
```

3. Restore the dependencies:

```sh
dotnet restore
```

### Running the Application

1. Build the project:

```sh
dotnet build
```

2. Run the project:

```sh
dotnet run
```

### Usage

- Access the API endpoints to test authentication.
- Use tools like Postman to send requests with JWT tokens.
- Invoke Register and Login endpoints to create and authenticate users. Login fetches you a JWT token that you can use to access protected endpoints.
- Use the token in the Authorization header with the Bearer scheme to access protected endpoint - http://localhost:5042/weatherforecast (replace the port with your port number)

## Acknowledgements

- [ASP.NET Identity](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity)
- [JWT Authentication](https://jwt.io/introduction/)

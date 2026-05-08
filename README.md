# CyberShield — Backend API

A .NET Web API for the CyberShield cybersecurity awareness training platform.

## Tech Stack
- ASP.NET Core 8
- Entity Framework Core 8
- PostgreSQL

## Getting Started

### Prerequisites
- .NET 8 SDK
- PostgreSQL installed and running

### Database Setup

1. Install PostgreSQL from https://www.postgresql.org/download
2. Open pgAdmin and create a new database named: cybershield_db
3. Open appsettings.json and update the connection string:

   "ConnectionStrings": {
     "DefaultConnection": "Host=localhost;Database=cybershield_db;Username=postgres;Password=YOUR_PASSWORD"
   }

### Installation

1. Clone the repository
   git clone https://github.com/omarahmeed/CyberShieldApi-.git

2. Navigate to the project folder
   cd CyberShieldApi

3. Run database migrations
   dotnet ef database update

4. Run the API
   dotnet run

5. API will be available at http://localhost:5130

## API Endpoints

| Method | Endpoint      | Description                    |
|--------|---------------|--------------------------------|
| POST   | /api/contact  | Submit contact form data       |

## Request Body Example

{
  "name": "John Smith",
  "email": "john@company.com",
  "company": "Acme Corp",
  "message": "Tell us about your security needs",
  "plan": "Business"
}

## Response Example

{
  "message": "Request received successfully",
  "name": "John Smith",
  "email": "john@company.com",
  "company": "Acme Corp",
  "plan": "Business"
}
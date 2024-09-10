# Simple ASP.NET Core Authentication with In-Memory User Store

This is a simple ASP.NET Core web application that demonstrates how to implement a basic username and password-based login system using cookie-based authentication. The project uses an in-memory user store, making it ideal for testing purposes without the need for a database.

## Features
- **In-Memory User Storage**: User credentials are stored in a static list, avoiding the need for a database like SQL Server.
- **Cookie-Based Authentication**: Users are authenticated using cookies, and their session persists across pages until they log out.
- **Login/Logout Functionality**: Users can log in and log out of the application.
- **Error Handling**: Displays a red error message when invalid credentials are provided.
- **Protected Routes**: Specific routes can be protected to be accessible only to authenticated users.

## Technologies Used
- **ASP.NET Core**: Web framework used to create the application.
- **C#**: Programming language used for the backend logic.
- **Bootstrap**: Used for styling and creating responsive forms and alerts.

## Requirements
- .NET 6 SDK or higher
- A modern web browser


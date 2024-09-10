This project is a basic ASP.NET Core web application that implements username and password-based login functionality for testing purposes without using a database like SQL Server. The user data (username and password) is stored in an in-memory list, and authentication is handled using cookie-based authentication.

Key Features:
In-Memory User Storage: Users are stored in a static list (UserStore), which allows easy management of user data without needing a persistent database.
Login Functionality: Users can log in using their username and password. If the credentials are valid, a session is created using cookie-based authentication.
Error Handling: If invalid credentials are provided, the user is presented with a red error message using Bootstrap's alert component.
Cookie-Based Authentication: The application uses cookies to manage user authentication, allowing authenticated users to access protected pages.
Logout Functionality: Users can log out, which terminates their session and clears the authentication cookie.

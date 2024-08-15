

## News Website Project

This project is a **News Website** built using **ASP.NET Core** for the backend and **Angular** for the frontend. The website allows users to browse, read, and interact with news articles across various categories. The project demonstrates the implementation of core software design principles and patterns, including:

- **SOLID Principles**: Ensures the software is easy to maintain and extend.
- **MVC Pattern**: Used in the ASP.NET Core backend to separate concerns between the model, view, and controller.
- **CQRS (Command Query Responsibility Segregation)**: Separates data modification from data retrieval to optimize performance and scalability.
- **Repository Pattern**: Encapsulates data access logic, making it easier to test and maintain.
- **DTO (Data Transfer Object)**: Simplifies data transfer between the server and client, ensuring only necessary data is exposed.

### Project Structure

**Backend (ASP.NET Core):**
- **Controllers**: Handles HTTP requests and sends responses.
- **Models**: Defines the data structure for articles, categories, comments, and users.
- **DTOs**: Simplifies data transfer by converting models to and from DTOs.
- **Repositories**: Manages data persistence and retrieval.
- **Services**: Implements business logic and interacts with repositories.
- **Mappings**: Automaps models to DTOs.
- **Commands & Queries**: Handles data modification and retrieval using CQRS.

**Frontend (Angular):**
- **Components**: Includes article listing, article details, article creation/editing, and user management.
- **Services**: Manages API calls and handles data fetching and submission.
- **Models**: Defines the structure of data in the frontend.
- **Routing**: Configures the navigation between different components.

### Key Features
- **User Management**: Users can register, log in, and manage their profiles.
- **Article Management**: Admins can create, update, and delete articles.
- **Category Management**: Articles are organized into categories.
- **Commenting System**: Users can comment on articles.
- **Responsive Design**: The frontend is built with responsive design principles using Bootstrap.

### Technology Stack
- **Backend**: ASP.NET Core, Entity Framework Core, AutoMapper, MediatR.
- **Frontend**: Angular, TypeScript, Bootstrap.
- **Database**: SQL Server (or any preferred database).
- **Testing**: xUnit for backend testing, and Jasmine/Karma for Angular testing.

### Setup Instructions
1. Clone the repository.
2. Navigate to the backend project and run `dotnet restore` and `dotnet run`.
3. Navigate to the Angular project and run `npm install` and `ng serve`.
4. Access the website at `http://localhost:4200`.

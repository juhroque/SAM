# Part 1

## Explaining the project structure

This project was built based on Domain Driven Design (DDD) principles and Clean Architecture. The project is divided into 4 main layers:

1. **Application**: This layer is responsible for the application's business rules. It is the most external layer and is responsible for receiving requests, processing them, and returning responses. It is also responsible for orchestrating the flow of data between the other layers.
- The application layer here is implemented using the SAM.Application

2. **Domain**: This layer is responsible for the business rules of the application. It contains the entities, value objects, and domain services. This layer is the most important of all, as it is where the business rules are implemented.
- The domain layer here is implemented using the SAM.Domain

3. **Infrastructure**: This layer is responsible for the implementation of the interfaces defined in the Domain layer. It contains the implementation of the repositories, services, and other external dependencies. 
- The infrastructure layer here is implemented using the SAM.Infrastructure 

4. **Presentation**: This layer is responsible for the presentation of the application. It contains the controllers, views, and other presentation-related components.
- The presentation layer here is implemented using the SAM.Api and SAM.Contracts

Each layer has its own responsibilities and dependencies, and they are organized in a way that allows for easy maintenance and scalability of the application.

These are the folder structures of the project during this first part of development:

├── SAM.Api
│   ├── Controllers 
├── SAM.Application
│   ├── Services
├── SAM.Contracts
│   ├── Authentication
├── SAM.Domain
├── SAM.Infrastructure


## Modeling the API Contract

The API contract here is part of the Presentation Layer and is implemented using the SAM.Contracts project.

- The presentation layer is basically the gateway between the outer world and the application. It is responsible for receiving requests, processing them, and returning responses. It is also responsible for orchestrating the flow of data between the other layers.

The API contract is responsible for defining the request and response models of the API. It is important to have a well-defined API contract to ensure that the API is easy to use and understand.

In this first part we build the authentication contract, which is responsible for defining the request and response models of the authentication endpoints.

It cointains the following models:

├── SAM.Contracts
│   ├── Authentication
│       ├── AuthenticationResponse.cs
│       ├── LoginRequest.cs
│       ├── RegisterRequest.cs

- **LoginRequest**: This model is used to define the request model of the login endpoint. It contains the email and password fields.
- **RegisterRequest** : This model is used to define the request model of the register endpoint. It contains the email, password, and name fields.
- **AuthenticationResponse**: This model is used to define the response model of the authentication endpoints. It contains, besides of the email, pass and name fields, the user id and token field, which is used to authenticate the user.


## Implementing the Authentication Service

The authentication service is responsible for handling the authentication logic of the application and will be created in the Application layer -> SAM.Application. It is responsible for validating the user's credentials, generating the authentication token, and returning the user's information.

In this part, we focused only on building the strcture of these files but haven't yet implemented any authentication logic or even a connection to a database.

The authentication service is implemented in the SAM.Application project and contains the following files:

├── SAM.Application
│   ├── Services
│       ├── AuthenticationService.cs
│       ├── IAuthenticationService.cs
│       ├── AuthenticationResult.cs

- **IAuthenticationService**: This interface defines the contract of the authentication service. It contains the methods for registering and logging in a user.
- **AuthenticationService**: This class implements the IAuthenticationService interface and contains the logic for registering and logging in a user.
- **AuthenticationResult**: This class is used to define the result of the authentication process. It contains the user's information and the authentication token. It is the response model for the authentication endpoints.

## Abstracting the dependecy injection

The dependency injection is a pattern that allows us to decouple the creation of objects from their usage. It is a way to manage the dependencies between objects and make the code more modular and testable.

In this part, we abstracted the dependency injection using the Microsoft.Extensions.DependencyInjection library. This library allows us to register services and dependencies in a central place and inject them into the classes that need them.

I created the file DependencyInjection.cs in the SAM.Application project to register the services and dependencies, and also in the SAM.Infrastructure project to register the repositories and other external dependencies. 

This way, we can easily manage the dependencies of the application in the Program.cs file like this:

```csharp
var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddApplication()
        .AddInfrastructure();
}
```



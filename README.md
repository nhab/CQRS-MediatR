# CQRS-MediatR
Employee management system using CQRS and MediatR
## CQRS 
stands for Command Query Responsibility Segregation. That is separating Command (write) and Query (read) models of an application to scale read and write operations of an application independently. Instead of having all of the four CRUD operations together, we segment out to two different pieces.
## Mediator 
is used to reduce communication complexity between multiple objects or classes. This pattern provides a mediator class which normally handles all the communications between different classes and supports easy maintenance of the code by loose coupling. Mediator pattern falls under behavioural pattern category.
 
Basically, a Mediator perform 2 operations.
· Accept the incoming request
· Handles the incoming request and provide the response.


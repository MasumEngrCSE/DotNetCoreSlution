#region SOLID principles


/*
 

The SOLID principles are a set of five design principles in object-oriented programming and software development that aim
to create more maintainable, flexible, and understandable code. These principles were introduced by Robert C. Martin 
and are widely accepted as a guide for writing high-quality software. The SOLID acronym stands for:

Single Responsibility Principle (SRP):
A class should have only one reason to change.
This principle suggests that a class should have only one responsibility or job. If a class has multiple responsibilities, changes to one of those responsibilities can affect the others, making the code harder to maintain.

Open/Closed Principle (OCP):
Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.
This principle encourages the use of abstraction and polymorphism to extend functionality without altering existing code. New functionality should be added by creating new classes or components, rather than modifying existing ones.

Liskov Substitution Principle (LSP):
Subtypes must be substitutable for their base types without affecting the correctness of the program.
In other words, if a class is a subclass of another class, it should be able to be used interchangeably with its superclass without causing errors or unexpected behavior.

Interface Segregation Principle (ISP):
Clients should not be forced to depend on interfaces they do not use.
This principle suggests that you should design interfaces that are specific to the needs of the clients that use them. Avoid creating "fat" interfaces with methods that are not relevant to all implementing classes.

Dependency Inversion Principle (DIP):
High-level modules should not depend on low-level modules. Both should depend on abstractions.
Abstractions should not depend on details; details should depend on abstractions.
This principle encourages the use of abstractions (interfaces or abstract classes) to decouple high-level modules from low-level modules, making the system more flexible and allowing for easier replacement or modification of components.

By following these SOLID principles, developers can create software that is easier to maintain, extend, and understand,
leading to better overall software quality. These principles are often applied in various programming languages, including C#.


 */

#endregion
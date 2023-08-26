using javax.management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPattern
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }



    ////Examle 2
    ///
    public class DatabaseConnection
    {
        private static DatabaseConnection instance;

        // Private constructor to prevent external instantiation
        private DatabaseConnection() { }

        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseConnection();
                    Console.WriteLine($"Instance Initialized");
                    // Perform database connection initialization here
                }
                return instance;
            }
        }

        public void ExecuteQuery(string query)
        {
            // Execute the query on the database
            Console.WriteLine($"Executing query: {query}");
        }
    }

    public class ApplicationTest
    {
        public void Run()
        {
            // Get the singleton instance of DatabaseConnection
            DatabaseConnection dbConnection = DatabaseConnection.Instance;

            // Use the singleton instance to execute a query
            dbConnection.ExecuteQuery("SELECT * FROM Customers");
        }
    }


    public class ApplicationTest2
    {
        public void Run()
        {
            // Get the singleton instance of DatabaseConnection
            DatabaseConnection dbConnection = DatabaseConnection.Instance;

            // Use the singleton instance to execute a query
            dbConnection.ExecuteQuery("SELECT * FROM Order");
        }
    }


    public class ApplicationTest3
    {
        public void Run()
        {
            // Get the singleton instance of DatabaseConnection
            DatabaseConnection dbConnection = DatabaseConnection.Instance;

            // Use the singleton instance to execute a query
            dbConnection.ExecuteQuery("SELECT * FROM Delivery");
        }
    }



    /*
     
        The Singleton Pattern is a widely used design pattern that ensures a class has only one instance and provides a global point of access to that instance. This pattern is important for various reasons:
    Single Point of Control: The Singleton Pattern guarantees that there's only one instance of the class throughout the application's lifecycle. This can be crucial for scenarios where multiple instances could lead to conflicts or inefficient resource usage.


    Global Access: Because the singleton instance is globally accessible, it provides a convenient way to access shared resources or services from different parts of the application without passing references around.


    Resource Management: Singleton can be used to manage resources that should be shared among multiple components, such as database connections, network sockets, or expensive object instances. This avoids the overhead of creating and destroying these resources multiple times.


    Lazy Initialization: Singleton can be implemented with lazy initialization, meaning that the instance is created only when it's actually needed. This can improve the application's startup time and memory usage.


    Controlled Access: Singleton can encapsulate the creation and access to its instance, allowing you to control how and when the instance is created. This can be useful for enforcing certain rules or conditions during instance creation.


    Thread Safety: When implemented correctly, the Singleton Pattern can ensure thread safety. This is particularly important in multithreaded environments where multiple threads might try to access or create the instance simultaneously.


    Consistency: By having a single instance, you can maintain a consistent state and behavior across the application. Any changes made to the singleton instance will be visible to all parts of the application that use it.


    Testing and Mocking: Singleton instances can sometimes make unit testing and mocking more challenging. However, they can also help in providing controlled and consistent behavior during tests, especially when dealing with global resources.


    Reduced Memory Footprint: In cases where creating multiple instances of a resource-heavy class would be wasteful, the Singleton Pattern can significantly reduce the memory footprint of an application.


    Logging and Configuration: Singleton instances are often used for managing global settings, configuration, and logging mechanisms, ensuring that these features are accessible from anywhere in the application.
    Despite its benefits, it's important to use the Singleton Pattern judiciously. Overusing singletons can lead to tight coupling between components, making the codebase less maintainable and testable. Additionally, improper implementation can introduce issues such as thread safety problems and difficulties in unit testing.
    In summary, the Singleton Pattern is important because it provides a structured way to ensure that a particular class has only one instance, promoting efficient resource usage, controlled access, and consistent behavior across an application.




    Difference between static and singleton 

    Static and Singleton are two different approaches for creating and managing single instances of a class, 
    but they serve different purposes and have distinct characteristics in C#.

    Static:
    Usage:
    A static class is defined using the static keyword and cannot be instantiated.
    It's typically used for utility classes that provide helper methods and don't need instance-specific state.
    Instance Management:
    A static class can't have instance variables or instance methods.
    All members (methods, fields, properties) of a static class must be declared as static.
    Memory Usage:
    Members of a static class are shared across the application and are loaded into memory when the class is accessed for the first time.
    They persist throughout the lifetime of the application.
    Thread Safety:
    Static members are shared across all threads, so care should be taken to ensure thread safety if necessary.
    Singleton:
    Usage:
    A singleton is a design pattern that restricts the instantiation of a class to a single instance and provides a global point of access to that instance.
    It's used when you want to ensure there's only one instance of a class and control how that instance is created and accessed.
    Instance Management:
    A singleton class can have instance variables and instance methods.
    The singleton pattern usually involves lazy instantiation, where the instance is created only when it's first requested.
    Memory Usage:
    A singleton instance is typically loaded into memory only when it's needed, following the lazy instantiation principle.
    It persists throughout the lifetime of the application once it's created.
    Thread Safety:
    Implementing a thread-safe singleton can be a bit more involved to ensure that multiple threads can't create multiple instances simultaneously.
    Key Differences:
    Purpose:
    Static classes are used for grouping related utility methods or constants, while singletons are used to ensure that a class has only one instance with controlled access.
    Instance Methods and State:
    Static classes cannot have instance methods or instance state, while singletons can have both.
    Lazy Instantiation:
    Singleton pattern typically involves lazy instantiation, creating the instance only when it's first needed. This can improve memory usage and application startup time.
    Static classes are usually loaded and initialized when the application starts.
    Access and Control:
    Static members are accessed directly using the class name, while singleton instances are accessed through a specific method or property, allowing more control over instance creation.
    Flexibility:
    Singleton pattern allows more flexibility in terms of adding instance-specific behavior and state.
    In summary, static classes are used for utility methods and constants without instance-specific behavior, while singletons are used to ensure only one instance of a class is created and accessed, providing more control over instance creation and state management



     */

}

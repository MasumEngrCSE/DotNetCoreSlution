using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPattern
{
    // Product class (base class)
    public abstract class Product
    {
        public abstract void DisplayInfo();
    }

    // Concrete products
    public class ConcreteProductA : Product
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Product A");
        }
    }

    public class ConcreteProductB : Product
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Product B");
        }
    }

    // Creator (Factory) class
    public abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    // Concrete creators
    public class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }



    /*

    In this example, the Product class defines the interface for products, and the ConcreteProductA and ConcreteProductB classes are implementations of specific products.

The Creator class represents the factory, providing an abstract method FactoryMethod() that the concrete creators (ConcreteCreatorA and ConcreteCreatorB) will implement. This method creates and returns a specific product instance.

Now, let's see how you can use these classes:

        Creator creatorA = new ConcreteCreatorA();
        Product productA = creatorA.FactoryMethod();
        productA.DisplayInfo();  // Output: Product A

        Creator creatorB = new ConcreteCreatorB();
        Product productB = creatorB.FactoryMethod();
        productB.DisplayInfo();  // Output: Product B




    Why using the Factory Method Pattern is generally more beneficial:

    Decoupling: By using the Factory Method Pattern, you decouple the creation of objects from the client code. 
                This means that the client code doesn't need to know the exact concrete classes it's working with. 
                It only interacts with the factory's interface. This is especially useful when you have multiple products 
                and want to ensure that your client code isn't tightly coupled to specific implementations.

    Abstraction: The Factory Method Pattern allows you to abstract the creation process. 
                It provides a clear separation between the client code and the actual object creation, 
                making your code more maintainable and adaptable to changes.

    Extensibility: If you later decide to introduce more types of products, 
                using the Factory Method Pattern makes it easier to add new product types without changing the existing client code. 
                You can simply create new concrete creators for the new products.

    Testing: When you use the Factory Method Pattern, it's easier to mock or stub the creation of objects during testing. 
             You can replace the concrete creators with mock creators to isolate the client code during testing.

    Code Reusability: If the creation logic of your products is complex or involves common steps, 
            the Factory Method Pattern allows you to encapsulate that logic in the creator classes, 
            making it reusable across different parts of your application.

     */

}

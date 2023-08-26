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

     */

}

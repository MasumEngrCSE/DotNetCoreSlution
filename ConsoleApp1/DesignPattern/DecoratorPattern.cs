#region Decorator Pattern

/*
 
 The Decorator Pattern is a structural pattern that allows you to add behavior or responsibilities to objects dynamically,
 without altering their original code. This pattern is useful when you want to extend the functionality of objects in a flexible and reusable way.

 Here's an example of the Decorator Pattern:

 Suppose we're building a coffee shop application, and we have a base Coffee class. We want to add decorators to the coffee 
 to enhance its properties, such as adding milk or sugar.
 
 */

#endregion

using System;

// Component interface
public interface ICoffee
{
    string GetDescription();
    double GetCost();
}

// Concrete Component
public class SimpleCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Simple Coffee";
    }

    public double GetCost()
    {
        return 2.0;
    }
}

// Decorator
public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee decoratedCoffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        this.decoratedCoffee = coffee;
    }

    public virtual string GetDescription()
    {
        return decoratedCoffee.GetDescription();
    }

    public virtual double GetCost()
    {
        return decoratedCoffee.GetCost();
    }
}

// Concrete Decorators
public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", with Milk";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.5;
    }
}

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", with Sugar";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.2;
    }
}


#region In this example

/*
 
In this example, the ICoffee interface defines the methods for getting the coffee's description and cost. The SimpleCoffee class is a concrete component representing a basic coffee.

The CoffeeDecorator class is an abstract decorator that implements the same interface as ICoffee and holds a reference to a decoratedCoffee. Concrete decorators (MilkDecorator and SugarDecorator) extend the functionality of the coffee by adding milk or sugar.

Now, let's see how you can use these classes:

class Program
{
    static void Main(string[] args)
    {
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine($"Description: {coffee.GetDescription()}, Cost: ${coffee.GetCost()}");

        // Adding decorators
        coffee = new MilkDecorator(coffee);
        Console.WriteLine($"Description: {coffee.GetDescription()}, Cost: ${coffee.GetCost()}");

        coffee = new SugarDecorator(coffee);
        Console.WriteLine($"Description: {coffee.GetDescription()}, Cost: ${coffee.GetCost()}");
    }
}



 */



#endregion


#region Why Decorator Pattern is Necessary:

/*
 Why Decorator Pattern is Necessary:

Dynamic Behavior: The Decorator Pattern is necessary when you want to add behavior or responsibilities to objects at runtime without modifying their source code.

Open-Closed Principle: It adheres to the Open-Closed Principle, allowing you to extend the functionality of objects without changing their classes.

Reusability: Decorators are reusable and can be combined in various ways to create complex behavior without code duplication.

Fine-Grained Control: You can add or remove decorators as needed, providing fine-grained control over an object's behavior.

Flexibility: The pattern offers flexibility in combining different behaviors in different orders.

Maintainability: It helps keep the codebase clean and maintainable by avoiding a proliferation of subclasses for different combinations of behavior.

In summary, the Decorator Pattern is necessary when you want to dynamically enhance the behavior of objects in a flexible and reusable way,
while adhering to principles like the Open-Closed Principle and promoting maintainability and code clarity.
 
 */


#endregion
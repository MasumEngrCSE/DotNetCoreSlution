#region Open/Closed Principle

/*
 
The Open/Closed Principle (OCP) is one of the SOLID principles of object-oriented design.
It states that software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.
In other words, you should be able to extend the behavior of a module without changing its source code.
This promotes code stability and reusability.

Here's an example in C# to illustrate the Open/Closed Principle:

Suppose you have a simple application that calculates the total cost of a shopping cart with various types of products, including books and electronics. Initially, you have a class called Cart that calculates the total cost:

 */


#endregion

namespace ConsoleApp1.SOLID_principles
{
    public class Cart
    {
        public double CalculateTotalPrice(List<Product> products)
        {
            double totalPrice = 0;
            foreach (var product in products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }


    }
    public class Product
    {
        public double Price { get; internal set; }
    }

    #region MyRegion

    /*
     
    Now, imagine you want to add a discount feature to your shopping cart without modifying the Cart class. To adhere to the Open/Closed Principle,
    you can create an abstract Discount class and specific discount subclasses:

     */

    #endregion



    public abstract class Discount
    {
        public abstract double ApplyDiscount(double originalPrice);
    }

    public class NoDiscount : Discount
    {
        public override double ApplyDiscount(double originalPrice)
        {
            return originalPrice;
        }
    }

    public class TwentyPercentDiscount : Discount
    {
        public override double ApplyDiscount(double originalPrice)
        {
            return originalPrice * 0.8; // Apply a 20% discount
        }
    }



    #region MyRegion

    /*
     
    Now, you can modify the Cart class to accept a Discount object and apply the discount without changing the existing code:
     
     */


    public class CartOCP
    {
        public double CalculateTotalPrice(List<Product> products, Discount discount)
        {
            double totalPrice = 0;
            foreach (var product in products)
            {
                totalPrice += product.Price;
            }

            // Apply the discount
            totalPrice = discount.ApplyDiscount(totalPrice);

            return totalPrice;
        }
    }


    #endregion

}

#region MyRegion

/*
 

With this approach, you can easily extend the Cart class's behavior by creating new discount classes without altering the Cart class itself.
This demonstrates the Open/Closed Principle because the Cart class is open for extension (you can add new discount classes) but closed 
for modification (you don't need to change the existing Cart class when adding discounts).

The Open/Closed Principle is essential in software development because it helps create code that is more maintainable,
less error-prone, and easier to extend over time. It promotes a design that encourages adding new features 
and functionality without risking the stability of existing code.

 */


#endregion
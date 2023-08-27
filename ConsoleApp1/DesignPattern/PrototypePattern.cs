using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPattern
{
    #region Prototype Pattern

    /*
     
    The Prototype Pattern is a creational pattern that allows you to copy or clone existing objects without making the code dependent on their concrete classes.
    This pattern is useful when creating new instances of objects is expensive or when you want to isolate object creation and copying logic from the client code.

    Here's an example of the Prototype Pattern:

    Suppose we're developing a game with different types of characters, and we want to create new characters by cloning existing ones.

     */


    #endregion

    // Prototype interface
    public interface ICharacterPrototype
    {
        ICharacterPrototype Clone();
    }

    // Concrete prototypes
    public class Warrior : ICharacterPrototype
    {
        public string Type { get; } = "Warrior";

        public ICharacterPrototype Clone()
        {
            return (ICharacterPrototype)MemberwiseClone();
        }
    }

    public class Mage : ICharacterPrototype
    {
        public string Type { get; } = "Mage";

        public ICharacterPrototype Clone()
        {
            return (ICharacterPrototype)MemberwiseClone();
        }
    }

}


#region In this example

/*
 
In this example, the ICharacterPrototype interface defines a Clone method that concrete prototypes (Warrior and Mage) implement. 
These prototypes can be cloned using the MemberwiseClone method.

Now, let's see how you can use these classes:



class Program
{
    static void Main(string[] args)
    {
        ICharacterPrototype warriorPrototype = new Warrior();
        ICharacterPrototype magePrototype = new Mage();

        ICharacterPrototype clonedWarrior = warriorPrototype.Clone();
        ICharacterPrototype clonedMage = magePrototype.Clone();

        Console.WriteLine("Cloned warrior type: " + ((Warrior)clonedWarrior).Type);
        Console.WriteLine("Cloned mage type: " + ((Mage)clonedMage).Type);
    }
}



Why Prototype Pattern is Necessary:

Object Copying: The Prototype Pattern is necessary when you need to create new objects that are similar to existing objects. Instead of creating new instances from scratch, you can clone existing ones.

Performance: If object creation is expensive (e.g., involves complex initialization or resource allocation), the Prototype Pattern can save resources by copying existing objects.

Isolation: The Prototype Pattern isolates the client code from the details of object creation and copying, improving code maintainability.

Customization: Cloned objects can be customized after copying, allowing you to create similar but slightly modified instances.

Variation: If your application needs to create multiple instances with slight variations, the Prototype Pattern provides an efficient way to achieve this.

Avoid Subclassing: Instead of creating subclasses for every variation, the Prototype Pattern allows you to create variations through object copying.

In summary, the Prototype Pattern is necessary when you need to create new objects by copying existing ones, saving resources,
and isolating object creation logic. It's particularly useful when you want to create variations of objects without subclassing 
or when object creation is resource-intensive.







 */


#endregion

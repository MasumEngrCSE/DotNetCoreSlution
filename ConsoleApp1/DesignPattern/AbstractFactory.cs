using com.sun.tools.@internal.jxc.gen.config;
using java.lang;
using java.util.concurrent;
using java.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static javax.xml.crypto.KeySelector;
namespace ConsoleApp1.DesignPattern
{
    #region Abstract Factory Pattern
    /*  The Abstract Factory Pattern is a creational pattern that provides an interface for creating families of related 
       or dependent objects without specifying their concrete classes.This pattern is useful when you need to create multiple objects 
       that are related or need to work together, ensuring that the objects created are compatible.
        
    Here's an example of the Abstract Factory Pattern:

    Suppose we're building a user interface library that needs to support different UI elements like buttons and checkboxes. 
    We have two families of UI elements: WindowsUIFactory and LinuxUIFactory.
    */
    #endregion



    // Abstract factory interface
    public interface IUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }

    // Abstract product interfaces
    public interface IButton
    {
        void Render();
    }
    public interface ICheckbox
    {
        void Render();
    }

    // Concrete products for Windows UI
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Windows button");
        }
    }

    public class WindowsCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Windows checkbox");
        }
    }

    // Concrete products for Linux UI
    public class LinuxButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Linux button");
        }
    }

    public class LinuxCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Linux checkbox");
        }
    }

    // Concrete factories
    public class WindowsUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }

    public class LinuxUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new LinuxCheckbox();
        }
    }

}


/*
 
In this example, the IUIFactory interface defines methods for creating UI elements (buttons and checkboxes).
Concrete factories (WindowsUIFactory and LinuxUIFactory) implement this interface to create concrete UI elements.

Each concrete product (WindowsButton, LinuxButton, WindowsCheckbox, LinuxCheckbox) implements its respective interface (IButton or ICheckbox) for rendering.

Now, let's see how you can use these classes:


class Program
{
    static void Main(string[] args)
    {
        IUIFactory windowsFactory = new WindowsUIFactory();
        IButton windowsButton = windowsFactory.CreateButton();
        ICheckbox windowsCheckbox = windowsFactory.CreateCheckbox();

        windowsButton.Render();    // Output: Rendering a Windows button
        windowsCheckbox.Render();  // Output: Rendering a Windows checkbox

        IUIFactory linuxFactory = new LinuxUIFactory();
        IButton linuxButton = linuxFactory.CreateButton();
        ICheckbox linuxCheckbox = linuxFactory.CreateCheckbox();

        linuxButton.Render();      // Output: Rendering a Linux button
        linuxCheckbox.Render();    // Output: Rendering a Linux checkbox
    }
}



Why Abstract Factory Pattern is Necessary:

Families of Objects: The Abstract Factory Pattern is necessary when you need to create families of related objects, such as UI elements that need to work together coherently.

Consistency: It ensures that the objects created by a factory are consistent and compatible with each other, as they are from the same family.

Separation of Concerns: The pattern separates the creation of objects from their usage, promoting better organization and code maintainability.

Configurability: The choice of concrete factory (e.g., WindowsUIFactory or LinuxUIFactory) allows you to configure the whole system to use a specific set of related objects.

Adaptability: If you need to add new UI elements or support different platforms, you can create new factories and products without affecting the existing codebase.

In summary, the Abstract Factory Pattern is necessary when you need to create families of related objects that work together. 
It provides a way to ensure that objects are consistent and compatible while promoting separation of concerns and configurability in your code.



 */


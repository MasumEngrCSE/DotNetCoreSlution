using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPattern
{

    #region Adapter Pattern

    /*
     
    The Adapter Pattern is a structural pattern that allows objects with incompatible interfaces to work together by providing a wrapper that converts one interface into another.
    This pattern is useful when you have existing classes or components with different interfaces and you want to make them collaborate without changing their source code.

    Here's an example of the Adapter Pattern:

    Suppose we have a legacy system that uses an OldPrinter class to print documents. 
    However, we want to use a new ModernPrinter class that has a different interface.

     */

    #endregion

    // Legacy system (OldPrinter)
    public class OldPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Old Printer: " + text);
        }
    }

    // New system (ModernPrinter)
    public class ModernPrinter
    {
        public void PrintFormatted(string text)
        {
            Console.WriteLine("Modern Printer: " + text);
        }
    }

    // Adapter
    public class PrinterAdapter : ModernPrinter
    {
        private OldPrinter oldPrinter;

        public PrinterAdapter(OldPrinter oldPrinter)
        {
            this.oldPrinter = oldPrinter;
        }

        public new void PrintFormatted(string text)
        {
            string formattedText = "Adapter: " + text;
            oldPrinter.Print(formattedText);
        }
    }


    #region In this example

    /*
     
    In this example, the OldPrinter and ModernPrinter classes have different methods for printing. 
    We create an PrinterAdapter class that inherits from ModernPrinter and wraps an instance of OldPrinter. 
    The adapter's PrintFormatted method adapts the old printer's method to match the new printer's interface.

    Now, let's see how you can use these classes:



    class Program
    {
        static void Main(string[] args)
        {
            OldPrinter oldPrinter = new OldPrinter();
            ModernPrinter modernPrinter = new ModernPrinter();
            PrinterAdapter adapter = new PrinterAdapter(oldPrinter);

            oldPrinter.Print("Hello from old printer");
            modernPrinter.PrintFormatted("Hello from modern printer");
            adapter.PrintFormatted("Hello through adapter");
        }
    }



    Why Adapter Pattern is Necessary:

    Integration: The Adapter Pattern is necessary when you have existing components or classes with different interfaces and you want them to work together without modifying their source code.

    Reuse: It allows you to reuse existing classes or components even if they don't match the required interface.

    Legacy Code: When dealing with legacy code that you can't modify, adapters help bridge the gap between old and new systems.

    Third-party Libraries: When using third-party libraries with different interfaces, adapters can make them compatible with your application.

    Isolation: Adapters isolate the client code from the details of interface incompatibility, improving code maintainability.

    Adding Functionality: Adapters can also add or modify behavior while adapting interfaces.

    In summary, the Adapter Pattern is necessary when you need to make different components or classes with incompatible interfaces work together.
    It provides a way to integrate legacy systems, reuse existing components, and make third-party libraries compatible with your application, all without modifying their source code.


     */

    #endregion

}

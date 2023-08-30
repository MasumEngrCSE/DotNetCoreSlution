using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPattern
{
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

}

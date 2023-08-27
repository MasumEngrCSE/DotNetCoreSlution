using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPattern
{
    #region Builder Pattern

    /*
     
    The Builder Pattern is a creational pattern that separates the construction of a complex object from its representation, 
    allowing the same construction process to create different representations. This pattern is useful when you have complex objects 
    with multiple parts that need to be constructed in a step-by-step manner.

    Here's an example of the Builder Pattern:

    Suppose we're building a document editor that can create different types of documents, such as plain text documents 
    and rich text documents. We'll use the Builder Pattern to construct these documents.

     */


    #endregion

    // Product class: Document
    public class Document
    {
        private List<string> content = new List<string>();

        public void AddContent(string text)
        {
            content.Add(text);
        }

        public void ShowContent()
        {
            foreach (var item in content)
            {
                Console.WriteLine(item);
            }
        }
    }

    // Abstract builder interface
    public interface IDocumentBuilder
    {
        void BuildHeader();
        void BuildContent(string[] paragraphs);
        void BuildFooter();
        Document GetDocument();
    }

    // Concrete builder for PlainTextDocument
    public class PlainTextDocumentBuilder : IDocumentBuilder
    {
        private Document document = new Document();

        public void BuildHeader()
        {
            document.AddContent("=== Plain Text Document ===");
        }

        public void BuildContent(string[] paragraphs)
        {
            foreach (var paragraph in paragraphs)
            {
                document.AddContent(paragraph);
            }
        }

        public void BuildFooter()
        {
            document.AddContent("End of Plain Text Document");
        }

        public Document GetDocument()
        {
            return document;
        }
    }

}

/*
 
    In this example, the Document class represents the complex object we want to construct. 
    The IDocumentBuilder interface defines the steps for constructing the document.

    The PlainTextDocumentBuilder class is a concrete builder that implements the IDocumentBuilder interface to construct plain text documents.

    Now, let's see how you can use these classes:


    class Program
    {
        static void Main(string[] args)
        {
            string[] plainTextContent = { "This is paragraph 1.", "This is paragraph 2." };

            IDocumentBuilder builder = new PlainTextDocumentBuilder();
            DocumentDirector director = new DocumentDirector(builder);

            director.ConstructDocument(plainTextContent);
            Document plainTextDocument = builder.GetDocument();

            plainTextDocument.ShowContent();
        }
    }



Why Builder Pattern is Necessary:

    Complex Object Construction: The Builder Pattern is necessary when constructing a complex object involves multiple steps or parts. It allows you to separate the construction process from the client code, making it more manageable.

    Different Representations: If you need to create different representations of the same complex object, the Builder Pattern allows you to do so without duplicating construction code.

    Encapsulation: The pattern encapsulates the construction details in a separate builder class, keeping the client code focused on creating the object.

    Reusability: Builders can be reused for constructing similar objects with different attributes or configurations.

    Flexibility: The Director class can control the order of construction steps, and the client code can vary the configuration of the final object.

    Readability: The Builder Pattern makes the code more readable by organizing the construction logic in a structured manner.


    In summary, the Builder Pattern is necessary when constructing complex objects in a step-by-step manner. 
    It provides separation of concerns, encapsulation, reusability, and flexibility, making it particularly useful 
    when you need to create various representations of the same complex object.






 */

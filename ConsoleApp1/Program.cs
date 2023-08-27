// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ConsoleApp1.DesignPattern;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello");

//var cl = new SumNSeriesSolution();
//cl.initialCall();


string[] plainTextContent = { "This is paragraph 1.", "This is paragraph 2." };

IDocumentBuilder builder = new PlainTextDocumentBuilder();
builder.BuildHeader();
builder.BuildContent(plainTextContent);
builder.BuildFooter();

Document plainTextDocument = builder.GetDocument();

plainTextDocument.ShowContent();




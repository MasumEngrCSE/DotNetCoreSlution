using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPattern
{
    #region Bridge Pattern

    /*
     
    The Bridge Pattern is a structural pattern that decouples an abstraction from its implementation,
    allowing both to vary independently. This pattern is useful when you want to separate the interface and implementation of a class,
    enabling changes to one without affecting the other.

    Here's an example of the Bridge Pattern:

    Suppose we're designing a drawing application that supports different shapes (e.g., circles and squares) 
    and different rendering methods (e.g., raster and vector). The Bridge Pattern helps us manage the variations 
    between shapes and rendering methods.

     */


    #endregion
    // Implementor interface
    public interface IRenderer
    {
        void RenderCircle(float radius);
        void RenderSquare(float side);
    }

    // Concrete implementors
    public class RasterRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing a circle of radius {radius} in raster mode");
        }

        public void RenderSquare(float side)
        {
            Console.WriteLine($"Drawing a square of side {side} in raster mode");
        }
    }

    public class VectorRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing a circle of radius {radius} in vector mode");
        }

        public void RenderSquare(float side)
        {
            Console.WriteLine($"Drawing a square of side {side} in vector mode");
        }
    }

    // Abstraction
    public abstract class Shape
    {
        protected IRenderer renderer;

        protected Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Draw();
    }

    // Refined abstraction: Circle
    public class Circle : Shape
    {
        private float radius;

        public Circle(IRenderer renderer, float radius) : base(renderer)
        {
            this.radius = radius;
        }

        public override void Draw()
        {
            renderer.RenderCircle(radius);
        }
    }

    // Refined abstraction: Square
    public class Square : Shape
    {
        private float side;

        public Square(IRenderer renderer, float side) : base(renderer)
        {
            this.side = side;
        }

        public override void Draw()
        {
            renderer.RenderSquare(side);
        }
    }


    #region In this example

    /*
    
    In this example, the IRenderer interface defines the methods for rendering shapes.
    The RasterRenderer and VectorRenderer are concrete implementors that provide specific rendering methods.

    The Shape class is an abstraction that holds a reference to an IRenderer.
    The Circle and Square classes are refined abstractions that extend the Shape class and provide their specific draw implementations.

    Now, let's see how you can use these classes:
     

    class Program
    {
        static void Main(string[] args)
        {
            IRenderer rasterRenderer = new RasterRenderer();
            IRenderer vectorRenderer = new VectorRenderer();

            Shape circle = new Circle(rasterRenderer, 5);
            Shape square = new Square(vectorRenderer, 4);

            circle.Draw();
            square.Draw();
        }
    }


    Why Bridge Pattern is Necessary:

    Separation of Concerns: The Bridge Pattern is necessary when you want to separate abstraction (e.g., shapes) from implementation (e.g., rendering methods), allowing them to change independently.

    Variability: It's useful when you have multiple dimensions of variability in your classes. In this example, we have both different shapes and different rendering methods.

    Extensibility: The Bridge Pattern supports future extensions. You can add new shapes or rendering methods without modifying existing classes.

    Code Reusability: The pattern promotes code reusability by enabling different combinations of abstractions and implementations.

    Avoiding Class Explosion: Without the Bridge Pattern, you might need to create a separate subclass for each combination of shape and rendering method, leading to a large number of classes.

    In summary, the Bridge Pattern is necessary when you need to decouple abstraction from implementation,
    allowing you to handle multiple dimensions of variability and promote code reusability.
    It's particularly valuable when you want to avoid a proliferation of subclasses due to different combinations of variations.



     */



    #endregion



}

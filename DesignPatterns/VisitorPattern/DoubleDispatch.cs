using System;

namespace VisitorPattern
{
    interface Shape
    {
        public void Draw();
        public void Accept(Exporter exporter);
    }
    class Rectangle:Shape
    {
        public void Accept(Exporter exporter)
        {
            exporter.Export(this);
        }

        public void Draw()
        {
            Console.WriteLine("Rectangel drawn");
        }
    }
    class Sqaure : Shape
    {
        public void Accept(Exporter exporter)
        {
            exporter.Export(this);
        }

        public void Draw()
        {
            Console.WriteLine("Square drawn");
        }
    }

    class Circle : Shape
    {
        public void Accept(Exporter exporter)
        {
            exporter.Export(this);
        }

        public void Draw()
        {
            Console.WriteLine("Circle drawn");
        }
    }

    class Exporter
    {
        public void Export(Shape s)
        {
            Console.WriteLine("exportig Shape");
        }
        public void Export(Rectangle s)
        {
            Console.WriteLine("exportig Rectangle");
        }
        public void Export(Sqaure s)
        {
            Console.WriteLine("exportig Sqaure");
        }
     }

    class App
    {
        public void Export(Shape shape)
        {
            Exporter exporter = new Exporter();
            exporter.Export(shape);
        }
        //double dispathch
        public void Export2(Shape shape)
        {
            Exporter exporter = new Exporter();
            shape.Accept(exporter);
        }
        public void Draw(Shape shape)
        {
            shape.Draw();
        }
    }
}

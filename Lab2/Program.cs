using System;

namespace Lab2
{
    internal class Program
    {
        static void PrintFigure(Figure f)
        {
            Console.WriteLine($"{f.Name}");
            Console.WriteLine($"S = {f.GetArea()}\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Лаба 2\n");

            Rectangle rectangle = new Rectangle() { Name = "Прямоугольник", Height = 5, Width = 10};
            Circle circle = new Circle() { Name = "Круг", Raduis = 3 };
            Square square = new Square() { Side = 4 };
            Triangle triangle = new Triangle() { Name = "Треугольник", Height = 5, Bottom = 6 };
            Trapeze trapeze = new Trapeze() { Name = "Трапеция", Bottom = 6, Top = 10 };
            Rhomb rhomb = new Rhomb() { Name = "Ромб", Side = 5, Height = 6 };
            Parallelogram parallelogram = new Parallelogram() { Name = "Параллелограмм", Height = 10, Side = 4 };
            Penta penta = new Penta() { Name = "Правильный пятиугольник", Side = 5 };
            Deca deca = new Deca() { Name = "Правильный десятиугольник", Side = 5 };

            PrintFigure(rectangle);
            PrintFigure(circle);
            PrintFigure(square);
            PrintFigure(triangle);
            PrintFigure(trapeze);
            PrintFigure(rhomb);
            PrintFigure(parallelogram);
            PrintFigure(penta);
            PrintFigure(deca);
        }
    }
}

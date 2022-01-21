using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KireevCustoms;
using Task2._1._2.GeometricShapes;

namespace Task2._1._2
{
    class Program
    {
        public enum UserMenuActions
        {
            None = 0,
            AddFigure = 1,
            PrintFigures = 2,
            Clear = 3,
            ChangeUser = 4,
            Exit = 5
        }

        public enum ShapesMenu
        {
            None = 0,
            Line = 1,
            Round = 2,
            Circle = 3,
            Ring = 4,
            Triangle = 5,
            Square = 6,
            Rectangle = 7,
        }

        static void Main(string[] args)
        {
            UserMenusUse();
        }

        static void UserMenusUse()
        {
            CustomString userName = "";
            UserMenuActions userActions = 0;
            List<GeometricShape> shapes = new List<GeometricShape>();

            Console.WriteLine("Enter your name:");
            userName = Console.ReadLine();

            Console.WriteLine($"Hello, {userName}!");

            do
            {
                Console.WriteLine(
                    $"Choose action, {userName}:{Environment.NewLine}" +
                    $"1. Add shape{Environment.NewLine}" + 
                    $"2. Print all shapes to console{Environment.NewLine}" +
                    $"3. Delete all shapes{Environment.NewLine}" +
                    $"4. Change user name{Environment.NewLine}" +
                    $"5. Close app");

                Enum.TryParse<UserMenuActions>(
                    Console.ReadLine(), out userActions);

                Console.WriteLine();

                switch (userActions)
                {
                    case UserMenuActions.AddFigure:
                        shapes.Add(
                            ShapesMenuUse());

                        Console.WriteLine(
                            $"New shape added!{Environment.NewLine}");
                        break;

                    case UserMenuActions.PrintFigures:
                        PrintAllShapes(shapes);

                        Console.WriteLine(
                            $"Done!{Environment.NewLine}");
                        break;

                    case UserMenuActions.Clear:
                        shapes.Clear();

                        Console.WriteLine(
                            $"Cleared!{Environment.NewLine}");
                        break;

                    case UserMenuActions.ChangeUser:
                        Console.WriteLine("Enter your name:");
                        userName = Console.ReadLine();

                        Console.WriteLine($"Hello, {userName}!");

                        break;

                    case UserMenuActions.Exit:
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            }
            while (userActions != UserMenuActions.Exit);
        }

        static GeometricShape ShapesMenuUse()
        {
            ShapesMenu shapesMenu = 0;

            Console.WriteLine(
                $"Choose shape:{Environment.NewLine}" +
                $"1. Line{Environment.NewLine}" +
                $"2. Round{Environment.NewLine}" +
                $"3. Circle{Environment.NewLine}" +
                $"4. Ring{Environment.NewLine}" +
                $"5. Triangle{Environment.NewLine}" +
                $"6. Square{Environment.NewLine}" +
                $"7. Rectangle{Environment.NewLine}");

            Enum.TryParse<ShapesMenu>(
                    Console.ReadLine(), out shapesMenu);

            switch (shapesMenu)
            {
                case ShapesMenu.Line:
                    Line line = new Line();

                    Console.WriteLine(
                        $"Enter params:{Environment.NewLine}" +
                        $"Start point (x;y):");
                    line.StartPoint = 
                        Point.Parse(Console.ReadLine());

                    Console.WriteLine("End point (x;y):");
                    line.EndPoint =
                        Point.Parse(Console.ReadLine());

                    return line;

                case ShapesMenu.Round:
                    Round round = new Round();

                    Console.WriteLine(
                        $"Enter params:{Environment.NewLine}" +
                        $"Center point (x;y):");
                    round.Center =
                        Point.Parse(Console.ReadLine());

                    Console.WriteLine("Radius (float):");
                    round.Radius =
                        float.Parse(Console.ReadLine());

                    return round;

                case ShapesMenu.Circle:
                    Circle circle = new Circle();

                    Console.WriteLine(
                        $"Enter params:{Environment.NewLine}" +
                        $"Center point (x;y):");
                    circle.Center =
                        Point.Parse(Console.ReadLine());

                    Console.WriteLine("Radius (float):");
                    circle.Radius =
                        float.Parse(Console.ReadLine());

                    return circle;

                case ShapesMenu.Ring:
                    Ring ring = new Ring();

                    Console.WriteLine(
                        $"Enter params:{Environment.NewLine}" +
                        $"Center point (x;y):");
                    ring.Center =
                        Point.Parse(Console.ReadLine());

                    Console.WriteLine("Inner radius (float):");
                    ring.InnerRadius =
                        float.Parse(Console.ReadLine());

                    Console.WriteLine("Outer radius (float):");
                    ring.OuterRadius =
                        float.Parse(Console.ReadLine());

                    return ring;

                case ShapesMenu.Triangle:
                    Triangle triangle = new Triangle();

                    Console.WriteLine(
                        $"Enter params:{Environment.NewLine}" +
                        $"Point1 (x;y):");
                    triangle.Point1 =
                        Point.Parse(Console.ReadLine());

                    Console.WriteLine("Point2:");
                    triangle.Point2 =
                        Point.Parse(Console.ReadLine());

                    Console.WriteLine("Point3:");
                    triangle.Point3 =
                        Point.Parse(Console.ReadLine());

                    return triangle;

                case ShapesMenu.Square:
                    Square square = new Square();

                    Console.WriteLine(
                        $"Enter params:{Environment.NewLine}" +
                        $"Start point (x;y):");
                    square.StartPoint =
                        Point.Parse(Console.ReadLine());

                    Console.WriteLine("Side length (float):");
                    square.SideLength =
                        float.Parse(Console.ReadLine());

                    return square;

                case ShapesMenu.Rectangle:
                    Rectangle rectangle = new Rectangle();

                    Console.WriteLine(
                        $"Enter params:{Environment.NewLine}" +
                        $"Start point (x;y):");
                    rectangle.StartPoint =
                        Point.Parse(Console.ReadLine());

                    Console.WriteLine("End Point (x;y):");
                    rectangle.EndPoint =
                        Point.Parse(Console.ReadLine());

                    return rectangle;

                default:
                    return null;
            }
        }

        static void PrintAllShapes(
            List<GeometricShape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Print();
            }
            Console.WriteLine(
                $"count of shapes: " +
                $"{shapes.Count}");
        }
    }
}

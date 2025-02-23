using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;
using AbsShape3D;
namespace AbsShape3D
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            var container = new ShapeContainer();
            bool running = true;

            Console.WriteLine("Welcome to the Shape Manager!");
            Console.WriteLine("Commands: create, get, delete, list, exit.");

            while (running)
            {
                Console.Write("\nEnter command: ");
                string? command = Console.ReadLine()?.Trim().ToLower();

                switch (command)
                {
                    case "create":
                        CreateShape(container);
                        break;
                    case "get":
                        GetShape(container);
                        break; 
                    case "delete":
                        DeleteShape(container);
                        break;
                    case "list":
                        ListShapes(container);
                        break;
                    case "exit":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Unknown command. Try: create, get, delete, list, exit. ");  
                        break;      
                }
            }
        }

        static void CreateShape(ShapeContainer container)
        {
            Console.Write("Enter shape type (cube/sphere/cylinder): ");
            string? type = Console.ReadLine()?.Trim().ToLower();

            try
            {
                AbsShape3D? shape = type switch 
                {
                    "cube" => CreateCube(),
                    "sphere" => CreateSphere(),
                    "cylinder" => CreateCylinder(),
                    _ => throw new ArgumentException("Invalid shape type.")
                };

                if (shape != null)
                {
                    container.Create(shape);
                    Console.WriteLine("Shape created: ");
                    Console.WriteLine(shape.Dump());
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error creating shape: {ex.Message}");
            }
        }

        static AbsShape3D CreateCube()
        {
            Console.WriteLine("Enter side length: ");
            double side = double.Parse(Console.ReadLine() ?? "0");
            return new Cube(side);
        }

        static AbsShape3D CreateSphere()
        {
            Console.WriteLine("Enter radius: ");
            double radius = double.Parse(Console.ReadLine() ?? "0");
            return new Sphere(radius);
        }

        static AbsShape3D CreateCylinder()
        {
            Console.WriteLine("Enter radius: ");
            double radius = double.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter height: ");
            double height = double.Parse(Console.ReadLine() ?? "0");
            return new Cylinder(radius, height);
        }

        static void GetShape(ShapeContainer container)
        {
            Console.Write("Enter shape index: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                try
                {
                    var shape = container.Get(index);
                    Console.WriteLine("Shape details:");
                    Console.WriteLine(shape.Dump());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        static void DeleteShape(ShapeContainer container)
        {
            Console.Write("Enter shape index: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                bool result = container.Delete(index);
                Console.WriteLine(result ? "Shape deleted." : "Invalid index. Deletion failed.");
            }
        }

        static void ListShapes(ShapeContainer container)
        {
            Console.WriteLine("\nCurrent Shapes in Container: ");
            for (int i = 0; i < container.Count; i++)
            {
                var shape = container.Get(i);
                Console.WriteLine($"[{i}] {shape.Dump()}");
            }
        }
    }
}
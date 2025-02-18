using System.Dynamic;
using System.Runtime.CompilerServices;
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
                        ListShape(container);
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

        
    }
}
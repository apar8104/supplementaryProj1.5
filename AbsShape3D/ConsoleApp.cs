using System.Dynamic;
using AbsShape3D;

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
}
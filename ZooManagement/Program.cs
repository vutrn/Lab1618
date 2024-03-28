using ZooManagement;

Animal animal = new Animal();
animal.Sample();

int choice = 0;
do
{
    Console.WriteLine("------------Animal Manager------------");
    animal.ViewAnimals();
    Console.WriteLine();
    Console.WriteLine("Select an action:");
    Console.WriteLine("1. Create an animal");
    Console.WriteLine("2. Update");
    Console.WriteLine("3. Search");
    Console.WriteLine("4. Delete");
    Console.WriteLine("0. Exit");

    Console.Write("Select an option: ");
    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            animal.CreateAnimal();
            Console.ReadKey();
            Console.Clear();
            break;
        case "2":
            animal.UpdateAnimal();
            Console.ReadKey();
            Console.Clear();
            break;
        case "3":
            animal.Search();
            Console.ReadKey();
            Console.Clear();
            break;
        case "4":
            animal.DeleteAnimal();
            Console.ReadKey();
            Console.Clear();
            break;
        case "0":
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            Console.ReadKey();
            Console.Clear();
            break;
    }
} while (!(choice >= 1 && choice <= 3));






namespace ZooManagement;

public class Animal
{
    private int Id { get; }
    private string Name { get; set; }
    private int Age { get; set; }
    private byte Gender { get; set; }
    private string Species { get; set; }
    private string Desc { get; set; }
    private List<Animal> Animals = new List<Animal>();
    private static int COUNT = 101;

    public Animal() { }

    public Animal(string name, int age, byte gender, string species, string desc)
    {
        Id = COUNT++;
        Name = name;
        Age = age;
        Gender = gender;
        Species = species;
        Desc = desc;
    }

    public void Sample()
    {
        Animals = new List<Animal>
        {
            new Animal("Pikun", 2, 1, "Cat", "Cute"),
            new Animal("Phong", 21, 1, "Monkey", "Ngu")
        };
    }

    public void CreateAnimal()
    {
        //? Name
        do
        {
            Console.Write("Animal Name: ");
            Name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(Name))
            {
                Console.WriteLine("Animal name cannot be blank. Please try again.");
            }
        } while (string.IsNullOrWhiteSpace(Name));


        //? Input Age
        bool isValidAge = false;
        do
        {
            Console.Write("Age: ");
            Age = int.Parse(Console.ReadLine());
            if (Age > 0)
            {
                isValidAge = true;
            }
            else
            {
                Console.WriteLine("Age cannot be negative. Please try again.");
            }
        } while (!isValidAge);

        //? Input gender
        bool isValidGender = false;
        do
        {
            Console.Write("Gender (1. Male / 2. Female / 3. Unknown): ");
            Gender = byte.Parse(Console.ReadLine());

            if (Gender == 1 || Gender == 2 || Gender == 3)
            {
                isValidGender = true;
            }
            if (!isValidGender)
            {
                Console.WriteLine("Invalid gender input. Please try again.");
            }
        } while (!isValidGender);

        //? Input Species
        do
        {
            Console.Write("Species: ");
            Species = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(Species))
            {
                Console.WriteLine("Species cannot be blank. Please try again.");
            }
        } while (string.IsNullOrWhiteSpace(Species));

        //? Desc     
        Console.Write("Animal Description: ");
        Desc = Console.ReadLine();

        Animals.Add(new Animal(Name, Age, Gender, Species, Desc));
    }

    public void ViewAnimals()
    {

        if (Animals.Count == 0)
        {
            Console.WriteLine("No animals found.");
        }
        else
        {
            Console.WriteLine("+-----+-----------------+----------+----------+----------+--------------------+");
            Console.WriteLine("| ID  |      Name       |   Age    |  Gender  |  Species |     Description    |");
            Console.WriteLine("+-----+-----------------+----------+----------+----------+--------------------+");
            foreach (var item in Animals)
            {
                string genderText = item.Gender == 1 ? "Male" : (item.Gender == 2 ? "Female" : "Unknown");
                Console.WriteLine($"| {item.Id,-4}| {item.Name,-15} | {item.Age,-8} | {genderText,-8} | {item.Species,-8} | {item.Desc,-18} | ");
            }
            Console.WriteLine("+-----+-----------------+----------+----------+----------+--------------------+");
        }
    }

    public void UpdateAnimal()
    {
        Console.Write("Input ID: ");
        int input = int.Parse(Console.ReadLine());
        Animal animal = Animals.Find(x => x.Id == input);

        if (animal == null)
        {
            Console.WriteLine("Animal not found.");
            return;
        }

        Console.Write("New animal name: ");
        var newName = Console.ReadLine();
        do
        {
            if (!string.IsNullOrWhiteSpace(newName))
            {
                animal.Name = newName;
            }
            else
            {
                Console.WriteLine("Animal name cannot be blank.");
            }
        } while (string.IsNullOrWhiteSpace(newName));

        bool isValidAge = false;
        Console.Write("New Age: ");
        var newAge = int.Parse(Console.ReadLine());
        do
        {
            if (newAge > 0)
            {
                isValidAge = true;
                animal.Age = newAge;
            }
            else
            {
                Console.WriteLine("Age cannot be negative. Please try again.");
            }
        } while (!isValidAge);

        bool isValidGender = false;
        Console.Write("New gender (1. Male / 2. Female / 3. Unknown): ");
        var newGender = byte.Parse(Console.ReadLine());
        do
        {
            if (newGender == 1 || newGender == 2 || newGender == 3)
            {
                isValidGender = true;
                animal.Gender = newGender;
            }
            if (!isValidGender)
            {
                Console.WriteLine("Invalid gender input. Please try again.");
            }
        } while (!isValidGender);

        Console.Write("New Species: ");
        string newSpecies = Console.ReadLine();
        do
        {
            if (!string.IsNullOrWhiteSpace(Species))
            {
                animal.Species = newSpecies;
            }
            else
            {
                Console.WriteLine("Species cannot be blank. Please try again.");
            }
        } while (string.IsNullOrWhiteSpace(Species));

        Console.Write("New Description: ");
        string newDesc = Console.ReadLine();
        animal.Desc = newDesc;
    }

    public void DeleteAnimal()
    {
        Console.Write("Input ID: ");
        int input = int.Parse(Console.ReadLine());
        Animal animal = Animals.Find(x => x.Id == input);
        if (animal == null)
        {
            Console.WriteLine("Animal not found.");
            return;
        }
        Animals.Remove(animal);
        Console.WriteLine($"Animal {animal.Name} has been deleted.");
    }

    public void Search()
    {
        Console.Write("Input ID: ");
        int input = int.Parse(Console.ReadLine());
        Animal animal = Animals.Find(x => x.Id == input);
        if (animal == null)
        {
            Console.WriteLine("Animal not found.");
            return;
        }   
        Console.WriteLine($"ID         : {animal.Id}");
        Console.WriteLine($"Name       : {animal.Name}");
        Console.WriteLine($"Age        : {animal.Age}");
        Console.WriteLine($"Gender     : {animal.Gender}");
        Console.WriteLine($"Species    : {animal.Species}");
        Console.WriteLine($"Description: {animal.Desc}");
    }

}



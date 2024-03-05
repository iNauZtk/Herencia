class Program
{
    static void Main()
    {
        // Create a list to hold the farm animals
        List<Animal> farmAnimals = new List<Animal>();

        Console.WriteLine("Welcome to the Farm Simulator!");

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add a Cow");
            Console.WriteLine("2. Add a Chicken");
            Console.WriteLine("3. Display Animal Sounds");
            Console.WriteLine("4. Exit");

            // Get user input
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the name of the Cow: ");
                    string cowName = Console.ReadLine();
                    Cow cow = new Cow(cowName);
                    farmAnimals.Add(cow);
                    Console.WriteLine($"{cowName} the Cow has been added to the farm!");
                    break;

                case "2":
                    Console.Write("Enter the name of the Chicken: ");
                    string chickenName = Console.ReadLine();
                    Chicken chicken = new Chicken(chickenName);
                    farmAnimals.Add(chicken);
                    Console.WriteLine($"{chickenName} the Chicken has been added to the farm!");
                    break;

                case "3":
                    Console.WriteLine("\nAnimal Sounds on the Farm:");
                    foreach (Animal animal in farmAnimals)
                    {
                        Console.WriteLine(animal.MakeSound());
                    }
                    break;

                case "4":
                    Console.WriteLine("Exiting the Farm Simulator. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }
        }
    }
}

//Explanation:

//The Animal, Cow, and Chicken classes are the same as before, representing the base class and two derived classes for animals.

//The Main method in the Program class serves as the entry point for the console application. It provides a simple menu for the user to add cows, add chickens, display animal sounds, or exit the program.

//The program uses a List<Animal> to keep track of the farm animals and allows the user to interactively add cows and chickens to the farm.

//The MakeSound method is called for each animal to display their sound when showing the list of animal sounds on the farm.
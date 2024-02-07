using System;

    class Program
    {
        
        static void Main(string[] args)
        {
        string type;
        string name;
        int hunger = 5;
        int happiness = 5;
        int health = 5;
        int time = 0;

        int choice;

            Console.WriteLine("Welcome to Virtual Pet!");
            Console.WriteLine("Choose a pet type (e.g., cat, dog, rabbit):");
            type = Console.ReadLine();
            Console.WriteLine("Enter your pet's name:");
            name = Console.ReadLine();



            Console.WriteLine($"\nWelcome, let's play with {name} the {type}!");

            while (true)
            {
                Console.WriteLine("\nChoose an action:");
                Console.WriteLine("1. Feed");
                Console.WriteLine("2. Play");
                Console.WriteLine("3. Rest");
                Console.WriteLine("4. Check status");
                Console.WriteLine("5. Pass Time");
                Console.WriteLine("6. Exit");

                choice=int.Parse(Console.ReadLine());
                

                switch (choice)
                {
                    case 1:

                    if(hunger <= 2)
                    {
                        Console.WriteLine($"{name} is too full! Please select any other option, or play with him.");
                        Console.WriteLine($"\n{name}'s status:");
                        Console.WriteLine($"Hunger: {hunger}/10");
                        Console.WriteLine($"Happiness: {happiness}/10");
                        Console.WriteLine($"Health: {health}/10");

                        if (hunger <= 2)
                            Console.WriteLine("Warning: Hunger is critically low!");
                        if (happiness <= 2)
                            Console.WriteLine("Warning: Happiness is critically low!");
                        if (health <= 2)
                            Console.WriteLine("Warning: Health is critically low!");
                        break;
                    }

                    hunger -= 2;
                    health++;
                    Console.WriteLine($"{name} has been fed. Hunger decreased and health increased.");
                    
                    Console.WriteLine($"\n{name}'s status:");
                    Console.WriteLine($"Hunger: {hunger}/10");
                    Console.WriteLine($"Happiness: {happiness}/10");
                    Console.WriteLine($"Health: {health}/10");

                    if (hunger <= 2)
                        Console.WriteLine("Warning: Hunger is critically low!");
                    if (happiness <= 2)
                        Console.WriteLine("Warning: Happiness is critically low!");
                    if (health <= 2)
                        Console.WriteLine("Warning: Health is critically low!");

                    break;

                    case 2:

                    if (hunger >= 8)
                    {
                        Console.WriteLine($"{name} is too hungry. Please feed him before he can play.");
                        health--;
                        Console.WriteLine($"\n{name}'s status:");
                        Console.WriteLine($"Hunger: {hunger}/10");
                        Console.WriteLine($"Happiness: {happiness}/10");
                        Console.WriteLine($"Health: {health}/10");

                        if (hunger <= 2)
                            Console.WriteLine("Warning: Hunger is critically low!");
                        if (happiness <= 2)
                            Console.WriteLine("Warning: Happiness is critically low!");
                        if (health <= 2)
                            Console.WriteLine("Warning: Health is critically low!");
                        break;
                    }

                    happiness += 2;
                    hunger++;
                    Console.WriteLine($"{name} is playing. Happiness increased and hunger increased slightly.");
                    Console.WriteLine($"\n{name}'s status:");
                    Console.WriteLine($"Hunger: {hunger}/10");
                    Console.WriteLine($"Happiness: {happiness}/10");
                    Console.WriteLine($"Health: {health}/10");

                    if (hunger <= 2)
                        Console.WriteLine("Warning: Hunger is critically low!");
                    if (happiness <= 2)
                        Console.WriteLine("Warning: Happiness is critically low!");
                    if (health <= 2)
                        Console.WriteLine("Warning: Health is critically low!");

                    break;

                    case 3:
                    if(happiness <= 2)
                    {
                        Console.WriteLine($"{name} is not happy, and has rested enough. Play with him for a bit.");
                        health--;
                        Console.WriteLine($"\n{name}'s status:");
                        Console.WriteLine($"Hunger: {hunger}/10");
                        Console.WriteLine($"Happiness: {happiness}/10");
                        Console.WriteLine($"Health: {health}/10");

                        if (hunger <= 2)
                            Console.WriteLine("Warning: Hunger is critically low!");
                        if (happiness <= 2)
                            Console.WriteLine("Warning: Happiness is critically low!");
                        if (health <= 2)
                            Console.WriteLine("Warning: Health is critically low!");
                        break;
                    }

                    health += 2;
                    happiness--;
                    Console.WriteLine($"{name} is resting. Health increased and happiness decreased slightly.");
                    Console.WriteLine($"\n{name}'s status:");
                    Console.WriteLine($"Hunger: {hunger}/10");
                    Console.WriteLine($"Happiness: {happiness}/10");
                    Console.WriteLine($"Health: {health}/10");

                    if (hunger <= 2)
                        Console.WriteLine("Warning: Hunger is critically low!");
                    if (happiness <= 2)
                        Console.WriteLine("Warning: Happiness is critically low!");
                    if (health <= 2)
                        Console.WriteLine("Warning: Health is critically low!");
                    break;

                    case 4:
                    Console.WriteLine($"\n{name}'s status:");
                    Console.WriteLine($"Hunger: {hunger}/10");
                    Console.WriteLine($"Happiness: {happiness}/10");
                    Console.WriteLine($"Health: {health}/10");

                    if (hunger <= 2)
                        Console.WriteLine("Warning: Hunger is critically low!");
                    if (happiness <= 2)
                        Console.WriteLine("Warning: Happiness is critically low!");
                    if (health <= 2)
                        Console.WriteLine("Warning: Health is critically low!");
                    break;

                    case 5:
                    hunger++;
                    happiness--;
                    Console.WriteLine("Time has passed. Hunger has increased, happiness has decreased.");
                    Console.WriteLine($"\n{name}'s status:");
                    Console.WriteLine($"Hunger: {hunger}/10");
                    Console.WriteLine($"Happiness: {happiness}/10");
                    Console.WriteLine($"Health: {health}/10");

                    if (hunger <= 2)
                        Console.WriteLine("Warning: Hunger is critically low!");
                    if (happiness <= 2)
                        Console.WriteLine("Warning: Happiness is critically low!");
                    if (health <= 2)
                        Console.WriteLine("Warning: Health is critically low!");
                    break;


                    case 6:
                        Console.WriteLine($"Thank you for playing with {name}! We hope to see you soon again!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please choose again.");
                        break;
                }
            }
        }







        
    }




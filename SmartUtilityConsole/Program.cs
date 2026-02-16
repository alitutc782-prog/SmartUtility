b:
Console.Clear();
Console.WriteLine("===== Smart Utility Console App =====");
Console.WriteLine(
    "1. Number Analyzer\n" +
    "2. Geometry Zone\n" +
    "3. Text Tools\n" +
    "4. Exit");
Console.Write("Select a utility (1-4): ");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{

    case 1:
    numberMenu:
        Console.Clear();
        Console.WriteLine("=== Number Analyzer ===");
        Console.WriteLine(
            "1. Son juft yoki toqligini aniqlash\n" +
            "2. Son musbat, manfiy yoki nol\n" +
            "3. Sonning kvadrati va kubi\n" +
            "4. Exit");
        Console.Write("Enter your command (1-4): ");
        int cmd1 = Convert.ToInt32(Console.ReadLine());

        if (cmd1 >= 1 && cmd1 <= 3)
        {
            Console.Write("Enter your number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (cmd1 == 1)
                Console.WriteLine(number % 2 == 0 ? "Even" : "Odd");
            else if (cmd1 == 2)
                Console.WriteLine(number > 0 ? "Positive" : number < 0 ? "Negative" : "Zero");
            else
            {
                Console.WriteLine($"Square: {Math.Pow(number, 2)}");
                Console.WriteLine($"Cube: {Math.Pow(number, 3)}");
            }
        }
        else if (cmd1 == 4)
            goto b;

        Console.Write("Return Number Analyzer (y/n): ");
        if (Console.ReadLine().ToLower().StartsWith("y"))
            goto numberMenu;
        else
            goto b;


    case 2:
    geometryMenu:
        Console.Clear();
        Console.WriteLine("=== Geometry Zone ===");
        Console.WriteLine(
            "1. Rectangle\n" +
            "2. Triangle\n" +
            "3. Circle\n" +
            "4. Exit");
        Console.Write("Enter your command (1-4): ");
        int cmd2 = Convert.ToInt32(Console.ReadLine());

        if (cmd2 == 1)
        {
            Console.Write("Length: ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.Write("Width: ");
            double w = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area: {l * w}");
        }
        else if (cmd2 == 2)
        {
            Console.Write("Base: ");
            double bLen = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area: {(bLen * h) / 2}");
        }
        else if (cmd2 == 3)
        {
            Console.Write("Radius: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area: {Math.PI * r * r}");
        }
        else if (cmd2 == 4)
            goto b;

        Console.Write("Return Geometry Zone (y/n): ");
        if (Console.ReadLine().ToLower().StartsWith("y"))
            goto geometryMenu;
        else
            goto b;


    case 3:
    textMenu:
        Console.Clear();
        Console.WriteLine("=== Text Tools ===");
        Console.WriteLine(
            "1. Matn uzunligi\n" +
            "2. Katta harflar\n" +
            "3. Teskari matn\n" +
            "4. Exit");
        Console.Write("Enter your command (1-4): ");
        int cmd3 = Convert.ToInt32(Console.ReadLine());

        if (cmd3 >= 1 && cmd3 <= 3)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            if (cmd3 == 1)
                Console.WriteLine($"Length: {text.Length}");
            else if (cmd3 == 2)
                Console.WriteLine(text.ToUpper());
            else
            {
                char[] arr = text.ToCharArray();
                Array.Reverse(arr);
                Console.WriteLine(new string(arr));
            }
        }
        else if (cmd3 == 4)
            goto b;

        Console.Write("Return Text Tools (y/n): ");
        if (Console.ReadLine().ToLower().StartsWith("y"))
            goto textMenu;
        else
            goto b;


    case 4:
        Console.WriteLine("Exiting... Goodbye!");
        break;

    default:
        Console.WriteLine("Invalid choice!");
        goto b;
}

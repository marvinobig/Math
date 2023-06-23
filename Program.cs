Console.WriteLine("Maths - console app for learning maths!");

Console.Write("What is your name? ");
string? username = Console.ReadLine();
string[] availableChoices = new string[5] { "a", "s", "m", "d", "q" };

Menu(username, 41);

try
{
    string? userChoice;

    do
    {
        userChoice = Console.ReadKey().KeyChar.ToString().ToLower();

        if (!availableChoices.Contains(userChoice))
        {
            Console.WriteLine("");
            Console.Write($"{userChoice} is not available, please choose another: ");
        }
    }
    while (!availableChoices.Contains(userChoice));

    if (availableChoices.Contains(userChoice))
    {
        Console.WriteLine("");

        if (userChoice == "a") Addition("Addition game selected");
        if (userChoice == "s") Subtraction("Subtraction game selected");
        if (userChoice == "m") Multiplication("Multiplication game selected");
        if (userChoice == "d") Division("Division game selected");
        if (userChoice == "q") Quit("Goodbye");
    }
}
catch (Exception err)
{
    Console.WriteLine("");
    Console.WriteLine(err.Message);
    Environment.Exit(1);
}


Console.WriteLine("Press any key to exit");
Console.ReadLine();

void Menu(string? username, int seperatorLineLength)
{
    Console.WriteLine($"What would you like to study {username}? ");

    for (int i = 0; i < seperatorLineLength; i++)
    {
        Console.Write('-');
    }

    Console.WriteLine("");

    Console.WriteLine(@"
        Addition: press the 'a' key
        Substraction: press the 's' key
        Multiplication: press the 'm' key
        Division: press the 'd' key
        Quit: press the 'q' key
    ");

    for (int i = 0; i < seperatorLineLength; i++)
    {
        Console.Write('-');
    }

    Console.WriteLine("");
    Console.Write("Game Choice: ");
}

void Addition(string msg)
{
    Random random = new Random();
    Console.WriteLine(msg);
}

void Subtraction(string msg)
{
    Console.WriteLine(msg);
}

void Multiplication(string msg)
{
    Console.WriteLine(msg);
}

void Division(string msg)
{
    Console.WriteLine(msg);
}

void Quit(string msg)
{
    Console.WriteLine(msg);
    Environment.Exit(1);
}
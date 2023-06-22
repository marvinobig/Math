Console.WriteLine("Maths - console app for learning maths!");

Console.Write("What is your name? ");
string? username = Console.ReadLine();
char[] availableChoices = new char[5] { 'a', 's', 'm', 'd', 'q' };

Console.WriteLine($"What would you like to study {username}? ");
Console.WriteLine(@"
Addition: press the 'a' key
Substraction: press the 's' key
Multiplication: press the 'm' key
Division: press the 'd' key
Quit: press the 'q' key
");

try
{
    char userChoice = Console.ReadKey().KeyChar;

    if (availableChoices.Contains(userChoice))
    {
        Console.WriteLine("");
        Console.WriteLine($"You have chosen {userChoice}");
    }
    else
    {
        throw new Exception($"{userChoice} is not an option");
    }
}
catch (Exception err)
{
    Console.WriteLine("");
    Console.WriteLine(err.Message);
}



Console.WriteLine("Press any key to exit");
Console.ReadLine();

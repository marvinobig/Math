Console.WriteLine("Maths - console app for learning maths!");

Console.Write("What is your name? ");
string? username = Console.ReadLine();
string[] availableChoices = new string[5] { "a", "s", "m", "d", "q" };
int[] mathNumsList = { 23, 45, 56, 78, 23, 78, 46, 98, 2, 10 };
List<string[]> history = new List<string[]>();

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

        if (userChoice == "a") Addition("Addition game selected", mathNumsList, history);
        if (userChoice == "s") Subtraction("Subtraction game selected", mathNumsList, history);
        if (userChoice == "m") Multiplication("Multiplication game selected", mathNumsList, history);
        if (userChoice == "d") Division("Division game selected", mathNumsList, history);
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

void Addition(string msg, int[] mathNums, List<string[]> history)
{
    Console.WriteLine(msg);

    Console.Write("How many questions do you want to answer? ");
    string? userNumOfRounds = Console.ReadLine();

    bool howManyRounds = int.TryParse(userNumOfRounds, out int numOfQuestions);

    if (!howManyRounds) throw new Exception($"{userNumOfRounds} is not a number");

    for (int i = 0; i < numOfQuestions; i++)
    {
        Random random = new Random();
        int firstNum = mathNums[random.Next(10)];
        int secondNum = mathNums[random.Next(10)];
        int total = firstNum + secondNum;

        Console.WriteLine("");
        Console.Write($"What is {firstNum} + {secondNum} ? ");

        string? userAnswer = Console.ReadLine();
        bool isThisANumber = int.TryParse(userAnswer, out int result);

        if (isThisANumber)
        {
            if (result == total)
            {
                string[] qaHistory = new string[5] { $"Game choice: Addition", $"Q: {firstNum} + {secondNum}", $"A: {total}", $"Your answer: {result}", "Status: Correct" };
                history.Add(qaHistory);
                Console.WriteLine($"Your answered: {result}. That is correct");
            }
            else
            {
                string[] qaHistory = { $"Game choice: Addition", $"Q: {firstNum} + {secondNum}", $"A: {total}", $"Your answer: {result}", "Status: Incorrect" };
                history.Add(qaHistory);
                Console.WriteLine($"That is incorrect. The correct answer is {total}");
            }
        }
        else
        {
            throw new Exception($"The value '{userAnswer}' is not a number");
        }
    }

    Console.Clear();
    Console.WriteLine("Question & Answer History:");

    foreach (string[] questionAnswer in history)
    {
        DisplayHistory(questionAnswer);
    }
}

void Subtraction(string msg, int[] mathNums, List<string[]> history)
{
    Console.WriteLine(msg);

    Console.Write("How many questions do you want to answer? ");
    string? userNumOfRounds = Console.ReadLine();

    bool howManyRounds = int.TryParse(userNumOfRounds, out int numOfQuestions);

    if (!howManyRounds) throw new Exception($"{userNumOfRounds} is not a number");

    for (int i = 0; i < numOfQuestions; i++)
    {
        Random random = new Random();
        int firstNum = mathNums[random.Next(10)];
        int secondNum = mathNums[random.Next(10)];
        int total = firstNum - secondNum;

        Console.WriteLine("");
        Console.Write($"What is {firstNum} - {secondNum} ? ");

        string? userAnswer = Console.ReadLine();
        bool isThisANumber = int.TryParse(userAnswer, out int result);

        if (isThisANumber)
        {
            if (result == total)
            {
                string[] qaHistory = new string[5] { $"Game choice: Subtraction", $"Q: {firstNum} - {secondNum}", $"A: {total}", $"Your answer: {result}", "Status: Correct" };
                history.Add(qaHistory);
                Console.WriteLine($"Your answered: {result}. That is correct");
            }
            else
            {
                string[] qaHistory = { $"Game choice: Subtraction", $"Q: {firstNum} - {secondNum}", $"A: {total}", $"Your answer: {result}", "Status: Incorrect" };
                history.Add(qaHistory);
                Console.WriteLine($"That is incorrect. The correct answer is {total}");
            }
        }
        else
        {
            throw new Exception($"The value '{userAnswer}' is not a number");
        }
    }

    Console.Clear();
    Console.WriteLine("Question & Answer History:");

    foreach (string[] questionAnswer in history)
    {
        DisplayHistory(questionAnswer);
    }
}

void Multiplication(string msg, int[] mathNums, List<string[]> history)
{
    Console.WriteLine(msg);

    Console.Write("How many questions do you want to answer? ");
    string? userNumOfRounds = Console.ReadLine();

    bool howManyRounds = int.TryParse(userNumOfRounds, out int numOfQuestions);

    if (!howManyRounds) throw new Exception($"{userNumOfRounds} is not a number");

    for (int i = 0; i < numOfQuestions; i++)
    {
        Random random = new Random();
        int firstNum = mathNums[random.Next(10)];
        int secondNum = mathNums[random.Next(10)];
        int total = firstNum * secondNum;

        Console.WriteLine("");
        Console.Write($"What is {firstNum} x {secondNum} ? ");

        string? userAnswer = Console.ReadLine();
        bool isThisANumber = int.TryParse(userAnswer, out int result);

        if (isThisANumber)
        {
            if (result == total)
            {
                string[] qaHistory = new string[5] { $"Game choice: Multiplication", $"Q: {firstNum} x {secondNum}", $"A: {total}", $"Your answer: {result}", "Status: Correct" };
                history.Add(qaHistory);
                Console.WriteLine($"Your answered: {result}. That is correct");
            }
            else
            {
                string[] qaHistory = { $"Game choice: Multiplication", $"Q: {firstNum} x {secondNum}", $"A: {total}", $"Your answer: {result}", "Status: Incorrect" };
                history.Add(qaHistory);
                Console.WriteLine($"That is incorrect. The correct answer is {total}");
            }
        }
        else
        {
            throw new Exception($"The value '{userAnswer}' is not a number");
        }
    }

    Console.Clear();
    Console.WriteLine("Question & Answer History:");

    foreach (string[] questionAnswer in history)
    {
        DisplayHistory(questionAnswer);
    }
}

void Division(string msg, int[] mathNums, List<string[]> history)
{
    Console.WriteLine(msg);

    Console.Write("How many questions do you want to answer? ");
    string? userNumOfRounds = Console.ReadLine();

    bool howManyRounds = int.TryParse(userNumOfRounds, out int numOfQuestions);

    if (!howManyRounds) throw new Exception($"{userNumOfRounds} is not a number");

    for (int i = 0; i < numOfQuestions; i++)
    {
        Random random = new Random();
        int firstNum = mathNums[random.Next(10)];
        int secondNum = mathNums[random.Next(10)];
        int total = firstNum / secondNum;

        Console.WriteLine("");
        Console.Write($"What is {firstNum} \u00F7 {secondNum} ? ");

        string? userAnswer = Console.ReadLine();
        bool isThisANumber = int.TryParse(userAnswer, out int result);

        if (isThisANumber)
        {
            if (result == total)
            {
                string[] qaHistory = new string[5] { $"Game choice: Division", $"Q: {firstNum} \u00F7 {secondNum}", $"A: {total}", $"Your answer: {result}", "Status: Correct" };
                history.Add(qaHistory);
                Console.WriteLine($"Your answered: {result}. That is correct");
            }
            else
            {
                string[] qaHistory = { $"Game choice: Division", $"Q: {firstNum} \u00F7 {secondNum}", $"A: {total}", $"Your answer: {result}", "Status: Incorrect" };
                history.Add(qaHistory);
                Console.WriteLine($"That is incorrect. The correct answer is {total}");
            }
        }
        else
        {
            throw new Exception($"The value '{userAnswer}' is not a number");
        }
    }

    Console.Clear();
    Console.WriteLine("Question & Answer History:");

    foreach (string[] questionAnswer in history)
    {
        DisplayHistory(questionAnswer);
    }
}

void DisplayHistory(string[] history)
{
    Console.WriteLine("");

    for (int i = 0;i < history.Length;i++)
    {
        Console.WriteLine(history[i]);
    }
}

void Quit(string msg)
{
    Console.WriteLine(msg);
    Environment.Exit(1);
}
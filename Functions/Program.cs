// Fuktsioon (function) ehk meetod (method)

Console.WriteLine("Are you coming or leaving?: in/out");
String userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}

static void PrintHello()
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, alligator.");
}
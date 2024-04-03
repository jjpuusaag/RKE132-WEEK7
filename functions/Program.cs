Console.WriteLine("Are you leaving or staying? (in/out)");
string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    printHello();
}
if (userChoice == "out")
{
    printGoodBye();
}
else
{
    Console.WriteLine("Invalid input.");
}

static void printHello()
{
    Console.WriteLine("Hello, world!");
}

static void printGoodBye()
{
    Console.WriteLine("See you later, alligator.");
}

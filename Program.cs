// See https://aka.ms/new-console-template for more information

string input;
int tickOrTock;
Console.Write("What is the clock tower input number? ");

input = Console.ReadLine();
tickOrTock = Convert.ToInt32(input);

if (tickOrTock == 0)
{
    Console.WriteLine("The number provided was zero. This is not even or odd");
}
else if (tickOrTock % 2 == 0)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}

Console.ReadKey();
// See https://aka.ms/new-console-template for more information

string input;
int tickOrTock;
Console.Write("What is the clock tower input number? ");

input = Console.ReadLine();
tickOrTock = Convert.ToInt32(input);

if (tickOrTock % 2 == 0)
{
    Console.WriteLine("Tick");
}
Console.WriteLine("Tock");


Console.ReadKey();
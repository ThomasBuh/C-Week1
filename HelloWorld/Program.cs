// See https://aka.ms/new-console-template for more information

Console.Write("Welke planeet: ");

string planeet = Console.ReadLine();

Console.Write("Hoeveel keer: ");
string aantal = Console.ReadLine();

int aantalInt = Int32.Parse(aantal);

for (int i = 0; i < aantalInt; i++)
{
    Console.WriteLine($"({i+1} van de {aantalInt}): Jouw planeet: {planeet}");
}


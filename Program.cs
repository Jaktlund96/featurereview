Console.Write("Vänligen ange ditt namn:");
string name = Console.ReadLine();
if (string .IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Du måste ange ett namn");
}
else
{
    Console.WriteLine($"Välkommen {name}");
}

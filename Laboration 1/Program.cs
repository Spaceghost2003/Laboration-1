introSplash();

Console.WriteLine("Skriv in en sträng!");
string userInput = Console.ReadLine();
Console.WriteLine("***********************************");

long sumOfNumbers = 0;

for (int i = 0; i < userInput.Length; i++)
{
    for (int k = i; k < userInput.Length; k++)
    {
        if (!char.IsAsciiDigit(userInput[k]))
        {
            break;
        }
        if (userInput[i] == userInput[k] && k != i)
        {
            sumOfNumbers += long.Parse(userInput[i..(k + 1)]);

            Console.Write(userInput[0..i]);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(userInput[i..(k + 1)]);
            Console.ResetColor();
            Console.Write(userInput[(k + 1)..(userInput.Length)] + "\n");

            break;
        }
    }
}
Console.WriteLine("***********************************");
Console.WriteLine($"Summan av talen är: {sumOfNumbers}");
static void introSplash()
{
    Console.WriteLine(@"
              ,---------------------------,
              |  /---------------------\  |
              | |                       | |
              | |   tryck på en tangent | |
              | |       för att         | |
              | |   starta programmet   | |
              | |                       | |
              |  \_____________________/  |
              |___________________________|
            ,---\_____     []     _______/------,
          /         /______________\           /|
        /___________________________________ /  | ___
        |                                   |   |    )
        |  _ _ _                 [-------]  |   |   (
        |  o o o                 [-------]  |  /    _)_
        |__________________________________ |/     /  /
    /-------------------------------------/|      ( )/
  /-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/ /
/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/ /
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    Console.ReadKey();
    Console.Clear();

}
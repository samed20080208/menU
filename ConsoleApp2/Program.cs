using System;
Console.WriteLine();
Console.WriteLine();
string[] emeliyyatlar = { "    secim1 ", "   secim2 ", "    exit " };

ConsoleKeyInfo keyInfo;
int secim = 0;

do
{
    Console.Clear();
    MenyuGoster(emeliyyatlar, secim);

    keyInfo = Console.ReadKey();

    switch (keyInfo.Key)
    {
        case ConsoleKey.UpArrow when secim > 0:
            secim--;
            break;
        case ConsoleKey.DownArrow when secim < emeliyyatlar.Length - 1:
            secim++;
            break;
        case ConsoleKey.Enter:
            if (secim < emeliyyatlar.Length - 1)
            {
                Console.WriteLine("\n okey");
                Console.ReadKey();
            }
            else
            {
                Environment.Exit(0);
            }
            break;
    }
} while (keyInfo.Key != ConsoleKey.Escape);

static void MenyuGoster(string[] secimler, int secilenIndex)
{
    for (int i = 0; i < secimler.Length; i++)
    {
        if (i == secilenIndex)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }

        Console.WriteLine($"{i + 1}. {(i == secilenIndex ? "~" : "")}{secimler[i]}");

        Console.ResetColor();
    }

}

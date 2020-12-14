using System;

Print("Hello World!");

foreach (var arg in args)
    Print(arg);

Console.WriteLine("Type text to print or hit enter to exit");

while (true)
{
    var lineText = Console.ReadLine();

    if (lineText.Length == 0)
        break;

    Print(lineText);
}

void Print(string outputText) =>
    Console.WriteLine(outputText);
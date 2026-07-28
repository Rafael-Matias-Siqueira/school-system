using System;

namespace SchoolSystem.Tests;

public class Sandbox
{
    public static void Main()
    {
        Console.WriteLine(char.IsLetter('a'));
        Console.WriteLine(char.IsLetter('ç'));
        Console.WriteLine(char.IsLetter('ã'));
        Console.WriteLine(char.IsLetter('1'));
        Console.WriteLine(char.IsLetter('@'));
        Console.WriteLine(char.IsLetter('-'));
    }
}

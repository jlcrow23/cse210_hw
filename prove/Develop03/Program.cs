using Internal;
using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new ScriptureRef(John,3,5);
        Console.WriteLine(r1.GetScripRef);

        // // This will start by displaying "AAA" and waiting for the user to press the enter key
        // Console.WriteLine("AAA");
        // Console.ReadLine();

        // // This will clear the console
        // Console.Clear();

        // // This will show "BBB" in the console where "AAA" used to be
        // Console.WriteLine("BBB");

        Console.WriteLine("Hello Develop03 World!");
    }
}
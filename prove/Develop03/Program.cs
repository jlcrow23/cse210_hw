
using System.Collections.Concurrent;
using System.Runtime.Serialization;
using System.Reflection.Emit;
using System.Data;
using System;

class Program
{
    static void Main(string[] args)
    {
        
        Reference r1 = new Reference("Mosiah",3,19);
        Console.WriteLine(r1.GetDisplayText());

        Reference r2 = new Reference("Mosiah",3,19,20);
        Console.WriteLine(r2.GetDisplayText());

        Console.Clear();
        Console.Write(r1.GetFullScripRef + " ");
        Console.Write("scripture Here");

        Console.WriteLine("Hello Develop03 World!");
    }
}
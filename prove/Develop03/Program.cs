
using System.Collections.Concurrent;
using System.Runtime.Serialization;
using System.Reflection.Emit;
using System.Data;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Reference r1= new Reference("John",3,5);
        Scripture s1 = new Scripture();
        // r1.GetDisplayText();

        // Reference r2 = new Reference("Mosiah",3,19,20);
        // r2.GetDisplayText();

        Word.Hide();
    }
}
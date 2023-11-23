using System.Reflection.Emit;
using System.Data;
using Microsoft.Win32.SafeHandles;
using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Julie Crowther", "Addition");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Wayne Crow", "Calculus", "5.2", "12-24");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Kenadhe Elordi", "The History of Dance", "The Tango");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}
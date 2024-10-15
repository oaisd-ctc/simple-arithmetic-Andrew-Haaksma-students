// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main(string[] args)
    {
        /* Addition with 2 random plugged in numbers */
        Console.WriteLine("Provide 1 number to perform a addition operation");
        string add1 = Console.ReadLine();
        int number1 = int.Parse(add1);

        Console.WriteLine(add1 + " got it. Provide a number to add to. " + add1);
        string add2 = Console.ReadLine();
        int number2 = int.Parse(add2);

        Console.WriteLine("alright! That's easy. " + add1 + " + " + add2 + " is " + (number1 + number2) + "!");


        /* Subtraction with 2 random plugged in numbers */
        Console.WriteLine("Provide 1 number to perform a Subtraction operation");
        string subtract1 = Console.ReadLine();
        int number3 = int.Parse(subtract1);

        Console.WriteLine(subtract1 + " got it. Provide a number to subtract to. " + subtract1);
        string subtract2 = Console.ReadLine();
        int number4 = int.Parse(subtract2);

        Console.WriteLine("alright! That's easy. " + subtract1 + " - " + subtract2 + " is " + (number3 - number4) + "!");

        
        /* Multiplication with 2 random plugged in numbers */
        Console.WriteLine("Provide 1 number to perform a Multiplication operation");
        string Multiplication1 = Console.ReadLine();
        int number5 = int.Parse(Multiplication1);

        Console.WriteLine(Multiplication1 + " got it. Provide a number to multiply to. " + Multiplication1);
        string Multiplication2 = Console.ReadLine();
        int number6 = int.Parse(Multiplication2);

        Console.WriteLine("alright! That's easy. " + Multiplication1 + " * " + Multiplication2 + " is " + (number5 * number6) + "!");


        /* Integer Division with 2 random plugged in numbers */
        Console.WriteLine("Provide 1 number to perform a Integer Division operation (please add .0 to the end or your number)");
        string divide1 = Console.ReadLine();
        int number7 = int.Parse(divide1);

        Console.WriteLine(divide1 + " got it. Provide a number to divide to. " + divide1 +"(please add .0 to the end or your number)");
        string divide2 = Console.ReadLine();
        int number8 = int.Parse(divide2);

        Console.WriteLine("alright! That's easy. " + divide1 + " / " + divide2 + " is " + (number7 / number8) + "!");


        /* Floating Point and Decimal Division with 2 random plugged in numbers */
        Console.WriteLine("Provide 1 number to perform a Floating Point operation");
        string Decimal1 = Console.ReadLine();
        float number9 = int.Parse(Decimal1);

        Console.WriteLine(Decimal1 + " got it. Provide a number to divide to. " + Decimal1);
        string Decimal2 = Console.ReadLine();
        float number10 = int.Parse(Decimal2);

        Console.WriteLine("alright! That's easy. " + Decimal1 + " / " + Decimal2 + " is " + (number9 / number10) + "!");

        
        /* Modulus with 2 random plugged in numbers */
        Console.WriteLine("Provide 1 number to perform a Modulus operation");
        string Modulus1 = Console.ReadLine();
        int number11 = int.Parse(Modulus1);

        Console.WriteLine(Modulus1 + " got it. Provide a number to divide to. " + Modulus1);
        string Modulus2 = Console.ReadLine();
        int number12 = int.Parse(Modulus2);

        Console.WriteLine("alright! That's easy. " + Modulus1 + " % " + Modulus2 + " is " + (number11 % number12) + "!");
    }
}
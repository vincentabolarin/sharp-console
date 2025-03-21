using System;

public class Operators
{

	private static double a = 8;
	private static int b = 3;
	public static void All()
	{
        Console.WriteLine("OPERATORS");
		Increment();
		Decrement();
		Addition();
		Subtraction();
		Multiplication();
		Division();
		Remainder();
	}

	private static void Increment()
	{
		a++;
        Console.WriteLine(a);
	}
	private static void Decrement()
	{
		b -= 1;
		Console.WriteLine(b);
	}
	private static void Addition()
	{
        Console.WriteLine(a + b);
	}
	private static void Subtraction()
	{
		Console.WriteLine(a - b);
	}
	private static void Multiplication()
	{
		Console.WriteLine(a * b);
	}
	private static void Division()
	{
		Console.WriteLine(a / b);
	}
	private static void Remainder()
	{
		Console.WriteLine(a % b);
	}
}

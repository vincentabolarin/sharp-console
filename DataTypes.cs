using System;

public class DataTypes
{
	public static void Examples()
	{
        Console.WriteLine("DATA TYPES");
        Console.WriteLine("Hello, World!");

        Console.WriteLine(int.MaxValue);
        Console.WriteLine(long.MaxValue);

        string ageText = "2";
        int age = Convert.ToInt32(ageText);
        Console.WriteLine(age);

        string bigNumberText = "-14500000000";
        long bigNumber = Convert.ToInt64(bigNumberText);
        Console.WriteLine(bigNumber);

        string negativeText = "-23.4";
        double negative = Convert.ToDouble(negativeText);
        Console.WriteLine(negative);

        string precisionText = "20000.2";
        float precision = Convert.ToSingle(precisionText);
        Console.WriteLine(precision);

        string moneyText = "19.99";
        decimal money = Convert.ToDecimal(moneyText);
        Console.WriteLine(money);

        bool isActive = false;
        Console.Write("Is account active? ");
        Console.WriteLine(isActive ? "Yes!" : "No!");
    }
}

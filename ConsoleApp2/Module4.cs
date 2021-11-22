using System;

class MainClass
{
	public static void Main(string[] args)
	{
		
	}

	public static void Task4_1_17()
	{

		Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

		var color = Console.ReadLine();

		if (color == "red")
		{
			Console.BackgroundColor = ConsoleColor.Red;
			Console.ForegroundColor = ConsoleColor.Black;

			Console.WriteLine("Your color is red!");
		}

		else if (color == "green")
		{
			Console.BackgroundColor = ConsoleColor.Green;
			Console.ForegroundColor = ConsoleColor.Black;

			Console.WriteLine("Your color is green!");
		}
		else
		{
			Console.BackgroundColor = ConsoleColor.Cyan;
			Console.ForegroundColor = ConsoleColor.Black;

			Console.WriteLine("Your color is cyan!");
		}
	}


	public static void Task3_3()
	{

		string MyName = "Moridin830";
		byte MyAge = 31;
		bool HaveIApet = true;
		double MyShoeSize = 42.5;

		Console.WriteLine("My name is " + MyName);
		Console.WriteLine("MyAge " + MyAge);
		Console.WriteLine("Do I have a pet? " + HaveIApet);
		Console.WriteLine("My shoe size is " + MyShoeSize);
	}

	public static void Task3_6()
	{
		double result = 5 / 2;
		Console.WriteLine("5 / 2 = {0}", result);
	}
}
using System;

class Module4
{
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


	public static void Task4_1_18()
	{

		Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

		var color = Console.ReadLine();

		switch (color)
		{
			case "red":
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is red!");
				break;

			case "green":
				Console.BackgroundColor = ConsoleColor.Green;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is green!");
				break;

			case "cian":
				Console.BackgroundColor = ConsoleColor.Cyan;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is green!");
				break;

			default:
				Console.BackgroundColor = ConsoleColor.Yellow;
				Console.ForegroundColor = ConsoleColor.Red;

				Console.WriteLine("Your color is cyan!");
				break;
		}
	}

	public static void Task4_2_1()
    {
		for (int i = 1; i < 5; i++)
		{
			Console.WriteLine("Iteration {0}", i);
			switch (Console.ReadLine())
			{
				case "red":
					Console.BackgroundColor = ConsoleColor.Red;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Your color is red!");
					break;

				case "green":
					Console.BackgroundColor = ConsoleColor.Green;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Your color is green!");
					break;

				case "cyan":
					Console.BackgroundColor = ConsoleColor.Cyan;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Your color is cyan!");
					break;
				default:
					Console.BackgroundColor = ConsoleColor.Yellow;
					Console.ForegroundColor = ConsoleColor.Black;

					Console.WriteLine("Your color is yellow!");
					break;
			}
		}
	}

	public static void Task4_3_7()
	{
		
		Console.WriteLine("Enter your name:");
		string InputName = Console.ReadLine();
			
		for (int CurrentIndex = (InputName.Length - 1); CurrentIndex >= 0; CurrentIndex--)
        {
			Console.Write(InputName[CurrentIndex]);
        }

		Console.Write("\n Press any key...");

		Console.ReadKey();
	}

	public static void Task4_3_11()
	{

		int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

		for (int ColumnIndex = 0; ColumnIndex <= array.GetUpperBound(1); ColumnIndex++)
        {
			
			for (int RowIndex = 0; RowIndex <= array.GetUpperBound(0); RowIndex++)
            {
				Console.Write(array[RowIndex, ColumnIndex] + " ");
            }

			Console.WriteLine();

		}

		Console.Write("\n Press any key...");

		Console.ReadKey();
	}

	public static void Task4_3_12()
	{

		int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

		for (int ColumnIndex = 0; ColumnIndex <= array.GetUpperBound(1); ColumnIndex++)
		{

			for (int RowIndex = 0; RowIndex <= array.GetUpperBound(0); RowIndex++)
			{
				Console.Write(array[RowIndex, ColumnIndex] + " ");
			}

			Console.WriteLine();

		}

		Console.Write("\n Press any key...");

		Console.ReadKey();
	}
}
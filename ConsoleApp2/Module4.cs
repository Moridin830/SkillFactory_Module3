using System;

class Module4
{

	public struct FavoriteColors
	{
		public string First;
		public string Second;
		public string Third;
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

		var array = new int[] { 5, 6, 9, 1, 2, 3, 4 };

		int temp = 0;

		for (int CurrentIndex = 0; CurrentIndex < array.Length; CurrentIndex++)
		{

			int MaxValueIndex = CurrentIndex, MinValueIndex = CurrentIndex;
			int MinValue = array[CurrentIndex], MaxValue = array[CurrentIndex];

			for (int UpperIndex = (CurrentIndex + 1); UpperIndex < array.Length; UpperIndex++)
            {
				if (array[UpperIndex] > MaxValue)
				{
					MaxValueIndex = UpperIndex;
					MaxValue = array[UpperIndex];
				}

				if (array[UpperIndex] < MinValue)
				{
					MinValueIndex = UpperIndex;
					MinValue = array[UpperIndex];
				}
			}
			
			temp = array[CurrentIndex];
			array[CurrentIndex] = MinValue;
			array[MinValueIndex] = temp;
			temp = array[(array.Length - 1)];
			array[(array.Length - 1)] = MaxValue;
			array[MaxValueIndex] = temp;

		}

		foreach (int CurrentSymbol in array)
        {
			Console.Write(CurrentSymbol + " ");
        }

		Console.Write("\n Press any key...");

		Console.ReadKey();
	}

	public static void Task4_3_13()
	{

		var array = new int[] { 5, 6, 9, 1, 2, 3, 4 };

		int Summ = 0;

		foreach (int CurrentSymbol in array)
		{
			Summ = Summ + CurrentSymbol;
		}

		Console.WriteLine(Summ);

		Console.Write("\n Press any key...");

		Console.ReadKey();
	}

	public static void Task4_3_14()
	{

		int[][] array = new int[3][];

		array[0] = new int[2] { 1, 2 };
		array[1] = new int[3] { 1, 2, 3 };
		array[2] = new int[5] { 1, 2, 3, 4, 5 };

		foreach (int[] CurrentArray in array)
		{
			foreach (int CurrentSymbol in CurrentArray)
            {
				Console.Write(CurrentSymbol + " ");
            }

			Console.WriteLine();
		}

		Console.Write("\n Press any key...");

		Console.ReadKey();
	}

	public static void Task4_3_15()
	{

		var array = new int[] { -5, 6, 9, -1, 2, 3, 4 };

		int Counter = 0;

		foreach (int CurrentSymbol in array)
		{
			if (CurrentSymbol > 0)
			{
				Counter++;
			}
		}

		Console.WriteLine(Counter);

		Console.Write("\n Press any key...");

		Console.ReadKey();
	}

	public static void Task4_3_16()
	{

		int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

		int Counter = 0;

		for (int CurrentRow = 0; CurrentRow <= arr.GetUpperBound(0); CurrentRow++)
		{
			for (int CurrentColumn = 0; CurrentColumn <= arr.GetUpperBound(1); CurrentColumn++)
            {
				if (arr[CurrentRow, CurrentColumn] > 0)
				{
					Counter++;
				}
			}
			
		}

		Console.WriteLine(Counter);

		Console.Write("\n Press any key...");

		Console.ReadKey();
	}

	public static void Task4_3_17()
	{

		int[,] array = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

		int temp = 0;

		for (int CurrentRow = 0; CurrentRow <= array.GetUpperBound(0); CurrentRow++)
		{
			for (int CurrentIndex = 0; CurrentIndex <= array.GetUpperBound(1); CurrentIndex++)
			{

				int MaxValueIndex = CurrentIndex, MinValueIndex = CurrentIndex;
				int MinValue = array[CurrentRow, CurrentIndex], MaxValue = array[CurrentRow, CurrentIndex];

				for (int UpperIndex = (CurrentIndex + 1); UpperIndex <= array.GetUpperBound(1); UpperIndex++)
				{
					if (array[CurrentRow, UpperIndex] > MaxValue)
					{
						MaxValueIndex = UpperIndex;
						MaxValue = array[CurrentRow, UpperIndex];
					}

					if (array[CurrentRow, UpperIndex] < MinValue)
					{
						MinValueIndex = UpperIndex;
						MinValue = array[CurrentRow, UpperIndex];
					}
				}

				temp = array[CurrentRow, CurrentIndex];
				array[CurrentRow, CurrentIndex] = MinValue;
				array[CurrentRow, MinValueIndex] = temp;
				temp = array[CurrentRow, array.GetUpperBound(1)];
				array[CurrentRow, array.GetUpperBound(1)] = MaxValue;
				array[CurrentRow, MaxValueIndex] = temp;

			}

			for (int CurrentIndex = 0; CurrentIndex <= array.GetUpperBound(1); CurrentIndex++)
			{
				Console.Write(array[CurrentRow, CurrentIndex]);
			}

			Console.WriteLine();
		}

		

		Console.Write("\n Press any key...");

		Console.ReadKey();
	}

	public static void Task4_4_2()
	{

		(string name, int age) anketa;
		
		Console.WriteLine("Enter your name:");
		anketa.name = Console.ReadLine();

		Console.WriteLine("Enter your age:");
		anketa.age = Convert.ToInt32(Console.ReadLine());

		Console.Write("\n Press any key...");

		Console.ReadKey();
	}

	public static void Task4_4_3()
	{

		(string name, int age) anketa;

		Console.WriteLine("Enter your name:");
		anketa.name = Console.ReadLine();

		Console.WriteLine("Enter your age:");
		anketa.age = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Your age: {0}", anketa.age);
		Console.WriteLine("Your name: {0}", anketa.name);
		
		Console.Write("\n Press any key...");

		Console.ReadKey();
	}

	public static void Task4_4_4()
	{

		(string Name, string Type, double Age, int NameCount) Pet;

		Console.WriteLine("Enter info of your pet.");
		
		Console.WriteLine("Enter name:");
		Pet.Name = Console.ReadLine();

		Console.WriteLine("Enter pet type:");
		Pet.Type = Console.ReadLine();

		Console.WriteLine("Enter age:");
		Pet.Age = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Enter name length:");
		Pet.NameCount = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("\n Press any key...");

		Console.ReadKey();
	}

	public static void Task4_5()
	{

		int UserQuantity = 3;

		(string Name, string LastName, string Login, int LoginLength, bool HasPet, double Age, FavoriteColors FavColors) User;

		Console.WriteLine("/--------------------------------------------/");
		for (byte CurrentUser = 1; CurrentUser <= UserQuantity; CurrentUser++) 
		{
			
			Console.WriteLine("Input info of user #{0}", CurrentUser);
			Console.WriteLine("/--------------------------------------------/");

			Console.WriteLine("Enter name:");
			User.Name = Console.ReadLine();

			Console.WriteLine("Enter last name:");
			User.LastName = Console.ReadLine();

			Console.WriteLine("Enter login:");
			User.Login = Console.ReadLine();

			User.LoginLength = User.Login.Length;

			Console.WriteLine("Do you have any pets? Yes/No:");
			string UserAnswer = Console.ReadLine();

			if (UserAnswer == "Yes")
			{
				User.HasPet = true;
			} else
			{
				User.HasPet = false;
			}

			Console.WriteLine("Enter your age:");
			User.Age = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter your favorite colors.");
			Console.WriteLine("Color 1");
			User.FavColors.First = Console.ReadLine();

			Console.WriteLine("Color 2");
			User.FavColors.Second = Console.ReadLine();

			Console.WriteLine("Color 3");
			User.FavColors.Third = Console.ReadLine();

			Console.WriteLine("/--------------------------------------------/");

		}

		Console.Write("\n Press any key...");

		Console.ReadKey();
	}

}
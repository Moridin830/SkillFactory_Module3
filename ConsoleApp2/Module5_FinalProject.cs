using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
		public static void Main(string[] args)
		{

			(string Name, string LastName, bool HasPet, string[] PetNames, int Age, string[] FavoriteColors) = InputUserData();

			PrintUserData(Name, LastName, HasPet, PetNames, Age, FavoriteColors);

		}

		public static (string Name, string LastName, bool HasPet, string[] PetNames, int Age, string[] FavoriteColors) InputUserData()
		{

			(string Name, string LastName, bool HasPet, int PetCount, string[] PetNames, int Age, string[] FavoriteColors) User = ("", "", false, 0, new string[1], 0, new string[1]);
			
			Console.WriteLine("/--------------------------------------------/");
			
			Console.WriteLine("Input info of user");
			Console.WriteLine("/--------------------------------------------/");

			Console.WriteLine("Enter name:");
			User.Name = Console.ReadLine();

			Console.WriteLine("Enter last name:");
			User.LastName = Console.ReadLine();

			Console.WriteLine("Do you have any pets? Yes/No:");
			string UserAnswer = Console.ReadLine();

			User.HasPet = false;

			if (UserAnswer.ToLower() == "yes")
			{
				User.HasPet = true;

				ReadUserAnswer("How many pets do you have?", out User.PetCount);
				Console.WriteLine("Enter your pet's name.");
				User.PetNames = GetArrayOfValues(User.PetCount, "Pet");

			}

			ReadUserAnswer("Enter your age:", out User.Age);

			int NumberOfColors = 0;
			ReadUserAnswer("How many favorite colors do you have?", out NumberOfColors);
			Console.WriteLine("Enter your favorite colors.");
			User.FavoriteColors = GetArrayOfValues(NumberOfColors, "Color");
				
			Console.WriteLine("/--------------------------------------------/");

			return (User.Name, User.LastName, User.HasPet, User.PetNames, User.Age, User.FavoriteColors);
		}

		public static string[] GetArrayOfValues(int NumberOfValues, string ValueName)
        {
			string[] ArrayOfValues = new string[NumberOfValues];

			for(byte CurrentColor = 0; CurrentColor < NumberOfValues; CurrentColor++)
                {
					Console.WriteLine(ValueName + " #" + (CurrentColor + 1) + ":");
					ArrayOfValues[CurrentColor] = Console.ReadLine();
				}

			return ArrayOfValues;
        }

		public static void ReadUserAnswer(string TextMessage, out int UserAnswer)
        {
			Console.WriteLine(TextMessage);
			string AnswerString = Console.ReadLine();
			bool ItsInt = Int32.TryParse(AnswerString, out UserAnswer);

            if (!ItsInt||(!(UserAnswer > 0)))
            {
				Console.WriteLine("This answer is not correct. Continue input? Yes/No");
				AnswerString = Console.ReadLine();
				if (AnswerString.ToLower() == "yes")
				{
					ReadUserAnswer(TextMessage, out UserAnswer);
				} else
                {
					return;
                }
            }
		}

		public static void PrintUserData(string Name, string LastName, bool HasPet, string[] PetNames, int Age, string[] FavoriteColors)
        {

			Console.Clear();
			Console.WriteLine("/--------------------------------------------/");

			Console.WriteLine("Your name is: " + Name);
			
			Console.WriteLine("Your last name is: " + LastName);

			Console.WriteLine("Your age is: " + Age);

			if (HasPet)
            {
				Console.WriteLine("You have {0} pets", PetNames.Length);
				PrintArrayValues(PetNames, "Pet");
            } else
            {
				Console.WriteLine("You have not pets");
            }

			Console.WriteLine("You have {0} favorite colors", FavoriteColors.Length);
			PrintArrayValues(FavoriteColors, "Color");

			Console.WriteLine("/--------------------------------------------/");

			Console.WriteLine("\nPress any key...");
			Console.ReadLine();
		}

		public static void PrintArrayValues(string[] ArrayOfValues, string ValueName)
        {
			for(int CurrentValueIndex = 0; CurrentValueIndex < ArrayOfValues.Length; CurrentValueIndex++)
            {
				Console.WriteLine((ValueName + 1) + " #" + CurrentValueIndex + ": " + ArrayOfValues[CurrentValueIndex]);
            }
        }


	}
}

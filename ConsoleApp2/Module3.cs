using System;

class Module3
{
	public static void Main(string[] args)
	{

		Module4.Task4_3_8();

		//Console.Write("Enter your name: ");
		//string name = Console.ReadLine();
		//Console.Write("Enter your age: ");
		//byte age = (byte)int.Parse(Console.ReadLine());
		//Console.WriteLine("Your name is {0} and age is {1} ", name, age);
		//Console.ReadKey();
	}

	public static void Task3_2()
	{

		string myName;
		myName = "Moridin830";

		Console.WriteLine(myName);
		Console.WriteLine("\t Привет Мир");
		Console.WriteLine("\t Мне 31 годик");
        Console.WriteLine("\t My name is \n {0}", myName);
		Console.WriteLine('\u0040');
		Console.WriteLine('\u0023');
		Console.ReadKey();
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
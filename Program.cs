Console.WriteLine("hi what's your name :D");
string name = Console.ReadLine();

bool active = true;
while (active)
{
	bool valid = true;
	while (valid)
	{
		Console.WriteLine("hey "+ name +"! put in a number between 1-100");
		int input = int.Parse(Console.ReadLine());

		if (input >= 1 && input <= 100)
		{
			// Console.WriteLine("your number is " + input);
			valid = false;
			if (input % 2 == 0)
			{
				// even
				if (input < 25)
				{
					Console.WriteLine(input + " is Even and less than 25.");
				}
				else if (input > 60)
				{
					Console.WriteLine(input + " is Even and greater than 60.");
				} else
				{
					Console.WriteLine(input + " is Even and between 26 and 60 inclusive");
				}
			} else
			{
				// odd
				if (input < 60)
				{
					Console.WriteLine(input + " is Odd and less than 60.");
				}
				else
				{
					Console.WriteLine(input + " is Odd and greater than 60.");
				}
			}
		}
		else
		{
			Console.WriteLine("try again, "+name+" :/");
			valid = true;
		}
	}

	Console.WriteLine();
	bool repeat = true;
	while (repeat)
	{
		Console.WriteLine("Would you like to continue? Y/N");
		string input = Console.ReadLine().ToLower();
		if (input == "y")
		{
			active = true;
			repeat = false;
		}
		else if (input == "n")
		{
			active = false;
			repeat = false;
		}
		else
		{
			Console.WriteLine("this is a y/n question, "+name+" :p");
			repeat = true;
		}
	}
}
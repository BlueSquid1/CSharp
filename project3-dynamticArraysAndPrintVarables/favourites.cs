using System;

class Program
{
	static void Main()
	{
		string[] favFood = new string[3];
		favFood[0] = "chocolate";
		favFood[1] = "iceCream";
		favFood[2] = "Donuts";
		
		for(int i = 0; i < favFood.length; i++)
		{
			Console.WriteLine( $"My {i} food is: " + favFood[i].ToString());
		}
	}
}
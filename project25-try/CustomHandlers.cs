using System;

class CustomHandlers
{
	public static void Display(string PlayerName)
	{
		if(PlayerName == null)
		{
			//throw a custom exception and then exit the function
			throw new ArgumentNullException (nameof(PlayerName));
		}
		Console.WriteLine("Player name is: {0}", PlayerName);
	}
	
	public static void Main()
	{
		try
		{
			Display(null);
		}
		catch (System.ArgumentNullException ex)
		{
			Console.WriteLine("an exception occured");
		}
	}
}
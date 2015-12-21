using System;

class divider
{
	public static int div(int b)
	{
		return 10/b;
	}
	
	public static void Main()
	{
		try
		{
			Console.WriteLine(div(0));
		}
		catch (DivideByZeroException ex)
		{
			Console.WriteLine("b can't be zero");
		}
		finally
		{
			Console.WriteLine("program is done");
		}
	}
}
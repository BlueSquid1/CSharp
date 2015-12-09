using System;

class Animals
{
	public class Duck
	{
		double feedAmount = 0.0;
		static Duck()
		{
			Console.WriteLine("Ducks Types inialized");
		}
		
		public Duck(double mFeed = 0.0)
		{
			this.feedAmount = mFeed;
			Console.WriteLine("this duck needs {0} of food", feedAmount);
		}
		
	}
	static void Main()
	{
		Console.WriteLine("before creating the first duck");
		Duck Phillip = new Duck(3.5);
		Console.WriteLine("before creating the second duck");
		Duck Harry = new Duck(4.2);
	}
}
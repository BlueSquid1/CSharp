using System;

class Program
{
	public class TopLevel
	{
		public class Nested
		{
			public void Print()
			{
				Console.WriteLine("Printing from Nested");
			}
		}
	}

	public static void Main()
	{
		static void Foo()
		{
			TopLevel.Nested obj = new TopLevel.Nested();
		}
	}
}
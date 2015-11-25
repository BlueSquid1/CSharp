using System;

class Foo
{
	static void Main()
	{
		//identify the arguement y by name (not by position)
		//arguements are evaluated from left to right (as you would expect)
		int total = Summer(y:3);
		Console.WriteLine("total={0}", total); //total=5
	}
	
	//optional parameters are set to x=2 and y=1 of not otherwise defined.
	static int Summer(int x = 2, int y = 1)
	{
		return x + y;
	}
}
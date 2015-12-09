using System;

class GUI
{
	public enum BorderSide
	{
		LEFT,
		RIGHT,
		TOP,
		BOTTOM
	}
	
	public static void Main()
	{
		BorderSide BoxPos = BorderSide.RIGHT;
		
		Console.WriteLine(BoxPos); //RIGHT
		
		int test = (int)BoxPos;
		Console.WriteLine(test); //1
	}
}
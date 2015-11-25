using System;

class Elvis
{
	static void Main()
	{
		string x = null;
		//if x equals null then set y to "Elvis"
		string y = x ?? "Elvis"; // ?? = null-coalescing operator
		Console.WriteLine("x='{0}' and y='{1}'", x, y);
		
		
		//Elvis operator
		System.Text.StringBuilder sb = null;
		string s = sb?.ToString(); //no error, s instead evaluates to null
	}
	
	
}
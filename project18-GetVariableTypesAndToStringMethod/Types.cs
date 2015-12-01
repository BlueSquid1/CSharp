using System;

class Types
{
	static void Main()
	{
		double x = 5.245;
		
		//convert to string
		//all built-in types have the method ToString()
		string stringVal = x.ToString();
		
		//.GetType() is evaluated at runtime
		Console.WriteLine("variable stringVal has value {0} and type: {1}", stringVal, stringVal.GetType().Name);
	}
}
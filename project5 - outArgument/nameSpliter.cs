using System;

class nameSpliter
{
	static void Split(string name, out string firstName, out string lastName)
	{
		//find where the space seperator is
		int i = name.LastIndexOf(' ');
		firstName = name.Substring(0, i);
		lastName = name.Substring(i+1);
		
	}
	
	static void Main()
	{
		string a;
		string b;
		Split("Harry Potter", out a, out b);
		
		Console.WriteLine(a);
		Console.WriteLine(b);
		Console.ReadLine();
	}
}
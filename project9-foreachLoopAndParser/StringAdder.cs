using System;

class StringAdder
{
	static void Main()
	{
		string sentance = "This is a example sentance";
		string[] words = sentance.Split(' ');
		
		foreach(string word in words)
		{
			Console.WriteLine(word);
		}
	}
}
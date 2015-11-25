using System;

class multi
{
	static void Main()
	{
		int sum = multiple(2,3,4);
		Console.WriteLine("2 * 3 * 4 = {0}", sum);
	}
	
	//params arguement is always the last arguement
	static int multiple(params int[] vals)
	{
		int total = 0;
		for(int i = 0; i < vals.Length; i++)
		{
			total += vals[i];
		}
		return total;
	}
}
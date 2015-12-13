using System;

public delegate int Transformer(int x);

class Program
{
	//function that applies transform f to all elements in an array
	public static int[] transformArray(int[] values, Transformer f)
	{
		int[] output = new int[values.Length];
		for(int i = 0; i < values.Length; i++)
		{
			output[i] = f(values[i]);
		}
		return output;
	}
	
	//simple function that squares the input
	public static int Square(int x)
	{
		return x * x;
	}
	
	//increment x by 1
	public static int Inc(int x)
	{
		return x + 1;
	}
	
	public static void PrintArray(int[] array)
	{
		for(int i = 0; i < array.Length; i++)
		{
			Console.Write(array[i] + " ");
		}
		Console.WriteLine();
	}
	
	public static void Main()
	{
		Transformer t = Square;
		
		int[] values = {1,3,5,2};
		
		PrintArray(transformArray(values, t)); //1 9 25 4
		
		//can also make delegate t call multiple function like this:
		t += Inc;
		
		//first calls Square() and then Inc
		//returns the result from the last method ONLY
		PrintArray(transformArray(values, t)); //2 4 6 3
	}
}
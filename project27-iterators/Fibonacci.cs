using System;
using System.Collections;

class Fibonacci
{
	public static IEnumerable Fibs(int fibCount)
	{
		int prevFib = 0;
		int curFib = 1;
		
		yield return prevFib;
		
		for(int i = 0; i < fibCount; i++)
		{
			int temp = curFib;
			curFib = prevFib + curFib;
			prevFib = temp;
			yield return prevFib;
		}
	}
	
	public static IEnumerable EvenNumbersOnly (IEnumerable sequence)
	{
		foreach(int x in sequence)
		{
			if((x % 2) == 0)
			{
				yield return x;
			}
		}
	}
	
	public static void Main()
	{
		foreach(int fibNum in EvenNumbersOnly(Fibs(6)))
		{
			Console.WriteLine(fibNum);
		}
	}
}
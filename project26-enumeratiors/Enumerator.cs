using System;
using System.Collections;

public class Enumerator : System.Collections.IEnumerator
{
	//constructor
	public Enumerator(int[] nValues)
	{
		this.values = nValues;
	}
	
	//curser position
	int curPos = -1;
	
	//place to store values
	public int[] values;
	
	//move curser to next element
	public bool MoveNext()
	{
		curPos++;
		return (curPos < values.Length);
	}
	
	//reset the enumerator
	public void Reset()
	{
		curPos = -1;
	}
	
	//no idea what this does
	object IEnumerator.Current
	{
		get
		{
			return Current;
		}
	}
	
	
	public int Current
	{
		get
		{
			return values[curPos];
		}
	}
	
}

public class Enumerable : IEnumerable
{
	private int[] values;
	
	//constructor
	public Enumerable(int[] nValues)
	{
		//shallow copy
		this.values = nValues;
	}
	
	IEnumerator IEnumerable.GetEnumerator()
	{
		return (IEnumerator) GetEnumerator();
	}
	
	public Enumerator GetEnumerator()
	{
		return new Enumerator(values);
	}
	
}

class EnumeratorTest
{	
	public static void Main()
	{
		Enumerable list = new Enumerable(new int[]{1,3,4});
		
		foreach(int num in list)
		{
			Console.WriteLine(num);
		}
	}
}
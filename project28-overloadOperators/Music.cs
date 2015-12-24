using System;

public class Note
{
	public int value;
	
	//overload addition operator
	public static Note operator + (Note x, int semitones)
	{
		return new Note (x.value + semitones);
	}
	
	//overload to double conversion
	public static implicit operator double (Note x)
	{
		return 440 * Math.Pow(2, (double) x.value / 12);
	}
	
	//overload from double conversion explicitly
	public static explicit operator Note (double x)
	{
		return new Note((int)(0.5 + 12 * (Math.Log(x/440)/ Math.Log(2))));
	}
	
	//constructor
	public Note(int mValue)
	{
		this.value = mValue;
	}
}


class Music
{
	public static void Main()
	{
		Note A = (Note)554.37; //explicit conversion
		Console.WriteLine(A.value); //4
		double value = A;
		Console.WriteLine(value); //554.365
		
	}
}
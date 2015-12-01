using System;

class program
{
	public class baseClass
	{
		public int num = 0;
		
		//constructor
		public baseClass(int mNum)
		{
			this.num = mNum;
		}
	}
	
	public class childClass : baseClass
	{
		//constructor
		public childClass(int mNum) : base(mNum)
		{
		}
		
		public void edit(int x)
		{
			base.num = x;
		}
	}
	
	static void Main()
	{
		childClass a = new childClass(5);
		Console.WriteLine(a.num); //5
		a.edit(6);
		Console.WriteLine(a.num); //6
	}
}
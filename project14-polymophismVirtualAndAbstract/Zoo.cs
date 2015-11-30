using System;

class Zoo
{
	public abstract class Animal
	{
		//property
		protected abstract string noise{get; set;}
		
		public abstract string Call();
	}
	
	public class Sheep : Animal
	{
		protected override string noise{get; set; }
		
		//constructor
		public Sheep()
		{
			this.noise = "baah";
		}
		public override string Call()
		{
			return string.Format("sheep goes {0}", noise);
		}
	}
	
	public class Tiger : Animal
	{
		protected override string noise{get; set; }
		
		//constructor
		public Tiger()
		{
			this.noise = "raaar";
		}
		
		public override string Call()
		{
			return string.Format("tiger goes {0}", noise);
		}
	}
	
	
	static void Main()
	{
		Sheep x = new Sheep();
		Console.WriteLine(x.Call()); //baaah
		
		Tiger y = new Tiger();
		Console.WriteLine(y.Call());
	}
}
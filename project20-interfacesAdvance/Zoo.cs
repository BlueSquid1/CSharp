using System;

//using interfaces and classes in a zoo

class Zoo
{
	public abstract class Animal
	{
		//all animals have legs
		public abstract int legNum{get; set;}
		
		//all animals make a noise
		public virtual void Noise()
		{
			Console.WriteLine("default noise");
		}
	}
	
	public abstract class Bird : Animal
	{
		//all birds have a wing span
		public abstract double WingSpan{get; set;}
	}
	
	public abstract class Insect : Animal
	{
		//some insects have skeletons on the outside
		public abstract bool externalSkele{get; set;}
	}
	
	public interface IFlyingCreature
	{
		//everything here is public
		int flightDis{get; set;}
	}
	
	
	
	public class Eagle : Bird, IFlyingCreature
	{
		public override int legNum{get; set;} = 2;
		public override double WingSpan{get; set;} = 4.2;
		public int flightDis{get; set;} = 2000;
		
		public override void Noise()
		{
			Console.WriteLine("Garr");
		}
	}
	
	public static void Main()
	{
		Eagle Bart = new Eagle();
		//Console.WriteLine();
		Bart.Noise();
	}
}

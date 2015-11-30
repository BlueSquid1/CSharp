using System;

class House
{
	
	public class Property
	{
		public string name = "default";
		
		public virtual void PrintDetails() 
		{
			Console.WriteLine("property name = {0}", name);
		}
	}
	
	public class BeachHouse : Property
	{
		//constructor
		public BeachHouse(string mName)
		{
			this.name = mName;
		}
		
		override public void PrintDetails()
		{
			Console.WriteLine("beachHouse name = {0}", this.name);
		}
	}
	
	static void Main()
	{
		Property mainPlace = new Property();
		mainPlace.PrintDetails(); //property name = default
		
		BeachHouse HoliHouse = new BeachHouse("Seashore Rest");
		HoliHouse.PrintDetails(); //beachHouse name = Seashore Rest
	}
}
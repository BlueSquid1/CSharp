using System;

class Bunny
{
	class BunnyRabbit
	{
		public string name = "none";
		public int numOfCarrots = 0;
		
		//default constructor
		public BunnyRabbit()
		{
			this.name = "harry";
			this.numOfCarrots = 2;
		}
		
		//constructor
		//calls the default constructor before run this function with this()
		public BunnyRabbit(string mName) : this()
		{
			this.name = mName;
		}
	}
	
	static void Main()
	{
		BunnyRabbit b1 = new BunnyRabbit("phillop");
		Console.WriteLine("bunny 1 is has name: {0}, and {1} carrots", b1.name, b1.numOfCarrots);
		//bunny 1 is has name: phillop, and 2 carrots
		
		//object initializer always are applied after constructor returns
		BunnyRabbit b2 = new BunnyRabbit("phillop") {name="ben", numOfCarrots=3};
		Console.WriteLine("bunny 2 is has name: {0}, and {1} carrots", b2.name, b2.numOfCarrots);
		//bunny 2 is has name: ben, and 3 carrots
	}
}
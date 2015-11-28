using System;

class Money
{
	public class Stock
	{
		private double currentPrice;
		//property CurrentPrice is different from the field currentPrice
		public double CurrentPrice
		{
			get 
			{
				return currentPrice;
			}
			
			set
			{
				//input number is assigned to 'value'
				currentPrice = value;
			}
		}
		
		//or using automatic properties
		//compilar creates a private variable that can't be references
		public double PreviousPrice {get; set; } = 3.1; //assignment requires csc 6.0
		
		public double ReadPrevious()
		{
			return this.PreviousPrice;
		}
	}
	
	static void Main()
	{
		Stock x = new Stock();
		//x.PreviousPrice =6.0;
		
		Console.WriteLine(x.ReadPrevious());
	}
}
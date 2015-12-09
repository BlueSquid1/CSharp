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
		//compilar creates a private variable that can't be references for this property but the property is made public (except for 'set')
		public double PreviousPrice {get; private set; } = 3.1; //assignment requires csc 6.0
		
		
		//property array
		private string[] words = "The quick brown fox".Split();
		public string[] Words
		{
			get 
			{
				return words;
			}
			set 
			{
				words = value;
			}
		}
		
		
		public void SetPreviousPrice(double amount)
		{
			this.PreviousPrice = amount;
		}
	}
	
	static void Main()
	{
		Stock x = new Stock();
		x.SetPreviousPrice(5.3);
		Console.WriteLine(x.PreviousPrice); //=5.3
		
		Console.WriteLine(x.Words[1]); //=quick
	}
}
using System;

public delegate void PriceChangedHandler(double oldPrice, double newPrice);

//Stock is the event broadcaster
public class Stock
{
	double price = 1.00;
	
	public event PriceChangedHandler PriceChanged = null;
	
	public double Price
	{
		get {return price;}
		set
		{
			if(price == value)
			{
				return; // nothing changed
			}
			
			//price has changed
			double oldPrice = price;
			price = value;
			
			//send out a broadcast to all subscribers
			if(PriceChanged != null)
			{
				PriceChanged(oldPrice, price);
			}
		}
	}
}

public class Person
{
	string name;
	int stockShares = 50;
	
	//constructor
	public Person(string mName)
	{
		this.name = mName;
	}
	
	public void Subscribe(Stock company)
	{
		company.PriceChanged += this.StockReaction;
	}
	
	public void UnSubscribe(Stock company)
	{
		company.PriceChanged -= this.StockReaction;
	}
	
	public void StockReaction(double oldPrice, double newPrice)
	{
		if(newPrice > oldPrice)
		{
			Console.WriteLine(this.name + " is buying more shares");
			stockShares++;
		}
		else
		{
			Console.WriteLine(this.name + " is selling more shares");
			stockShares--;
		}
	}
}

class Event
{
	public static void Main()
	{
		Stock Microsoft = new Stock();
		Console.WriteLine("#changing share price#");
		Microsoft.Price = 1.20; //no response because no subscribers
		Console.WriteLine("----\n");
		
		//create and subscribe phillip and Ashley
		Person Phillip = new Person("Phillip");
		Phillip.Subscribe(Microsoft);
		
		Person Ashley = new Person("Ashley");
		Ashley.Subscribe(Microsoft);
		
		Console.WriteLine("#changing share price#");
		Microsoft.Price = 1.50; //Phillip and Ashley react
		Console.WriteLine("----\n");
		
		//unsubscribe Ashley
		Ashley.UnSubscribe(Microsoft);
		
		Console.WriteLine("#changing share price#");
		Microsoft.Price = 1.20; //only Phillip reacts
		Console.WriteLine("----\n");
	}
}
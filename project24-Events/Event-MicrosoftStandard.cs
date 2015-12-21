using System;

//create a function pointer class called EventHandler that points to a function that:
// 1. returns a void type (required for all events)
// 2. accept two arguements, first the event broadcaste, and the second containing extra info (required for all events)
// 3. name ends with 'EventHandler' (required)
public delegate void EventHandler<EventArgs> (object source, EventArgs e);

//Stock is the event broadcaster
public class Stock
{	
	//create a function pointer called 'PriceChanged'
	public event EventHandler<PriceChangedEventArgs> PriceChanged;
	
	//property called Price
	private double price = 1.00;
	public double Price
	{
		get 
		{
			return price;
		}
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
			if (PriceChanged != null) //make sure there is aleast 1 subscriber
			{
				//call the subscriber's functions
				PriceChanged (this, new PriceChangedEventArgs(oldPrice, price));
			}
		}
	}
}

//subclass that contains all the details need for the subscribers to react
public class PriceChangedEventArgs : System.EventArgs
{
	public readonly double lastPrice;
	public readonly double newPrice;
	
	//constructor
	public PriceChangedEventArgs (double mLastPrice, double mNewPrice)
	{
		this.lastPrice = mLastPrice;
		this.newPrice = mNewPrice;
	}
}

//Person in the subscriber to Stock
public class Person
{
	string name;
	int stockShares = 50;
	
	//constructor
	public Person(string mName)
	{
		this.name = mName;
	}
	
	//subscribe a person to a company
	public void Subscribe(Stock company)
	{
		company.PriceChanged += this.StockReaction;
	}
	
	//unsubscribe a person to a company
	public void UnSubscribe(Stock company)
	{
		company.PriceChanged -= this.StockReaction;
	}
	
	//response when stock prices change event is triggered
	public void StockReaction(object sender, PriceChangedEventArgs e)
	{
		if(e.newPrice > e.lastPrice)
		{
			Console.WriteLine(this.name + " is buying more shares");
			this.stockShares++;
		}
		else
		{
			Console.WriteLine(this.name + " is selling more shares");
			this.stockShares--;
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
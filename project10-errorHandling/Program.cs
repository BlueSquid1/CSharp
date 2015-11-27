using System;


namespace MyTradingCompany
{
	namespace Common
	{
		class ReportBase
		{
			public int a;
			public ReportBase()
			{
				this.a = 4;
			}
		}
	}
		
	namespace ManagementReporting
	{
		class SalesReport
		{
			public Common.ReportBase x;
			public SalesReport()
			{
				this.x = new Common.ReportBase();
			}
		}
	}
}

class Program
{
	static void Main()
	{
		MyTradingCompany.ManagementReporting.SalesReport F = new MyTradingCompany.ManagementReporting.SalesReport();
		
		Console.WriteLine(F.x.a); //F.x.a = 4
		
		/*
		string n = null;
		if (n == null)
		{
			throw new ArgumentNullException ();
		}
		*/
	}
}

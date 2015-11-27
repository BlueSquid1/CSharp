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

using Management = MyTradingCompany.ManagementReporting;

class Program
{
	static void Main()
	{
		MyTradingCompany.ManagementReporting.SalesReport F1 = new MyTradingCompany.ManagementReporting.SalesReport();

		//which is same as:
		Management.SalesReport F2 = new Management.SalesReport();
		
		Console.WriteLine(F1.x.a); //F1.x.a = 4
		Console.WriteLine(F2.x.a); //F2.x.a = 4
		
		/*
		string n = null;
		if (n == null)
		{
			throw new ArgumentNullException ();
		}
		*/
	}
}

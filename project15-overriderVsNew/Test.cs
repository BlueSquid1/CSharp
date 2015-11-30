using System;

class Test
{
	public class BaseClass
	{
		public virtual string Foo()
		{
			return "base";
		}
	}
	
	public class OverrideChild : BaseClass
	{
		public override string Foo()
		{
			return "override child";
		}
	}
	
	public class newChild : BaseClass
	{
		//hidden function
		public new string Foo()
		{
			return "hidden child";
		}
	}
	
	
	static void Main()
	{
		BaseClass baseTemp = null;
		
		OverrideChild childObj = new OverrideChild();
		baseTemp = childObj;
		Console.WriteLine(childObj.Foo()); //override child
		Console.WriteLine(baseTemp.Foo()); //override child
		
		
		newChild newObj = new newChild();
		baseTemp = newObj;
		Console.WriteLine(newObj.Foo()); //hidden child
		Console.WriteLine(baseTemp.Foo()); //base
		
	}
}
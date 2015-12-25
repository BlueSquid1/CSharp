using System;

namespace Utils
{
	//notice the class is static
	public static class StringExtender
	{
		//notice the keywork 'this' is used to indicate a extension method
		public static string Capalize(this string s)
		{
			return Char.ToUpper(s[0]) + s.Substring(1);
		}
	}
}
namespace MyApp
{
	using Utils;
	class StringHelper
	{
		public static void Main()
		{
			Console.WriteLine("france".Capalize());
		}
	}
}
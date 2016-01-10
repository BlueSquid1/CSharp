using System;

namespace core
{
	public interface antenna
	{
		//all methods/properties are public
		//cannot declare access modifier (no need)
		void UpdateChannel(string newChannel);
		string GetChannel();
	}
	
	//exend the TVRemote interface
	public interface TVRemote : antenna
	{
		void Reset();
	}
	
	public class Remote : TVRemote
	{
		private string curChannel = "none";
		
		public void UpdateChannel(string newChannel)
		{
			this.curChannel = newChannel;
		}
		
		public string GetChannel()
		{
			return this.curChannel;
		}
		
		public void Reset()
		{
			this.curChannel = "none";
		}
	}
}

class TV
{	
	public static void Main()
	{
		//define an object with the interface of a remote
		core.TVRemote myRemote;
		
		//simular to:
		//core.Remote myRemote;
		
		//fill in the implimentation with the class core.Remote
		myRemote = new core.Remote();
		myRemote.UpdateChannel("ch9");
		Console.WriteLine(myRemote.GetChannel()); //ch9
		myRemote.Reset();
		Console.WriteLine(myRemote.GetChannel()); //none
	}
}
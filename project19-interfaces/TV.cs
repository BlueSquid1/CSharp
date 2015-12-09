using System;

class TV
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
	
	protected class Remote : TVRemote
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
	
	public static void Main()
	{
		TVRemote myRemote;
		
		//simular to:
		//Remote myRemote;
		
		myRemote = new Remote();
		myRemote.UpdateChannel("ch9");
		Console.WriteLine(myRemote.GetChannel()); //ch9
		myRemote.Reset();
		Console.WriteLine(myRemote.GetChannel()); //none
	}
}
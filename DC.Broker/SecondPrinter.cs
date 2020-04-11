using System;

namespace DC.Broker
{
	[Serializable]
	public class SecondPrinter : IPrinter
	{
		public void Print(string msg)
		{
			Console.WriteLine($"[SecondPrinter]: {msg}");
		}
	}
}

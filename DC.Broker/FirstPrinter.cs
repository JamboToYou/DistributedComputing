using System;

namespace DC.Broker
{
	[Serializable]
	public class FirstPrinter : IPrinter
	{
		public void Print(string msg)
		{
			Console.WriteLine($"[FirstPrinter]: {msg}");
		}
	}
}

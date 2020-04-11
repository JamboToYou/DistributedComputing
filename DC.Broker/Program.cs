using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DC.Broker
{
	class Program
	{
		static void Main(string[] args)
		{
			Run3();
		}

		static void Run1()
		{
			IPrinter p1 = new FirstPrinter();
			IPrinter p2 = new SecondPrinter();

			Serialize(p1, "firstFormatter.dat");
			Serialize(p2, "secondFormatter.dat");
		}

		static void Run2()
		{
			var p1 = Deserialize<IPrinter>("firstFormatter.dat");
			var p2 = Deserialize<IPrinter>("secondFormatter.dat");

			p1.Print("first");
			p2.Print("second");
		}

		static void Run3()
		{
			var p1 = Deserialize<IAnotherPrinter>("firstFormatter.dat");
			var p2 = Deserialize<IAnotherPrinter>("secondFormatter.dat");

			p1.Print("first");
			p2.Print("second");
		}

		static void Serialize(IPrinter obj, string fileName)
		{
			var fmt = new BinaryFormatter();

			using (var fStream = new FileStream(fileName,
				FileMode.Create, FileAccess.Write, FileShare.None))
			{
				fmt.Serialize(fStream, obj);
			}
		}

		static T Deserialize<T>(string fileName)
		{
			T printer;

			var fmt = new BinaryFormatter();

			using(var stream = new FileStream(fileName,
				FileMode.Open, FileAccess.Read, FileShare.None))
			{
				printer = (T)fmt.Deserialize(stream);
			}

			return printer;
		}
	}
}

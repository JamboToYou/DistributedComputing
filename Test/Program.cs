using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
			var bdl = FUParser.Parse("operation.json");

			var arg0 = bdl.Main.Procedures[0].Body.Callback.Args[0];
			var arg1 = bdl.Main.Procedures[0].Body.Callback.Args[1];

			Console.WriteLine(arg0.Type);
			Console.WriteLine(arg1.Type);
			Console.WriteLine();

			var arg = JsonConvert.DeserializeObject<FUProcedure>(arg1.Value.ToString());

			Console.WriteLine(arg.Operation);
			Console.WriteLine(arg.Args[0].Type);
			Console.WriteLine(arg.Args[0].Value);
			Console.WriteLine(arg.Args[1].Type);
			Console.WriteLine(arg.Args[1].Value);

		}
	}
}

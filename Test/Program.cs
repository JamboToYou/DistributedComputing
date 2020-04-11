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
			FUBundle bdl;

			using (var stream = new FileStream("operation.json",
				FileMode.Open, FileAccess.Read, FileShare.None))
			using (var reader = new StreamReader(stream))
			{
				bdl = JsonConvert.DeserializeObject<FUBundle>(reader.ReadToEnd());
			}

			var arg0 = bdl.Main.Procedures[0].Body.Callback.Args[0];
			var arg1 = bdl.Main.Procedures[0].Body.Callback.Args[1];

			// Console.WriteLine(bdl.Var.First().Type);
			// Console.WriteLine(bdl.Main.RetType);
			// Console.WriteLine(bdl.Main.Procedures[0].Args[0]);
			// Console.WriteLine(bdl.Main.Procedures[0].Args[1]);
			Console.WriteLine(arg0.Type);
			// Console.WriteLine(arg0.Value);
			Console.WriteLine(arg1.Type);
			// Console.WriteLine(arg1.Value);
			Console.WriteLine();

			var arg = JsonConvert.DeserializeObject<FUProcedure>(arg1.Value.ToString());

			Console.WriteLine(arg.Operation);
			Console.WriteLine(arg.Args[0].Type);
			Console.WriteLine(arg.Args[0].Value);
			Console.WriteLine(arg.Args[1].Type);
			Console.WriteLine(arg.Args[1].Value);

			// Console.WriteLine(bdl.Main.Procedures[0].Body.Cond.Operation);
		}
	}
}

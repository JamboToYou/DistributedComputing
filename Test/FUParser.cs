using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Test
{
	public class FUParser
	{
		public static FUBundle Parse(string fileName)
		{
			FUBundle res;

			using (var stream = new FileStream(fileName,
				FileMode.Open, FileAccess.Read, FileShare.None))
			using (var reader = new StreamReader(stream))
			{
				res = JsonConvert.DeserializeObject<FUBundle>(reader.ReadToEnd());
			}

			return res;
		}
	}
}
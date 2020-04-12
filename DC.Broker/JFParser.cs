using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using DC.Broker.Entities;

namespace DC.Broker
{
	public class JFParser
	{
		public static JFBundle Parse(string fileName)
		{
			JFBundle res;

			using (var stream = new FileStream(fileName,
				FileMode.Open, FileAccess.Read, FileShare.None))
			using (var reader = new StreamReader(stream))
			{
				res = JsonConvert.DeserializeObject<JFBundle>(reader.ReadToEnd());
			}

			return res;
		}
	}
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Test
{
	public class FUArgsConverter : JsonConverter<string[]>
	{
		public override string[] ReadJson(
				JsonReader reader,
				Type objectType,
				string[] existingValue,
				bool hasExistingValue,
				JsonSerializer serializer)
		{
			Console.WriteLine(reader.Value);

			return new string[] { "test" };
		}

		public override void WriteJson(
				JsonWriter writer,
				string[] value,
				JsonSerializer serializer)
		{
			writer.WriteValue(value.ToString());
		}
	}
}
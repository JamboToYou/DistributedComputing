using System;
using Newtonsoft.Json;

using DC.Broker.Entities;

namespace DC.Broker.Converters
{
	public class JFTypesConverter : JsonConverter<JFTypes>
	{
		public override JFTypes ReadJson(
				JsonReader reader,
				Type objectType,
				JFTypes existingValue,
				bool hasExistingValue,
				JsonSerializer serializer)
		{
			var val = (string)reader.Value;

			switch (val)
			{
				case "int":
					return JFTypes.JF_INT;
				case "string":
					return JFTypes.JF_STRING;
				case "ref":
					return JFTypes.JF_REF;
				case "op":
					return JFTypes.JF_OPERATION;
				default:
					throw new Exception("[JF]: wrong type");
			}
		}

		public override void WriteJson(
				JsonWriter writer,
				JFTypes value,
				JsonSerializer serializer)
		{
			string val;

			switch (value) {
				case JFTypes.JF_INT:
					val = "int";
					break;
				case JFTypes.JF_STRING:
					val = "string";
					break;
				case JFTypes.JF_REF:
					val = "ref";
					break;
				case JFTypes.JF_OPERATION:
					val = "op";
					break;
				default:
					throw new Exception("[JF]: wrong type");
			}
			writer.WriteValue(val);
		}
	}
}
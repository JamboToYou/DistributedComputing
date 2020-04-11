using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Test.Converters;

namespace Test
{
	public class FUTypesConverter : JsonConverter<FUTypes>
	{
		public override FUTypes ReadJson(
				JsonReader reader,
				Type objectType,
				FUTypes existingValue,
				bool hasExistingValue,
				JsonSerializer serializer)
		{
			var val = (string)reader.Value;

			switch (val)
			{
				case "int":
					return FUTypes.FU_INT;
				case "string":
					return FUTypes.FU_STRING;
				case "ref":
					return FUTypes.FU_REF;
				case "op":
					return FUTypes.FU_OPERATION;
				default:
					throw new Exception("[FU]: wrong type");
			}
		}

		public override void WriteJson(
				JsonWriter writer,
				FUTypes value,
				JsonSerializer serializer)
		{
			string val;

			switch (value) {
				case FUTypes.FU_INT:
					val = "int";
					break;
				case FUTypes.FU_STRING:
					val = "string";
					break;
				case FUTypes.FU_REF:
					val = "ref";
					break;
				case FUTypes.FU_OPERATION:
					val = "op";
					break;
				default:
					throw new Exception("[FU]: wrong type");
			}
			writer.WriteValue(val);
		}
	}
}
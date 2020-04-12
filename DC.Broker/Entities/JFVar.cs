using Newtonsoft.Json;

using DC.Broker.Converters;

namespace DC.Broker.Entities
{
	public class JFVar
	{
		[JsonProperty("type")]
		[JsonConverter(typeof(JFTypesConverter))]
		[JsonRequired]
		public JFTypes Type { get; set; }

		[JsonProperty("value")]
		[JsonRequired]
		public object Value { get; set; }
	}
}
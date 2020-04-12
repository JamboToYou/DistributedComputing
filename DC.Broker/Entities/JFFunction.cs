using System.Collections.Generic;
using Newtonsoft.Json;

using DC.Broker.Converters;

namespace DC.Broker.Entities
{
	public class JFFunction
	{
		[JsonProperty("ret_type")]
		[JsonConverter(typeof(JFTypesConverter))]
		[JsonRequired]
		public JFTypes RetType { get; set; }

		[JsonProperty("procedures")]
		public List<JFProcedure> Procedures { get; set; }
	}
}
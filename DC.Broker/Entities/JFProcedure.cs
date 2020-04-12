using System.Collections.Generic;
using Newtonsoft.Json;

namespace DC.Broker.Entities
{
	public class JFProcedure
	{
		[JsonProperty("operation")]
		[JsonRequired]
		public string Operation { get; set; }

		[JsonProperty("body")]
		public JFProcedureBody Body { get; set; }

		[JsonProperty("args")]
		public List<JFVar> Args { get; set; }
	}
}
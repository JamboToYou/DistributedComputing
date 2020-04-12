using System.Collections.Generic;
using Newtonsoft.Json;

namespace DC.Broker.Entities
{
	public class JFProcedureBody
	{
		[JsonProperty("cond")]
		public JFProcedure Cond { get; set; }

		[JsonProperty("callback")]
		public JFProcedure Callback { get; set; }

		[JsonProperty("procedures")]
		public List<JFProcedure> Procedures { get; set; }
	}
}
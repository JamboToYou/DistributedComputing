using System.Collections.Generic;
using Newtonsoft.Json;

namespace DC.Broker.Entities
{
	public class JFBundle
	{
		[JsonProperty("var")]
		public List<JFVar> Var { get; set; }

		[JsonProperty("main")]
		[JsonRequired]
		public JFFunction Main { get; set; }
	}
}
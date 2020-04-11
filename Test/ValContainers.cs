using System.Collections.Generic;
using Newtonsoft.Json;

namespace Test
{
	public enum FUTypes
	{
		FU_REF,
		FU_OPERATION,
		FU_INT,
		FU_STRING
	}

	public class FUVar
	{
		[JsonProperty("type")]
		[JsonConverter(typeof(FUTypesConverter))]
		[JsonRequired]
		public FUTypes Type { get; set; }

		[JsonProperty("value")]
		[JsonRequired]
		public object Value { get; set; }
	}

	public class FUProcedure
	{
		[JsonProperty("operation")]
		[JsonRequired]
		public string Operation { get; set; }

		[JsonProperty("body")]
		public FUProcedureBody Body { get; set; }

		[JsonProperty("args")]
		public List<FUVar> Args { get; set; }
	}

	public class FUFunction
	{
		[JsonProperty("ret_type")]
		[JsonConverter(typeof(FUTypesConverter))]
		[JsonRequired]
		public FUTypes RetType { get; set; }

		[JsonProperty("procedures")]
		public List<FUProcedure> Procedures { get; set; }
	}

	public class FUProcedureBody
	{
		[JsonProperty("cond")]
		public FUProcedure Cond { get; set; }

		[JsonProperty("callback")]
		public FUProcedure Callback { get; set; }

		[JsonProperty("procedures")]
		public List<FUProcedure> Procedures { get; set; }
	}

	public class FUBundle
	{
		[JsonProperty("var")]
		public List<FUVar> Var { get; set; }

		[JsonProperty("main")]
		[JsonRequired]
		public FUFunction Main { get; set; }
	}
}
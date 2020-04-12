using System;

namespace DC.Broker
{
	public class XBundle
	{
		private Func<object[], object> Func { get; set; }

		public object Invoke(object[] parameters)
		{
			return Func(parameters);
		}
	}
}
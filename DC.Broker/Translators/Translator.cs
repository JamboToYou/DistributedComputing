using System;

namespace DC.Broker.Translators
{
	public abstract class Translator<TUnit>
	
	{
		public abstract Func<object[], object> Translate(TUnit unit, params object[] parameters);
	}
}
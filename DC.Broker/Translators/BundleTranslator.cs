using System;

using DC.Broker.Entities;

namespace DC.Broker.Translators
{
	public class BundleTranslator : Translator<JFBundle>
	{
		public override Func<object[], object> Translate(JFBundle bundle, params object[] parameters)
		{
			throw new NotImplementedException();
		}
	}
}
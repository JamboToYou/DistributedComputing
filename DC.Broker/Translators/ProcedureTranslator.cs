using System;
using DC.Broker.Entities;

namespace DC.Broker.Translators
{
	public abstract class ProcedureTranslator : Translator<JFProcedure>
	{
		public override Func<object[], object> Translate(JFProcedure unit, params object[] parameters)
		{
			throw new NotImplementedException();
		}

		public virtual Func<object[], object> TranslateProcedure(JFProcedure procedure)
		{
			Func<object[], object> result = (r) => { return r[0]; };

			switch (procedure.Operation)
			{
				case "+":
					break;
				case "-":
					break;
				case "*":
					break;
				case "/":
					break;
				case "=":
					break;
				case "==":
					break;
				case "<":
					break;
				case ">":
					break;
				case "<=":
					break;
				case ">=":
					break;
				case "for":
					break;
				case "while":
					break;
				case "if":
					break;
				case "else":
					break;
				default:
					break;
			}

			return result;
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	class StrategyHomoSapiens : Strategy
	{

		public override bool getDecision()
		{
			return this.decision;
		}
	}
}

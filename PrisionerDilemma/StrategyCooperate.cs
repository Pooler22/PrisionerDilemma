using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	//Always Co-operate
	class StrategyCooperate : Strategy
	{
		public override bool getDecision()
		{
			return cooperate;
		}
	}
}

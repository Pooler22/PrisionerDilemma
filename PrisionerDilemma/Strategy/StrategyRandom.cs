using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	//Random - always set at 50% probability.
	class StrategyRandom : Strategy
	{
		public override bool getDecision()
		{
			return new Random().Next(0, 2) > 0;
		}
	}
}

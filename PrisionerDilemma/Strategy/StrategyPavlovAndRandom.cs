using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	//Pavlov / Random (repeat last choice if good outcome and Random) - If points scored in the last round then repeat last choice, but sometimes make random choices.*
	class StrategyPavlovAndRandom : Strategy
	{
		public override bool getDecision()
		{
			if (new StrategyRandom().getDecision())
			{
				return new StrategyRandom().getDecision();
			}
			return new StrategyPavlov(arrayWithEnemyAnswer).getDecision();
		}
	}
}

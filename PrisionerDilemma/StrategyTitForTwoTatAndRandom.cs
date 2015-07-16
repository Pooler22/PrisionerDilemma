using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	//Tit For Two Tats and Random - Like Tit For Tat except that opponent must make the same choice twice in a row before it is reciprocated. Choice is skewed by random setting.*
	class StrategyTitForTwoTatAndRandom : Strategy
	{	
		public override bool getDecision()
		{
			if (new StrategyRandom().getDecision())
			{
				return new StrategyTitForTwoTat().getDecision();
			}
			else 
			{
				return new StrategyRandom().getDecision();
			}
		}
	}
}

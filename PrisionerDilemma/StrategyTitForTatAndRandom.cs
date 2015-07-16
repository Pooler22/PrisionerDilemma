using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	//Tit For Tat and Random - Repeat opponent's last choice skewed by random setting.*
	class StrategyTitForTatAndRandom : Strategy
	{
		public override bool getDecision()
		{
			if (new StrategyRandom().getDecision())
			{
				return new StrategyTitForTat().getDecision();
			}
			else 
			{
				return new StrategyRandom().getDecision();
			}
		}
	}
}

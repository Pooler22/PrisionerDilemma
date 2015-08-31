using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	//Tit For Tat and Random - Repeat opponent's last choice skewed by random setting.*
	class StrategyTitForTatAndRandom : Strategy
	{
		public StrategyTitForTatAndRandom()
		{
			this.arrayWithEnemyAnswer = new ArrayList();
		}

		public StrategyTitForTatAndRandom(ArrayList arrayList)
		{
			this.arrayWithEnemyAnswer = arrayList;
		}

		public override bool getDecision()
		{
			if (new StrategyRandom().getDecision())
			{
				return new StrategyTitForTat(arrayWithEnemyAnswer).getDecision();
			}
			else 
			{
				return new StrategyRandom().getDecision();
			}
		}
	}
}

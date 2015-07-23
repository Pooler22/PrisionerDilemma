using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	//Naive Prober (Tit For Tat with Random Defection) - Repeat opponent's last choice (ie Tit For Tat), but sometimes probe by defecting in lieu of co-operating.*
	class StrategyNativeProber : Strategy
	{
		public override bool getDecision()
		{
			if ((arrayWithEnemyAnswer.Count != 0) && ((bool)arrayWithEnemyAnswer[arrayWithEnemyAnswer.Count - 1] == Decision.COOPERATE) && new StrategyRandom().getDecision())
			{
				return Decision.DEFECT;
			}
			return new StrategyTitForTat(this.arrayWithEnemyAnswer).getDecision();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	//Remorseful Prober (Tit For Tat with Random Defection) - Repeat opponent's last choice (ie Tit For Tat), but sometimes probe by defecting in lieu of co-operating. If the opponent defects in response to probing, show remorse by co-operating once.*
	class StrategyRemorsefulProber : Strategy
	{
		bool probing = false;
		public override bool getDecision()
		{
			if (arrayWithEnemyAnswer.Count > 0)
			{
				if (probing && ((bool)arrayWithEnemyAnswer[arrayWithEnemyAnswer.Count - 1] == Decision.DEFECT))
				{
					probing = false;
					return Decision.COOPERATE;
				}
				else if (new StrategyRandom().getDecision() && ((bool)arrayWithEnemyAnswer[arrayWithEnemyAnswer.Count - 1] == Decision.COOPERATE))
				{
					probing = true;
					return Decision.DEFECT;
				}
			}
			return new StrategyTitForTat(arrayWithEnemyAnswer).getDecision();
		}
	}
}

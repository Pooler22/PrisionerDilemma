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
			if (probing && ((bool)arrayWithEnemyAnswer[arrayWithEnemyAnswer.Count - 1] == defect)) 
			{
				probing = false;
				return cooperate;
			}
			else if (new StrategyRandom().getDecision() && ((bool)arrayWithEnemyAnswer[arrayWithEnemyAnswer.Count - 1] == cooperate))
			{
				probing = true;
				return defect;
			}
			return new StrategyTitForTat(arrayWithEnemyAnswer).getDecision();
		}
	}
}

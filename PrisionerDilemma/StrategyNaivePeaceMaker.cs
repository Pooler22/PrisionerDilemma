using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	//Naive Peace Maker (Tit For Tat with Random Co-operation) - Repeat opponent's last choice (ie Tit For Tat), but sometimes make peace by co-operating in lieu of defecting.*
	class StrategyNaivePeaceMake : Strategy
	{
		public override bool getDecision()
		{
			if ((arrayWithEnemyAnswer.Count > 0) && ((bool)arrayWithEnemyAnswer[arrayWithEnemyAnswer.Count - 1] == defect) && (new StrategyRandom().getDecision()))
			{
				return cooperate;
			}
			return new StrategyTitForTatAndRandom().getDecision();
		}
	}
}

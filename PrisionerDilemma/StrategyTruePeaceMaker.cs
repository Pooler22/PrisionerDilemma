using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	//True Peace Maker (hybrid of Tit For Tat and Tit For Two Tats with Random Co-operation) - Co-operate unless opponent defects twice in a row, then defect once, but sometimes make peace by co-operating in lieu of defecting.*
	class StrategyTruePeaceMaker : Strategy
	{		
		public override bool getDecision()
		{
			if (new StrategyTitForTwoTat(arrayWithEnemyAnswer).getDecision() == Decision.DEFECT && new StrategyRandom().getDecision())
				return Decision.COOPERATE;
			return new StrategyTitForTwoTat(arrayWithEnemyAnswer).getDecision();
		}
	}
}

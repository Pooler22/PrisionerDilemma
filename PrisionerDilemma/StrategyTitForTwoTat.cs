using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	//Tit For Two Tats - Like Tit For Tat except that opponent must make the same choice twice in row before it is reciprocated.
	class StrategyTitForTwoTat : Strategy
	{
		bool nextDecision;

		public StrategyTitForTwoTat()
		{
			this.arrayWithEnemyAnswer = new ArrayList();
		}

		public StrategyTitForTwoTat(ArrayList arrayList)
		{
			this.arrayWithEnemyAnswer = arrayList;
			if (this.arrayWithEnemyAnswer.Count > 1)
				nextDecision = (bool)arrayWithEnemyAnswer[arrayWithEnemyAnswer.Count - 2];
		}

		public override bool getDecision()
		{
			if (arrayWithEnemyAnswer.Count == 0)
			{
				nextDecision = Decision.COOPERATE;
				return Decision.COOPERATE;
			}
			else if ((bool)arrayWithEnemyAnswer[arrayWithEnemyAnswer.Count - 1] == Decision.COOPERATE)
			{
				nextDecision = Decision.COOPERATE;
				return Decision.COOPERATE;
			}
			else if (nextDecision == Decision.DEFECT)
			{
				nextDecision = Decision.COOPERATE;
				return Decision.DEFECT;
			}
			else
			{
				nextDecision = Decision.DEFECT;
				return Decision.COOPERATE;
			}
		}
	}
}

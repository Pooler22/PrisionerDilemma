using System;
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

		public override bool getDecision()
		{
			if (arrayWithEnemyAnswer.Count == 0)
			{
				nextDecision = cooperate;
				return cooperate;
			}
			else if (nextDecision)
			{
				nextDecision = cooperate;
				return defect;
			}
			else if ((bool)arrayWithEnemyAnswer[arrayWithEnemyAnswer.Count - 1] == cooperate)
			{
				nextDecision = cooperate;
				return cooperate;
			}
			else
			{
				nextDecision = defect;
				return cooperate;
			}
		}
	}
}

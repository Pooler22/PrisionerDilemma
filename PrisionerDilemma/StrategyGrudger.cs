using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	//Grudger (Co-operate, but only be a sucker once) - Co-operate until the opponent defects. Then always defect unforgivingly.
	class StrategyGrudger : Strategy
	{
		bool unforgivinglyFlag = false;

		public override bool getDecision()
		{
			if ((arrayWithEnemyAnswer.Count > 0) && ((bool)arrayWithEnemyAnswer[arrayWithEnemyAnswer.Count - 1] == defect))
			{
				unforgivinglyFlag = true;
			}
			if (unforgivinglyFlag)
			{
				return defect;
			}
			else
			{
				return cooperate;
			}
		}
	}
}

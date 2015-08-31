using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	//Gradual - Co-operates until the opponent defects, in such case defects the total number of times the opponent has defected during the game. Followed up by two co-operations.
	class StrategyGradual : Strategy
	{
		int defectNumber = 0;
		int currentDefectNumber = 0;

		public override bool getDecision()
		{
			if ((arrayWithEnemyAnswer.Count > 0) && (bool)arrayWithEnemyAnswer[arrayWithEnemyAnswer.Count - 1] == Decision.DEFECT)
			{
				defectNumber++;
				currentDefectNumber++;
				return Decision.DEFECT;
			}
			if (currentDefectNumber != defectNumber)
			{
				currentDefectNumber++;
				return Decision.DEFECT;
			}
			return Decision.COOPERATE;
		}
	}
}

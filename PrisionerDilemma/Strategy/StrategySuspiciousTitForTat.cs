using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	//Suspicious Tit For Tat - As for Tit For Tat except begins by defecting.
	class StrategySuspiciousTitForTat : Strategy
	{
		public override bool getDecision()
		{
			if (arrayWithEnemyAnswer.Count > 0)
				return new StrategyTitForTat(arrayWithEnemyAnswer).getDecision();
			return Decision.DEFECT;
		}
	}
}

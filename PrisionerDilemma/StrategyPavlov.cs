using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	//Pavlov (repeat last choice if good outcome) - If points scored in the last round then repeat last choice.
	class StrategyPavlov : Strategy
	{
		bool myLastDecision;

		public StrategyPavlov()
		{
			this.arrayWithEnemyAnswer = new ArrayList();
		}

		public StrategyPavlov(ArrayList arrayList)
		{
			this.arrayWithEnemyAnswer = arrayList;
		}

		public override bool getDecision()
		{
			if ((arrayWithEnemyAnswer.Count > 0) && ((bool)arrayWithEnemyAnswer[arrayWithEnemyAnswer.Count - 1]) != myLastDecision)
			{
				return myLastDecision = Decision.DEFECT;
			}
			else 
			{
				myLastDecision = Decision.COOPERATE;
				return Decision.COOPERATE;
			}
		}
	}
}
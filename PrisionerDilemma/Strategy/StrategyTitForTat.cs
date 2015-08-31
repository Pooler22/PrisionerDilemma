using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	//Tit For Tat - Repeat opponent's last choice.
	class StrategyTitForTat : Strategy
	{

		public StrategyTitForTat()
		{
			this.arrayWithEnemyAnswer = new ArrayList();
		}

		public StrategyTitForTat(ArrayList arrayList)
		{
			this.arrayWithEnemyAnswer = arrayList;
		}

		public override bool getDecision()
		{
			if (arrayWithEnemyAnswer.Count == 0)
			{
				return Decision.COOPERATE;
			}
			else 
			{
				return (bool)arrayWithEnemyAnswer[arrayWithEnemyAnswer.Count - 1];
			}
		}
	}
}

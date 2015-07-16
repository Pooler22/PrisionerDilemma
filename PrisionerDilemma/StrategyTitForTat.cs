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
			arrayWithEnemyAnswer = new ArrayList();
		}

		public StrategyTitForTat(ArrayList arrayList)
		{
			this.arrayWithEnemyAnswer = arrayList;
		}
		

		public override bool getDecision()
		{
			if (arrayWithEnemyAnswer.Count == 0)
			{
				return cooperate;
			}
			else 
			{
				return (bool)arrayWithEnemyAnswer[arrayWithEnemyAnswer.Count - 1];
			}
		}
	}
}

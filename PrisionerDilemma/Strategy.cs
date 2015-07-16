using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	public abstract class Strategy
	{
		public bool defect = true;
		public bool cooperate = false;
		public ArrayList arrayWithEnemyAnswer;

		public Strategy() {
			arrayWithEnemyAnswer = new ArrayList();
		}

		public Strategy(ArrayList arrayWithEnemyAnswer)
		{
			this.arrayWithEnemyAnswer = arrayWithEnemyAnswer;
		}

		public abstract bool getDecision();
	}
}

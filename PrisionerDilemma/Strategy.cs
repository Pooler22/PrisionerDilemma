using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*strategy name and description convention from http://www.iterated-prisoners-dilemma.net/prisoners-dilemma-strategies.shtml */

namespace PrisionerDilemma
{
	public abstract class Strategy
	{
		public ArrayList arrayWithEnemyAnswer;
		public bool decision;

		public Strategy() {
			arrayWithEnemyAnswer = new ArrayList();
		}

		public Strategy(ArrayList arrayWithEnemyAnswer)
		{
			this.arrayWithEnemyAnswer = arrayWithEnemyAnswer;
		}

		public abstract bool getDecision();

		public void setPlayerDecision(bool decision)
		{
			this.decision = decision;
		}
	}
}

using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	public class Player
	{
		public bool defect = true;
		public bool cooperate = false;
		public int score;
		public Strategy currentStrategy;
		
		public Player() 
		{
			score = 0;
		}

		public void setStrategy(string strategyName) 
		{
			currentStrategy = (Strategy)Activator.CreateInstance(Type.GetType("PrisionerDilemma." + strategyName));
		}

		public bool getDecision()
		{
			return currentStrategy.getDecision();
		}

		public void updateDetails(bool enemyAnswer, int score) 
		{
			currentStrategy.arrayWithEnemyAnswer.Add(enemyAnswer);
			this.score += score;
		}

		/*strategy name and description convention http://www.iterated-prisoners-dilemma.net/prisoners-dilemma-strategies.shtml */
	}
}

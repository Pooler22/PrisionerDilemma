using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	public class Player
	{
		int score;
		Strategy currentStrategy;
		
		public Player() 
		{
			score = 0;
		}

		public void setStrategy(string strategyName) 
		{
			currentStrategy = (Strategy)Activator.CreateInstance(Type.GetType("PrisionerDilemma." + strategyName));
		}

		public void setPlayerDecision(bool decision)
		{
			currentStrategy.setPlayerDecision(decision);
		}

		public bool getDecision()
		{
			return currentStrategy.getDecision();
		}

		public int getScore()
		{
			return this.score;
		}

		public void setDetails(bool enemyAnswer, int score) 
		{
			currentStrategy.arrayWithEnemyAnswer.Add(enemyAnswer);
			this.score += score;
		}
	}
}

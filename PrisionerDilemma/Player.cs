using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	public class Player
	{
		int scoreSum;
        public List<int> scoreList;
		public Strategy currentStrategy;
		
		public Player() 
		{
            scoreList = new List<int>();
            scoreSum = new int();
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
			return this.scoreSum;
		}
        public int getScore(int element)
        {
            return this.scoreList.ElementAt(element);
        }

        public void setDetails(bool enemyAnswer, int score) 
		{
			currentStrategy.arrayWithEnemyAnswer.Add(enemyAnswer);
			this.scoreSum += score;
            this.scoreList.Add(score);
		}
	}
}

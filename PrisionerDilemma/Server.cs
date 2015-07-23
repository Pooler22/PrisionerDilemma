using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	public class Server
	{
		Player player1;
		Player player2;

		int defectCooperateRule;
		int defectDefectRule;
		int cooperateCooperateRule;
		int cooperateDefectRule;

		public int lastScorePlayer1;
		public int lastScorePlayer2;
		public bool lastAnswerPlayer1;
		public bool lastAnswerPlayer2;

		public Server() {
			player1 = new Player();
			player2 = new Player();
		}

		public void setRules(int defectCooperate, int cooperateCooperate, int defectDefect, int cooperateDefectRule)
		{
			this.defectCooperateRule = defectCooperate;
			this.cooperateCooperateRule = cooperateCooperate;
			this.defectDefectRule = defectDefect;
			this.cooperateDefectRule = cooperateDefectRule;
		}

		public void setStrategy1(string strategyName)
		{
			player1.setStrategy(strategyName);
		}

		public void setStrategy2(string strategyName)
		{
			player2.setStrategy(strategyName);
		}

		public void play()
		{
			lastAnswerPlayer1 = player1.getDecision();
			lastAnswerPlayer2 = player2.getDecision();

			if (lastAnswerPlayer1 == Decision.DEFECT && lastAnswerPlayer2 == Decision.DEFECT)
			{
				player1.setDetails(lastAnswerPlayer2, defectDefectRule);
				player2.setDetails(lastAnswerPlayer1, defectDefectRule);
				lastScorePlayer1 = lastScorePlayer2 = defectDefectRule;
			}
			else if (lastAnswerPlayer1 == Decision.COOPERATE && lastAnswerPlayer2 == Decision.DEFECT)
			{
				player1.setDetails(lastAnswerPlayer2, defectCooperateRule);
				player2.setDetails(lastAnswerPlayer1, cooperateDefectRule);
				lastScorePlayer1 = cooperateDefectRule;
				lastScorePlayer2 = defectCooperateRule;
			}
			else if (lastAnswerPlayer1 == Decision.DEFECT && lastAnswerPlayer2 == Decision.COOPERATE)
			{
				player1.setDetails(lastAnswerPlayer2, defectCooperateRule);
				player2.setDetails(lastAnswerPlayer1, cooperateDefectRule);
				lastScorePlayer1 = defectCooperateRule;
				lastScorePlayer2 = cooperateDefectRule;
			}
			else if (lastAnswerPlayer1 == Decision.COOPERATE && lastAnswerPlayer2 == Decision.COOPERATE)
			{
				player1.setDetails(lastAnswerPlayer2, cooperateCooperateRule);
				player2.setDetails(lastAnswerPlayer1, cooperateCooperateRule);
				lastScorePlayer1 = lastScorePlayer2 = cooperateCooperateRule;
			}
		}

		public void setPlayerDecision1(bool decision)
		{
			player1.setPlayerDecision(decision);
		}

		public void setPlayerDecision2(bool decision)
		{
			player2.setPlayerDecision(decision);
		}

		public int getScore1()
		{
			return player1.getScore();
		}

		public int getScore2()
		{
			return player2.getScore();
		}
	}
}

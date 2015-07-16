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
		bool lastAnswerPlayer1;
		bool lastAnswerPlayer2;
		public Player player1;
		public Player player2;

		//rules
		int defectCooperate = 3;
		int cooperateCooperate = 1;
		int	defectDefect = 2;

		public Server() {
			player1 = new Player();
			player2 = new Player();
		}

		public void setStrategy(string strategyName1, string strategyName2)
		{
			player1.setStrategy(strategyName1);
			player2.setStrategy(strategyName2);
		}

		public void play()
		{
			

			lastAnswerPlayer1 = player1.getDecision();
			lastAnswerPlayer2 = player2.getDecision();

			if (lastAnswerPlayer1 && lastAnswerPlayer2)
			{
				player1.updateDetails(lastAnswerPlayer2, defectDefect);
				player2.updateDetails(lastAnswerPlayer1, defectDefect);
			}
			else if (!lastAnswerPlayer1 && lastAnswerPlayer2)
			{
				player2.updateDetails(lastAnswerPlayer1, defectCooperate);
			}
			else if (lastAnswerPlayer1 && !lastAnswerPlayer2)
			{
				player1.updateDetails(lastAnswerPlayer2, defectCooperate);
			}
			else if (!lastAnswerPlayer1 && !lastAnswerPlayer2)
			{
				player1.updateDetails(lastAnswerPlayer2, cooperateCooperate);
				player2.updateDetails(lastAnswerPlayer1, cooperateCooperate);
			}
		}
	}
}

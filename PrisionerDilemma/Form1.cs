using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisionerDilemma
{
	public partial class Form1 : Form
	{
		string[] arrayStrategyNames = {   "StrategyCooperate","StrategyDefect","StrategyGenetic","StrategyGradual","StrategyGrudger",
										  "StrategyNaivePeaceMaker","StrategyNativeProber","StrategyPavlov","StrategyPavlovAndRandom",
										  "StrategyRandom", "StrategyRemorsefulProber","StrategySuspiciousTitForTat","StrategyTitForTat",
										  "StrategyTitForTatAndRandom","StrategyTitForTwoTat", "StrategyTitForTwoTatAndRandom",
										  "StrategyTruePeaceMaker", "StrategyHomoSapiens"
									  };
		bool flagStrategy1Selected = false, flagStrategy2Selected = false;
		bool flagPlayer1Decision = false, flagPlayer2Decision = false;
		Server server;

		int cooperateDefectRule = 3;
		int defectDefectRule = 2;
		int cooperateCooperateRule = 1;
		int defectCooperateRule = 0;

		public Form1()
		{
			InitializeComponent();
			comboBoxPlayer1.Items.AddRange(arrayStrategyNames);
			comboBoxPlayer2.Items.AddRange(arrayStrategyNames);
			server = new Server();
			server.setRules(defectCooperateRule, cooperateCooperateRule, defectDefectRule, cooperateDefectRule);
		}

		private void comboBoxPlayer1_SelectionChangeCommitted(object sender, EventArgs e)
		{
			server.setStrategy1(comboBoxPlayer1.SelectedItem.ToString());
			if (comboBoxPlayer1.SelectedIndex == 17)
			{
				buttonCooperatePlayer1.Visible = buttonDefectPlayer1.Visible = true;
			}
			else 
			{
				buttonCooperatePlayer1.Visible = buttonDefectPlayer1.Visible = false;
				flagPlayer1Decision = true;
			}
			flagStrategy1Selected = true;
		}

		private void comboBoxPlayer2_SelectionChangeCommitted(object sender, EventArgs e)
		{
			server.setStrategy2(comboBoxPlayer2.SelectedItem.ToString());
			if (comboBoxPlayer2.SelectedIndex == 17)
			{
				buttonCooperatePlayer2.Visible = buttonDefectPlayer2.Visible = true;	
			}
			else
			{
				buttonCooperatePlayer2.Visible = buttonDefectPlayer2.Visible = false;
				flagPlayer2Decision = true;
			}
			flagStrategy2Selected = true;
		}

		private void buttonCooperatePlayer1_Click(object sender, EventArgs e)
		{
			server.setPlayerDecision1(Decision.COOPERATE);
			flagPlayer1Decision = true;
			check();
		}

		private void buttonDefectPlayer1_Click(object sender, EventArgs e)
		{
			server.setPlayerDecision1(Decision.DEFECT);
			flagPlayer1Decision = true;
			check();
		}

		private void buttonCooperatePlayer2_Click(object sender, EventArgs e)
		{
			server.setPlayerDecision2(Decision.COOPERATE);
			flagPlayer2Decision = true;
			check();
		}

		private void buttonDefectPlayer2_Click(object sender, EventArgs e)
		{
			server.setPlayerDecision2(Decision.DEFECT);
			flagPlayer2Decision = true;
			check();
		}

		private void check()
		{
			if (flagStrategy1Selected && flagStrategy2Selected)
			{
				if (flagPlayer1Decision && flagPlayer2Decision)
				{
					server.play();
					
					if (server.lastAnswerPlayer1 == Decision.DEFECT)
						labelLastDecisionPlayer1.Text = "defect";
					else
						labelLastDecisionPlayer1.Text = "cooperate";
					if (server.lastAnswerPlayer2 == Decision.DEFECT)
						labelLastDecisionPlayer2.Text = "defect";
					else
						labelLastDecisionPlayer2.Text = "cooperate";

					labelLastScorePlayer1.Text = server.lastScorePlayer1.ToString();
					labelLastScorePlayer2.Text = server.lastScorePlayer2.ToString();
					labelTotalScorePlayer1.Text = server.getScore1().ToString();
					labelTotalScorePlayer2.Text = server.getScore2().ToString();

					if (comboBoxPlayer1.SelectedIndex == 17)
						flagPlayer1Decision = false;
					if (comboBoxPlayer2.SelectedIndex == 17)
						flagPlayer2Decision = false;

				}
			}
		}

		private void buttonStartIteration_Click(object sender, EventArgs e)
		{
			if (Int32.Parse(textBoxNumberOfIteration.Text) > 0) 
			{
				for(int index = 0; index < Int32.Parse(textBoxNumberOfIteration.Text); index++)
				{
					check();
				}
			}
		}

		private void buttonHelp_Click(object sender, EventArgs e)
		{
			System.Threading.Thread FormHelp = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadFromHelp));
			FormHelp.Start();
		}

        private void buttonReset_Click(object sender, EventArgs e)
        {
            labelLastDecisionPlayer1.Text = "none";
            labelLastDecisionPlayer2.Text = "none";
            labelLastScorePlayer1.Text = "0";
            labelLastScorePlayer2.Text = "0";
            labelTotalScorePlayer1.Text = "0";
            labelTotalScorePlayer2.Text = "0";
            textBoxNumberOfIteration.Text = "100";
            server = new Server();
            server.setRules(defectCooperateRule, cooperateCooperateRule, defectDefectRule, cooperateDefectRule);
            server.setStrategy1(comboBoxPlayer1.SelectedItem.ToString());
            server.setStrategy2(comboBoxPlayer2.SelectedItem.ToString());
        }

        private void button_AllVsAll(object sender, EventArgs e)
        {
            int n = arrayStrategyNames.Length - 1;
            int m = 0;
            
            StringBuilder output = new System.Text.StringBuilder();
            var saveFileDialog1 = new SaveFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = string.Format("{0}Text files (*.txt)|*.txt|All files (*.*)|*.*", "ARG0"),
                RestoreDirectory = true,
                ShowHelp = true,
                CheckFileExists = false
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int index1 = 0; index1 < n; index1++)
                {
                    m++;
                    for (int index2 = m; index2 < n; index2++)
                    {
                        server = new Server();
                        server.setRules(defectCooperateRule, cooperateCooperateRule, defectDefectRule, cooperateDefectRule);
                        server.setStrategy1(arrayStrategyNames.ElementAt(index1));
                        server.setStrategy2(arrayStrategyNames.ElementAt(index2));
                        for(int i = 0; i < Int32.Parse(textBoxNumberOfIteration.Text); i++)
                            server.play();

                        output.AppendLine(server.player1.currentStrategy.ToString().Substring("PrisionerDilemma.Strategy".Length) + "\t" + server.player2.currentStrategy.ToString().Substring("PrisionerDilemma.Strategy".Length));
                    
						for (int index = 0; index < server.player1.currentStrategy.arrayWithEnemyAnswer.Count; index++)
							output.AppendLine(
								server.player1.currentStrategy.arrayWithEnemyAnswer[index].ToString() +
								"\t" +
								server.player1.scoreList.ElementAt(index) +
								"\t" +
								server.player2.currentStrategy.arrayWithEnemyAnswer[index].ToString() +
								"\t" +
								server.player2.scoreList.ElementAt(index)
								);
                        output.AppendLine(""+server.player1.getScore()+"\t"+server.player2.getScore() + "");
                        File.WriteAllText(saveFileDialog1.FileName, output.ToString());
                    }
                }
            }

        }

        public static void ThreadFromHelp()
		{
			Application.Run(new FormHelp());
		}

		private void button_SaveTofile(object sender, EventArgs e)
		{
			StringBuilder output = new System.Text.StringBuilder();
			var saveFileDialog1 = new SaveFileDialog
			{
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
				Filter = string.Format("{0}Text files (*.txt)|*.txt|All files (*.*)|*.*", "ARG0"),
				RestoreDirectory = true,
				ShowHelp = true,
				CheckFileExists = false
			};

			output.AppendLine(server.player1.currentStrategy.ToString().Substring("PrisionerDilemma.Strategy".Length) + "\t" + server.player2.currentStrategy.ToString().Substring("PrisionerDilemma.Strategy".Length));
			output.AppendLine("Player1\tPlayer2");
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                for (int index = 0; index < server.player1.currentStrategy.arrayWithEnemyAnswer.Count; index++)
                    output.AppendLine(
                        server.player2.currentStrategy.arrayWithEnemyAnswer[index].ToString()+
                        "\t" +
                        server.player1.scoreList.ElementAt(index)+
                        "\t" +
                        server.player1.currentStrategy.arrayWithEnemyAnswer[index].ToString() +
                        "\t"+
                        server.player2.scoreList.ElementAt(index)
                        );
			File.WriteAllText(saveFileDialog1.FileName, output.ToString());
		}
	}
}

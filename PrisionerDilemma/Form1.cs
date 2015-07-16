using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisionerDilemma
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Server server = new Server();
			server.setStrategy("StrategyDefect", "StrategyTitForTat");
			server.play();
			Console.WriteLine(server.player1.score);
			Console.WriteLine(server.player2.score);
			server.play();
			Console.WriteLine(server.player1.score);
			Console.WriteLine(server.player2.score);
		}
	}
}

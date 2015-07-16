using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrisionerDilemma;
using System.Diagnostics;

namespace UnitTestProject
{
	[TestClass]
	public class UnitTest1
	{

		[TestMethod]
		public void StrategyCooperate()
		{
			Player player = new Player();
			player.setStrategy("StrategyCooperate");
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
		}

		[TestMethod]
		public void StrategyDefect()
		{
			Player player = new Player();
			player.setStrategy("StrategyDefect");
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
		}

		[TestMethod]
		public void StrategyRandom()
		{
			Player player = new Player();
			player.setStrategy("StrategyRandom");
			Assert.IsNotNull(player.getDecision());
		}

		[TestMethod]
		public void StrategyTruePeaceMaker()
		{
			Player player = new Player();
			player.setStrategy("StrategyTruePeaceMaker");
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.defect, 0);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
		}

		[TestMethod]
		public void StrategyTitForTat()
		{
			Player player = new Player();
			player.setStrategy("StrategyTitForTat");
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
			
		}

		[TestMethod]
		public void StrategyTitForTwoTat()
		{
			Player player = new Player();
			player.setStrategy("StrategyTitForTwoTat");
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
			player.currentStrategy.arrayWithEnemyAnswer.Clear();

			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
			player.currentStrategy.arrayWithEnemyAnswer.Clear();

			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);

		}

		[TestMethod]
		public void StrategyNaivePeaceMake()
		{
			Player player = new Player();
			player.setStrategy("StrategyNaivePeaceMake");
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
		}

		[TestMethod]
		public void StrategyGrudger()
		{
			Player player = new Player();
			player.setStrategy("StrategyGrudger");
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
		}

		[TestMethod]
		public void StrategySuspiciousTitForTat()
		{
			Player player = new Player();
			player.setStrategy("StrategySuspiciousTitForTat");
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
		}

		[TestMethod]
		public void StrategyPavlov()
		{
			Player player = new Player();
			player.setStrategy("StrategyPavlov");
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
		}

		[TestMethod]
		public void StrategyNativeProber()
		{
			Player player = new Player();
			player.setStrategy("StrategyNativeProber");
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
			player.updateDetails(player.cooperate, 0);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
		}

		[TestMethod]
		public void StrategyGradual()
		{
			Player player = new Player();
			player.setStrategy("StrategyGradual");
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
			player.updateDetails(player.defect, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
			Assert.AreEqual<bool>(player.getDecision(), player.defect);
			player.updateDetails(player.cooperate, 0);
			Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
		}

		[TestMethod]
		public void StrategyRemorsefulProber()
		{
			Player player = new Player();
			player.setStrategy("StrategyRemorsefulProber");
			player.updateDetails(player.cooperate, 0);
			if(player.getDecision() == player.defect)
			{
				player.updateDetails(player.defect, 0);
				Assert.AreEqual<bool>(player.getDecision(), player.cooperate);
				player.updateDetails(player.defect, 0);
				Assert.AreEqual<bool>(player.getDecision(), player.defect);
			}
		}	
	}
}

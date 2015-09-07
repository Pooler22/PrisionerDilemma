using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrisionerDilemma;

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
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.DEFECT, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.DEFECT, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
		}

		[TestMethod]
		public void StrategyDefect()
		{
			Player player = new Player();
			player.setStrategy("StrategyDefect");
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
			player.setDetails(Decision.DEFECT, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
			player.setDetails(Decision.DEFECT, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
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
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.DEFECT, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.DEFECT, 0);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
		}

		[TestMethod]
		public void StrategyTitForTat()
		{
			Player player = new Player();
			player.setStrategy("StrategyTitForTat");
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.DEFECT, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.DEFECT, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
			
		}

		[TestMethod]
		public void StrategyTitForTwoTat()
		{
			Player player = new Player();
			player.setStrategy("StrategyTitForTwoTat");
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.DEFECT, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.DEFECT, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
		}

		[TestMethod]
		public void StrategyGrudger()
		{
			Player player = new Player();
			player.setStrategy("StrategyGrudger");
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.DEFECT, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
			player.setDetails(Decision.DEFECT, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
		}

		[TestMethod]
		public void StrategySuspiciousTitForTat()
		{
			Player player = new Player();
			player.setStrategy("StrategySuspiciousTitForTat");
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.DEFECT, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.DEFECT, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
		}

		[TestMethod]
		public void StrategyPavlov()
		{
			Player player = new Player();
			player.setStrategy("StrategyPavlov");
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.DEFECT, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
			player.setDetails(Decision.DEFECT, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
		}

		[TestMethod]
		public void StrategyNativeProber()
		{
			Player player = new Player();
			player.setStrategy("StrategyNativeProber");
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.DEFECT, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
			player.setDetails(Decision.COOPERATE, 0);
			player.setDetails(Decision.DEFECT, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
		}

		[TestMethod]
		public void StrategyGradual()
		{
			Player player = new Player();
			player.setStrategy("StrategyGradual");
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.DEFECT, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
			player.setDetails(Decision.DEFECT, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
			Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
			player.setDetails(Decision.COOPERATE, 0);
			Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
		}

		[TestMethod]
		public void StrategyRemorsefulProber()
		{
			Player player = new Player();
			player.setStrategy("StrategyRemorsefulProber");
			player.setDetails(Decision.COOPERATE, 0);
			if(player.getDecision() == Decision.DEFECT)
			{
				player.setDetails(Decision.DEFECT, 0);
				Assert.AreEqual<bool>(player.getDecision(), Decision.COOPERATE);
				player.setDetails(Decision.DEFECT, 0);
				Assert.AreEqual<bool>(player.getDecision(), Decision.DEFECT);
			}
		}	
	}
}

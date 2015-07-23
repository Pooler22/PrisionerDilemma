using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	class StrategyGenetic : Strategy
	{
		string[] arrayStrategyNames = {   "StrategyCooperate","StrategyDefect","StrategyGradual","StrategyGrudger","StrategyTruePeaceMaker",
										  "StrategyNaivePeaceMaker","StrategyNativeProber","StrategyPavlov","StrategyPavlovAndRandom",
										  "StrategyRandom", "StrategyRemorsefulProber","StrategySuspiciousTitForTat","StrategyTitForTat",
										  "StrategyTitForTatAndRandom","StrategyTitForTwoTat", "StrategyTitForTwoTatAndRandom"
									  };
		int numberOfIteration;
		int sizeRouletteWheel;
		bool lastDecision;
		List <bool> arrayPopulation;
		List<bool> arrayNewPopulation;
		List<int> arrayEvaluationOfAdaptation;
		Player player;

		public StrategyGenetic()
		{
			numberOfIteration = sizeRouletteWheel = 0;
			arrayPopulation = new List<bool>();
			arrayNewPopulation = new List<bool>();
			arrayEvaluationOfAdaptation = new List<int>();
			player = new Player();
		}

		public override bool getDecision()
		{
			generatePopulation();
			if (numberOfIteration > 0)
				evaluationOfAdaptation();
			rouletteWheelSelection();
			hybridization();
			mutation();
			numberOfIteration++;
			return lastDecision = getChromosome();
		}

		private void generatePopulation()
		{
			foreach (string element in arrayStrategyNames)
			{
				player.setStrategy(element);
				arrayPopulation.Add(player.getDecision());
				arrayEvaluationOfAdaptation.Add(0);
			}
		}

		private void evaluationOfAdaptation()
		{
			for (int index = 0; index < arrayStrategyNames.Length; index++)
			{
				if (((bool)arrayWithEnemyAnswer[arrayWithEnemyAnswer.Count - 1] != Decision.DEFECT) && arrayPopulation[numberOfIteration * arrayStrategyNames.Length + index] != Decision.COOPERATE)
				{
					arrayEvaluationOfAdaptation[index]++;
					sizeRouletteWheel++;
				}
			}
		}

		private void rouletteWheelSelection()
		{
			int tmpSelectedNumber;
			int tmpSum = 0;

			for (int index = 0; index < arrayStrategyNames.Length; index++)
			{
				tmpSelectedNumber = new Random().Next(0, sizeRouletteWheel);
				for (int index1 = 0; index1 < arrayStrategyNames.Length; index1++)
				{
					tmpSum += arrayEvaluationOfAdaptation[index1];
					if (tmpSelectedNumber <= tmpSum)
					{
						for (int index2 = 0; index2 < numberOfIteration; index2++)
							arrayNewPopulation[index * arrayStrategyNames.Length + index2] = arrayPopulation[index1 * arrayStrategyNames.Length + index2];
						break;
					}
				}
			}
		}

		private void hybridization()
		{
			int locus = new Random().Next(1, numberOfIteration - 1);
			int[] arrayPair = new int[arrayStrategyNames.Length];
			int index = 0;
			bool tmp;

			for (int index1 = 0; index1 < arrayPair.Length; index1++)
			{
				arrayPair[index1] = index1;
			}
			new Random().Shuffle(arrayPair);

			while (index < arrayStrategyNames.Length)
			{
				for (int index1 = locus; index1 < numberOfIteration; index1++)
				{
					tmp = arrayNewPopulation[arrayStrategyNames.Length * arrayPair[index] + index1];
					arrayNewPopulation[arrayStrategyNames.Length * arrayPair[index] + index1] = arrayNewPopulation[arrayStrategyNames.Length * arrayPair[index + 1] + index1];
					arrayNewPopulation[arrayStrategyNames.Length * arrayPair[index + 1] + index1] = tmp;
				}
					index += 2;
			}
		}

		private void mutation()
		{
			int valueMutationNumber = new Random().Next(1, arrayStrategyNames.Length - 1);
			arrayNewPopulation[valueMutationNumber * arrayStrategyNames.Length + new Random().Next(1, numberOfIteration - 1)] = !arrayNewPopulation[valueMutationNumber * arrayStrategyNames.Length + new Random().Next(1, numberOfIteration - 1)];
		}

		private bool getChromosome()
		{
			return arrayNewPopulation[new Random().Next(1, numberOfIteration*arrayStrategyNames.Length - 1)];
		}
	}
}
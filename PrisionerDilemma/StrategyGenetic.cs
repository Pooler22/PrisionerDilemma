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
			numberOfIteration = 0;
            sizeRouletteWheel = arrayStrategyNames.Length;
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
            lastDecision = getChromosome();
            numberOfIteration++;
            return lastDecision;

        }

        private void generatePopulation()
		{
			foreach (string element in arrayStrategyNames)
			{
				player.setStrategy(element);
				arrayPopulation.Add(player.getDecision());
                arrayEvaluationOfAdaptation.Add(1);
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
			int tmpSum;

			for (int index = 0; index < arrayStrategyNames.Length; index++)
			{
				tmpSelectedNumber = new Random().Next(0, sizeRouletteWheel);
                tmpSum = 0;
                for (int index1 = 0; index1 < arrayStrategyNames.Length; index1++)
				{
					tmpSum += arrayEvaluationOfAdaptation[index1];
                    if (tmpSelectedNumber <= tmpSum)
                    {
                        arrayNewPopulation.Add(arrayPopulation.ElementAt(numberOfIteration * arrayStrategyNames.Length + index1));
						break;
					}
				}
                
            }
		}

		private void hybridization()
		{
            bool tmp;
            int tmpI, index = 0, n = arrayStrategyNames.Length;
            string tmpS;
            
            do
            {
                for(int index1 = 0; index1 < n - 1; index++)
                {
                    if(arrayEvaluationOfAdaptation[index1] < arrayEvaluationOfAdaptation[index1 + 1])
                    {
                        tmpI = arrayEvaluationOfAdaptation[index1];
                        arrayEvaluationOfAdaptation[index1] = arrayEvaluationOfAdaptation[index1 + 1];
                        arrayEvaluationOfAdaptation[index1 + 1] = tmpI;
                        tmpS = arrayStrategyNames[index1];
                        arrayStrategyNames[index1] = arrayStrategyNames[index1 + 1];
                        arrayStrategyNames[index1 + 1] = tmpS;
                        tmp = arrayPopulation[numberOfIteration * arrayStrategyNames.Length + index1];
                        arrayPopulation[numberOfIteration * arrayStrategyNames.Length + index1] = arrayPopulation[numberOfIteration * arrayStrategyNames.Length + index1 + 1];
                        arrayPopulation[numberOfIteration * arrayStrategyNames.Length + index1 + 1] = tmp;
                    }
                    n--;
                }
            } while (n > 1);

			while ((index + 1) < arrayStrategyNames.Length)
			{
                arrayPopulation[numberOfIteration * arrayStrategyNames.Length + index] = arrayNewPopulation[numberOfIteration * arrayStrategyNames.Length + index];
                arrayPopulation[numberOfIteration * arrayStrategyNames.Length + index + 1] = arrayNewPopulation[numberOfIteration * arrayStrategyNames.Length + index + 1];
                arrayNewPopulation[numberOfIteration * arrayStrategyNames.Length + index] = arrayPopulation[numberOfIteration * arrayStrategyNames.Length + index + 1];
                arrayNewPopulation[numberOfIteration * arrayStrategyNames.Length + index + 1] = arrayPopulation[numberOfIteration * arrayStrategyNames.Length + index];
                index += 2;
			}
		}

		private void mutation()
		{
			int valueMutationNumber = new Random().Next(0, arrayStrategyNames.Length - 1);
			arrayNewPopulation[numberOfIteration * arrayStrategyNames.Length + valueMutationNumber] = !arrayNewPopulation[numberOfIteration * arrayStrategyNames.Length + valueMutationNumber];
		}

		private bool getChromosome()
		{
            return arrayNewPopulation[numberOfIteration * arrayStrategyNames.Length];
		}
    }
}
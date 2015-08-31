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
        int numberOfPopulation;
        int sizeRouletteWheel;
        bool lastDecision;
        List <bool> arrayPopulation;
		List<bool> arrayNewPopulation;
		List<int> arrayEvaluationOfAdaptation;
		Player player;

		public StrategyGenetic()
		{
			numberOfIteration = 0;
            numberOfPopulation = sizeRouletteWheel = arrayStrategyNames.Length;
            arrayPopulation = new List<bool>();
			arrayNewPopulation = new List<bool>();
			arrayEvaluationOfAdaptation = new List<int>();
			player = new Player();
            foreach (string element in arrayStrategyNames)
            {
                arrayEvaluationOfAdaptation.Add(1);
            }
        }

		public override bool getDecision()
		{
            generatePopulation();
			if (numberOfIteration > 0)
				evaluationOfAdaptation();
			rouletteWheelSelection();
            sort();
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
            }
		}

		private void evaluationOfAdaptation()
		{
			for (int index = 0; index < numberOfPopulation; index++)
			{
                if ((bool)arrayWithEnemyAnswer[arrayWithEnemyAnswer.Count - 1] == arrayNewPopulation[(numberOfIteration - 1) * numberOfPopulation + index])
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

			for (int index = 0; index < numberOfPopulation; index++)
			{
				tmpSelectedNumber = new Random().Next(0, sizeRouletteWheel);
                tmpSum = -1;
                for (int index1 = 0; index1 < numberOfPopulation; index1++)
				{
					tmpSum += arrayEvaluationOfAdaptation[index1];
                    if (tmpSelectedNumber <= tmpSum)
                    {
                        arrayNewPopulation.Add(arrayPopulation.ElementAt(numberOfIteration * numberOfPopulation + index1));
						break;
					}
				}   
            }
		}

        private void sort()
        {
            bool tmp;
            int tmpI, n = numberOfPopulation;
            string tmpS;

            do
            {
                for (int index1 = 0; index1 < n - 1; index1++)
                {
                    if (arrayEvaluationOfAdaptation[index1] < arrayEvaluationOfAdaptation[index1 + 1])
                    {
                        tmpI = arrayEvaluationOfAdaptation[index1];
                        arrayEvaluationOfAdaptation[index1] = arrayEvaluationOfAdaptation[index1 + 1];
                        arrayEvaluationOfAdaptation[index1 + 1] = tmpI;
                        tmpS = arrayStrategyNames[index1];
                        arrayStrategyNames[index1] = arrayStrategyNames[index1 + 1];
                        arrayStrategyNames[index1 + 1] = tmpS;
                        tmp = arrayNewPopulation[numberOfIteration * numberOfPopulation + index1];
                        arrayNewPopulation[numberOfIteration * numberOfPopulation + index1] = arrayNewPopulation[numberOfIteration * numberOfPopulation + index1 + 1];
                        arrayNewPopulation[numberOfIteration * numberOfPopulation + index1 + 1] = tmp;
                        tmp = arrayPopulation[numberOfIteration * numberOfPopulation + index1];
                        arrayPopulation[numberOfIteration * numberOfPopulation + index1] = arrayPopulation[numberOfIteration * numberOfPopulation + index1 + 1];
                        arrayPopulation[numberOfIteration * numberOfPopulation + index1 + 1] = tmp;
                    }
                }
                n--;
            } while (n > 1);
        }
		
		private void hybridization()
		{
            bool tmp;
            int index = 0;

			while ((index + 1) < numberOfPopulation)
			{
                tmp = arrayNewPopulation[numberOfIteration * numberOfPopulation + index];
                arrayNewPopulation[numberOfIteration * numberOfPopulation + index] = arrayNewPopulation[numberOfIteration * numberOfPopulation + index + 1];
                tmp = arrayNewPopulation[numberOfIteration * numberOfPopulation + index + 1];
                index += 2;
			}
		}

		private void mutation()
		{
			int valueMutationNumber = new Random().Next(0, numberOfPopulation - 1);
			arrayNewPopulation[(numberOfIteration * numberOfPopulation) + valueMutationNumber] = !arrayNewPopulation[(numberOfIteration * numberOfPopulation) + valueMutationNumber];
		}

		private bool getChromosome()
		{
            return arrayNewPopulation[numberOfIteration * numberOfPopulation];
		}
    }
}
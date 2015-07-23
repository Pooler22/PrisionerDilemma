using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	class StrategyGenetic : Strategy
	{
		int valuePopulation;
		int chromosomLength;
		bool[] arrayPopulation;
		bool[] arrayNewPopulation;
		int[] arrayEvaluationOfAdaptation;
		int sizeRouletteWheel;
		int valueIteration;

		public StrategyGenetic(int valuePopulation, int chromosomLength)
		{
			valueIteration = 0;
			this.valuePopulation = valuePopulation;
			this.chromosomLength = chromosomLength;
			arrayPopulation = new bool[valuePopulation * chromosomLength];
			arrayNewPopulation = new bool[valuePopulation * chromosomLength];
			arrayEvaluationOfAdaptation = new int[valuePopulation];
			sizeRouletteWheel = 0;
		}

		public void setIteration(int valueIteration)
		{
			this.valueIteration = valueIteration - 1;
		}

		public override bool getDecision()
		{
			generatePopulation();
			evaluationOfAdaptation();
			rouletteWheelSelection();
			hybridization();
			mutation();
			
			for(int index = 0; index < chromosomLength * valuePopulation; index++)
			{
				arrayPopulation[index] = arrayNewPopulation[index];
			}

			return arrayPopulation[valueIteration++];
		}

		void generatePopulation()
		{
			for (int index1 = 0; index1 < valuePopulation; index1++ )
			{
				for (int index2 = 0; index2 < chromosomLength; index2++)
				{
					arrayPopulation[index1 * valuePopulation + index2] = new Random().Next(0, 2) > 0;
				}
				arrayEvaluationOfAdaptation[index1] = 0;
			}
		}

		void evaluationOfAdaptation()
		{
			for (int index1 = 0; index1 < valuePopulation; index1++)
			{
				for (int index2 = 0; index2 < arrayWithEnemyAnswer.Count; index2++)
				{
					if (arrayPopulation[index1 * valuePopulation + (arrayWithEnemyAnswer.Count - 1)] != Decision.COOPERATE && (bool)arrayWithEnemyAnswer[arrayWithEnemyAnswer.Count - 1] != Decision.DEFECT) 
					{
						arrayEvaluationOfAdaptation[index1]++;
						sizeRouletteWheel++;
					}
				}
			}
		}

		void rouletteWheelSelection()
		{
			int tmpSelectedNumber = new Random().Next(0, sizeRouletteWheel);
			int tmpSum = 0;

			for (int index = 0; index < valuePopulation; index++)
			{
				for (int index1 = 0; index1 < valuePopulation; index1++)
				{
					tmpSum += arrayEvaluationOfAdaptation[index1];
					if (tmpSelectedNumber <= tmpSum)
					{
						for (int index2 = 0; index2 < chromosomLength; index2++)
						{
							arrayNewPopulation[index * valuePopulation + index2] = arrayPopulation[index1 * valuePopulation + index2];
						}
						break;
					}
				}
			}
		}

		void hybridization()
		{
			int locus = new Random().Next(1, chromosomLength - 1);
			var arrayPair = new int[chromosomLength];
			int index = 0;
			bool tmp;

			for (int index1 = 0; index1 < arrayPair.Length; index1++)
			{
				arrayPair[index1] = index1;
			}
			new Random().Shuffle(arrayPair);

			while (index < valuePopulation)
			{
				for (int index1 = locus; index1 < chromosomLength; index1++)
				{
					tmp = arrayNewPopulation[valuePopulation * arrayPair[index] + index1];
					arrayNewPopulation[valuePopulation * arrayPair[index] + index1] = arrayNewPopulation[valuePopulation * arrayPair[index + 1] + index1];
					arrayNewPopulation[valuePopulation * arrayPair[index + 1] + index1] = tmp;
				}
					index += 2;
			}
		}

		void mutation()
		{
			int valueMutationNumber = new Random().Next(1, valuePopulation - 1);
			arrayNewPopulation[valueMutationNumber * valuePopulation + new Random().Next(1, chromosomLength - 1)] = !arrayNewPopulation[valueMutationNumber * valuePopulation + new Random().Next(1, chromosomLength - 1)];
		}
	}
}
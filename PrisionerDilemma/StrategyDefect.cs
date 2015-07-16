using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrisionerDilemma
{
	//Always Defect
	class StrategyDefect : Strategy
	{
		public override bool getDecision()
		{
			return defect;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
	class Program
	{
		static void Main(string[] args)
		{
			FindLCS findLCS = new FindLCS();
			Testing testing = new Testing();
			StringGenerator generator = new StringGenerator();

			//findLCS.BruteLCS("aaaabbbcccceeeeeeee", "rrrreeeeeeeettffffaaaabbb");

			//testing.BruteWorstCase("BruteResultWorstCase.txt");

			//findLCS.BetterLCS("bbbbbbbaaaaacccccc", "ccccccaaaaabbbbbbb");

			//testing.BetterWorstCase("BetterResultWorstCase.txt");

			//testing.BruteRandom("BruteResultRandom.txt");

			//testing.BetterRandom("BetterResultsRandom.txt");

			//testing.BruteHugeText("BruteHugeTextTest.txt");

			//generator.HugeString(1000);
			//generator.RandomString(20);
			//generator.RandomString(50);
			//generator.RandomString(100);
			//generator.WorstCaseString(10);
			//generator.WorstCaseString(50);
			//generator.WorstCaseString(100);

			//testing.BetterHugeText("BetterTestHugeText.txt");
		}
}
	}

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

			//findLCS.BruteLCS("abcd", "xyz");

			//testing.BruteWorstCase("FirstTest.txt");

			//findLCS.BetterLCS("abcd", "xyz");

			//testing.BetterWorstCase("BetterFirstTest.txt");

			//testing.BruteRandom("BruteRandomTest.txt");

			//testing.BetterRandom("BetterRandomTest.txt");

			//testing.BruteHugeText("BruteFirstTest.txt");

			//generator.HugeString(500);
			//generator.RandomString(20);
			//generator.WorstCaseString(10);

			testing.BetterHugeText("BetterHugeTextTest.txt");
		}
}
	}

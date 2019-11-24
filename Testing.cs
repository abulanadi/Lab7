using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Lab7
{
	class Testing
	{
		string resultsFolderPath = "C:\\Users\\Adria\\School Stuff\\CSC482\\Lab7";
		static int MaxInput = Convert.ToInt32(Math.Pow(2, 15));
		static double numberOfTrials = 10;
		Stopwatch stopwatch = new Stopwatch();
		
		Random random = new Random();
		StringGenerator Generator = new StringGenerator();
		FindLCS findLCS = new FindLCS();

		public void BruteWorstCase(string resultFile)
		{
			double nanoSecs = 0;
			double doubleRatio = 0;
			double previousRatio = 0;
			Console.WriteLine("Input Size\tAvg Time (ns)\tDoubling Ratio");

			for(int i = 1; i <= MaxInput; i += i)
			{
				for(int trial = 0; trial < numberOfTrials; trial++)
				{
					string testString = Generator.WorstCaseString(i);

					stopwatch.Restart();
					findLCS.BruteLCS(testString, testString);
					stopwatch.Stop();
					nanoSecs += stopwatch.Elapsed.TotalMilliseconds * 1000000;
				}
				double averageTrialTime = nanoSecs / numberOfTrials;

				if(previousRatio > 0)
				{
					doubleRatio = averageTrialTime / previousRatio;
				}
				previousRatio = averageTrialTime;

				Console.WriteLine("{0,-10}\t{1,16}\t\t{2,10:N2}", i, averageTrialTime, doubleRatio);

				using (StreamWriter outputFile = new StreamWriter(Path.Combine(resultsFolderPath, resultFile), true))
				{
					outputFile.WriteLine("{0,-10} {1,16} {2,10:N2}", i, averageTrialTime, doubleRatio);
				}
			}
		}

		public void BetterWorstCase(string resultFile)
		{
			double nanoSecs = 0;
			double doubleRatio = 0;
			double previousRatio = 0;
			Console.WriteLine("Input Size\tAvg Time (ns)\tDoubling Ratio");

			for (int i = 1; i <= MaxInput; i += i)
			{
				for (int trial = 0; trial < numberOfTrials; trial++)
				{
					string testString = Generator.WorstCaseString(i);

					stopwatch.Restart();
					findLCS.BetterLCS(testString, testString);
					stopwatch.Stop();
					nanoSecs += stopwatch.Elapsed.TotalMilliseconds * 1000000;
				}
				double averageTrialTime = nanoSecs / numberOfTrials;

				if (previousRatio > 0)
				{
					doubleRatio = averageTrialTime / previousRatio;
				}
				previousRatio = averageTrialTime;

				Console.WriteLine("{0,-10}\t{1,16}\t\t{2,10:N2}", i, averageTrialTime, doubleRatio);

				using (StreamWriter outputFile = new StreamWriter(Path.Combine(resultsFolderPath, resultFile), true))
				{
					outputFile.WriteLine("{0,-10} {1,16} {2,10:N2}", i, averageTrialTime, doubleRatio);
				}
			}
		}

		public void BruteRandom(string resultFile)
		{
			double nanoSecs = 0;
			double doubleRatio = 0;
			double previousRatio = 0;
			Console.WriteLine("Input Size\tAvg Time (ns)\tDoubling Ratio");

			for (int i = 1; i <= MaxInput; i += i)
			{
				for (int trial = 0; trial < numberOfTrials; trial++)
				{
					string testString1 = Generator.RandomString(i);
					string testString2 = Generator.RandomString(i);

					stopwatch.Restart();
					findLCS.BruteLCS(testString1, testString2);
					stopwatch.Stop();
					nanoSecs += stopwatch.Elapsed.TotalMilliseconds * 1000000;
				}
				double averageTrialTime = nanoSecs / numberOfTrials;

				if (previousRatio > 0)
				{
					doubleRatio = averageTrialTime / previousRatio;
				}
				previousRatio = averageTrialTime;

				Console.WriteLine("{0,-10}\t{1,16}\t\t{2,10:N2}", i, averageTrialTime, doubleRatio);

				using (StreamWriter outputFile = new StreamWriter(Path.Combine(resultsFolderPath, resultFile), true))
				{
					outputFile.WriteLine("{0,-10} {1,16} {2,10:N2}", i, averageTrialTime, doubleRatio);
				}
			}
		}

		public void BetterRandom(string resultFile)
		{
			double nanoSecs = 0;
			double doubleRatio = 0;
			double previousRatio = 0;
			Console.WriteLine("Input Size\tAvg Time (ns)\tDoubling Ratio");

			for (int i = 1; i <= MaxInput; i += i)
			{
				for (int trial = 0; trial < numberOfTrials; trial++)
				{
					string testString1 = Generator.RandomString(i);
					string testString2 = Generator.RandomString(i);

					stopwatch.Restart();
					findLCS.BetterLCS(testString1, testString2);
					stopwatch.Stop();
					nanoSecs += stopwatch.Elapsed.TotalMilliseconds * 1000000;
				}
				double averageTrialTime = nanoSecs / numberOfTrials;

				if (previousRatio > 0)
				{
					doubleRatio = averageTrialTime / previousRatio;
				}
				previousRatio = averageTrialTime;

				Console.WriteLine("{0,-10}\t{1,16}\t\t{2,10:N2}", i, averageTrialTime, doubleRatio);

				using (StreamWriter outputFile = new StreamWriter(Path.Combine(resultsFolderPath, resultFile), true))
				{
					outputFile.WriteLine("{0,-10} {1,16} {2,10:N2}", i, averageTrialTime, doubleRatio);
				}
			}
		}

		public void BruteHugeText(string resultFile)
		{
			double nanoSecs = 0;
			double doubleRatio = 0;
			double previousRatio = 0;
			Console.WriteLine("Input Size\tAvg Time (ns)\tDoubling Ratio");

			for (int i = 1; i <= MaxInput; i += i)
			{
				for (int trial = 0; trial < numberOfTrials; trial++)
				{
					string testString1 = Generator.HugeString(i);
					string testString2 = Generator.HugeString(i);

					stopwatch.Restart();
					findLCS.BruteLCS(testString1, testString2);
					stopwatch.Stop();
					nanoSecs += stopwatch.Elapsed.TotalMilliseconds * 1000000;
				}
				double averageTrialTime = nanoSecs / numberOfTrials;

				if (previousRatio > 0)
				{
					doubleRatio = averageTrialTime / previousRatio;
				}
				previousRatio = averageTrialTime;

				Console.WriteLine("{0,-10}\t{1,16}\t\t{2,10:N2}", i, averageTrialTime, doubleRatio);

				using (StreamWriter outputFile = new StreamWriter(Path.Combine(resultsFolderPath, resultFile), true))
				{
					outputFile.WriteLine("{0,-10} {1,16} {2,10:N2}", i, averageTrialTime, doubleRatio);
				}
			}
		}

		public void BetterHugeText(string resultFile)
		{
			double nanoSecs = 0;
			double doubleRatio = 0;
			double previousRatio = 0;
			Console.WriteLine("Input Size\tAvg Time (ns)\tDoubling Ratio");

			for (int i = 1; i <= MaxInput; i += i)
			{
				for (int trial = 0; trial < numberOfTrials; trial++)
				{
					string testString1 = Generator.HugeString(i);
					string testString2 = Generator.HugeString(i);

					stopwatch.Restart();
					findLCS.BetterLCS(testString1, testString2);
					stopwatch.Stop();
					nanoSecs += stopwatch.Elapsed.TotalMilliseconds * 1000000;
				}
				double averageTrialTime = nanoSecs / numberOfTrials;

				if (previousRatio > 0)
				{
					doubleRatio = averageTrialTime / previousRatio;
				}
				previousRatio = averageTrialTime;

				Console.WriteLine("{0,-10}\t{1,16}\t\t{2,10:N2}", i, averageTrialTime, doubleRatio);

				using (StreamWriter outputFile = new StreamWriter(Path.Combine(resultsFolderPath, resultFile), true))
				{
					outputFile.WriteLine("{0,-10} {1,16} {2,10:N2}", i, averageTrialTime, doubleRatio);
				}
			}
		}

	}
}

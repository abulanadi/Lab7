using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
	class FindLCS
	{
		string string1;
		string string2;

		public void BruteLCS(string string1, string string2)
		{
			int L1 = string1.Length - 1;
			int L2 = string2.Length - 1;
			int lengthLCS = 0;
			int startIndexStr1 = 0;
			int startIndexStr2 = 0;

			for(int i = 0; i <= L1; i++)
			{
				for(int j = 0; j <= L2; j++)
				{
					for(int k = 0; k <= Math.Min(L1 - i, L2 - j); k++)
					{
						if(string1[i + k] != string2[j + k])
						{
							break;
						}
						if(k >= lengthLCS)
						{
							lengthLCS = k + 1;
							startIndexStr1 = i;
							startIndexStr2 = j;
						}
					}
				}
			}
			/*Console.WriteLine("String 1 is: {0}", string1);
			Console.WriteLine("String 2 is: {0}", string2);
			Console.WriteLine("Length of largest common substring = {0}", lengthLCS);
			if(lengthLCS > 0) 
			{
				Console.WriteLine("Starting index of string 1 = {0}", startIndexStr1);
				Console.WriteLine("Starting index of string 2 = {0}", startIndexStr2);
			}*/
			
		}

		public void BetterLCS(string string1, string string2)
		{
			int L1 = string1.Length;
			int L2 = string2.Length;
			int lengthLCS = 0;
			

			int[,] LCSuffixes = new int[L1 + 1, L2 + 1];

			for(int i = 0; i <= L1; i++)
			{
				for(int j = 0; j <= L2; j++)
				{
					if(i == 0 || j == 0)
					{
						LCSuffixes[i, j] = 0;
					}
					else if(string1[i - 1] == string2[j - 1])
					{
						LCSuffixes[i, j] = LCSuffixes[i - 1, j - 1] + 1;
						lengthLCS = Math.Max(lengthLCS, LCSuffixes[i, j]);
						
					}
					else
					{
						LCSuffixes[i, j] = 0;
					}
				}
			}
			//Console.WriteLine("Length of largest common substring = {0}", lengthLCS);
			
		}
	}
}

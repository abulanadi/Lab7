using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Lab7
{
	class StringGenerator
	{
		public const string Alphabet = "abcdefghijklmnopqrstuvwxyz";
		string Pygmalion = File.ReadAllText("C:\\Users\\Adria\\School Stuff\\CSC482\\Lab7\\Pygmalion.txt", Encoding.UTF8);
		string MobyDick = File.ReadAllText("C:\\Users\\Adria\\School Stuff\\CSC482\\Lab7\\MobyDick.txt", Encoding.UTF8);
		
		Random random = new Random();

		public string WorstCaseString(int size)
		{
			char[] newString = new char[size];
			newString[0] = Alphabet[random.Next(1, Alphabet.Length)];
			
			if(size == 1)
			{
				return new string(newString);
			}

			for(int i = 1; i < size; i++)
			{
				newString[i] = newString[0];
			}
			//Console.WriteLine(newString);
			return new string(newString);

		}

		public string RandomString(int size)
		{
			char[] newString = new char[size];
			newString[0] = Alphabet[random.Next(1, Alphabet.Length)];

			if (size == 1)
			{
				return new string(newString);
			}

			for (int i = 1; i < size; i++)
			{
				newString[i] = Alphabet[random.Next(1, Alphabet.Length)];
			}
			//Console.WriteLine(newString);
			return new string(newString);
		}

		public string HugeString(int size)
		{
			string hugeString = Pygmalion + MobyDick;
			char[] newString = new char[size];
			int startIndex = random.Next(0, hugeString.Length - 1);
			newString[0] = hugeString[startIndex];

			if (size == 1)
			{
				return new string(newString);
			}

			for (int i = 1; i < size - 1; i++)
			{
				newString[i] = hugeString[startIndex + i];
			}
			//Console.WriteLine(newString);
			return new string(newString);
		}
	}
}

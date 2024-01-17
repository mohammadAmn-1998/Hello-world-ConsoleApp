using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		public class EnglishWords
		{
			public string[] Words =
			{
				"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u",
				"v", "w", "x", "y", "z"
			};


		}

		static void Main(string[] args)
		{
			var word = "";
			var englishWords = new EnglishWords();
			string CheckStr(string character,int wordLength)
			{
				
				foreach (var Char in englishWords.Words)
				{
					Thread.Sleep(50);
					Console.WriteLine($"{word}{Char}");
					if (word.Length == wordLength && Char == character)
					{
						word += Char;
						break;
					}
						

				}

				return word;
			}

			;
			var str = "";
			while (str != "hello world")
			{
				str = CheckStr("h", 0);
				str = CheckStr("e", 1);
				str = CheckStr("l", 2);
				str = CheckStr("l", 3);
				str = CheckStr("o", 4);
				word += " ";
				str = CheckStr("w", 6);
				str = CheckStr("o", 7);
				str = CheckStr("r", 8);
				str = CheckStr("l", 9);
				str = CheckStr("d", 10);
				
			}
			
			
			Console.ReadLine();


		}
	}
}

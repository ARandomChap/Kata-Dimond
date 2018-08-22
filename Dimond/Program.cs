using System;

namespace Dimond
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int i, j, r;

			Console.Write("\n\n");
			Console.Write("Display the pattern like diamond:\n");
			Console.Write("-----------------------------------");
			Console.Write("\n\n");

			Console.Write("Input the letter to appear at the midpoint of the dimond :");

			// Because 'A' starts at ascii decimal 65.
			r = (int)Console.ReadKey().KeyChar - 64;
			Console.ReadLine();

			for (i = 0; i <= r; i++)
			{
				for (j = 1; j <= r - i; j++)
					Console.Write(" ");
				for (j = 1; j <= 2 * i - 1; j++)
				{
					if (j == 1 || j == 2 * i - 1)
						Console.Write((char)(i + 64));
					else
						Console.Write(" ");
				}
				Console.WriteLine();
			}

			for (i = r - 1; i >= 1; i--)
			{
				for (j = 1; j <= r - i; j++)
					Console.Write(" ");
				for (j = 1; j <= 2 * i - 1; j++)
				{
					if (j == 1 || j == 2 * i - 1)
						Console.Write((char)(i + 64));
					else
						Console.Write(" ");
				}
				Console.WriteLine();
			}
		}
	}
}

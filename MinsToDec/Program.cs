using System;

namespace MinsToDec
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length != 1)
			{
				Console.WriteLine("ERROR: Expected exactly one argument.");
				return;
			}


			try
			{
				var mins = int.Parse(args[0]);
				Console.WriteLine(mins / 60d);
			}
			catch
			{
				Console.WriteLine("ERROR: Invalid input.");
			}
		}
	}
}

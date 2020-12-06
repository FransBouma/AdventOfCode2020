using System.Collections.Generic;
using System.Linq;

namespace AoC2020.Core
{
	public static class Day2
	{
		public static int Solve1(List<PasswordEntry> input)
		{
			return input.Count(p => p.IsValidForPuzzle1());
		}
		
		
		public static int Solve2(List<PasswordEntry> input)
		{
			return input.Count(p => p.IsValidForPuzzle2());
		}
	}
}
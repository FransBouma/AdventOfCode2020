using System;
using System.Collections.Generic;

namespace AoC2020.Core
{
	public static class Day1
	{
		public static int Solve1(List<int> input)
		{
			var map = new Dictionary<int, int>();
			foreach(var i in input)
			{
				if(map.ContainsKey(i))
				{
					return i * map[i];
				}

				map[2020 - i] = i;
			}

			return -1;
		}

		public static int Solve2(List<int> input)
		{
			// sort ascending
			input.Sort();
			
			// We'll pick a value p at the start and seek further in the sorted input, where we pick a value q where p + (2*q) < 2020, as the value next to q
			// is at least the same as q. Then we'll seek a value r further where p+q+r==2020. If p+q+r >= 2020, we can never solve it for the current q, so we 
			// can try the next one. Till we exhausted the input or found our value.
			int p = 0, q = 0, r = 0;
			for(int i = 0; i < input.Count; i++)
			{
				p = input[i];
				for(int j = i + 1; j < input.Count; j++)
				{
					q = input[j];
					if(p + (2 * q) > 2020)
					{
						break;
					}
					for(int k = j + 1; k < input.Count; k++)
					{
						r = input[k];
						if(p + q + r == 2020)
						{
							return p * q * r;
						}
						if(p + q + r > 2020)
						{
							break;
						}
					}
				}
			}
			return -1;
		}
	}
}
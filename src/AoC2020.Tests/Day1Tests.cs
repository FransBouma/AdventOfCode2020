using System;
using System.IO;
using AoC2020.Core;
using NUnit.Framework;

namespace AoC2020.Tests
{
	public class Day1Tests
	{
		[SetUp]
		public void Setup()
		{
		}


		[Test]
		public void Puzzle1_ExampleInput()
		{
			var input = InputReader.GetInputAsIntList("..\\..\\..\\PuzzleInputs\\day1_example.txt");
			Assert.IsTrue(input.Count>0);
			Assert.AreEqual(514579, Day1.Solve1(input));
		}

		
		[Test]
		public void Puzzle1_Solver()
		{
			var input = InputReader.GetInputAsIntList("..\\..\\..\\PuzzleInputs\\day1.txt");
			Assert.IsTrue(input.Count>0);
			Console.WriteLine(Day1.Solve1(input));
		}

		
		[Test]
		public void Puzzle2_ExampleInput()
		{
			var input = InputReader.GetInputAsIntList("..\\..\\..\\PuzzleInputs\\day1_example.txt");
			Assert.IsTrue(input.Count>0);
			Assert.AreEqual(241861950, Day1.Solve2(input));
		}

		
		[Test]
		public void Puzzle2_Solver()
		{
			var input = InputReader.GetInputAsIntList("..\\..\\..\\PuzzleInputs\\day1.txt");
			Assert.IsTrue(input.Count>0);
			Console.WriteLine(Day1.Solve2(input));
		}
	}
}
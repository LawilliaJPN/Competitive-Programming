using System;
using System.Linq;

public class ABC164A {
	private static void Main(string[] args) {
		var input = ReadIntsAsArray();
		var s = input[0];
		var w = input[1];

		var answer = (w >= s) ? "unsafe" : "safe";
		Console.WriteLine(answer);
	}

	private static int[] ReadIntsAsArray() => Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).ToArray();
}